using Cherwell.Api.Exceptions;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Text.Json;
using System.Web;

namespace Cherwell.Api;

public class AuthenticatedHttpClientHandler : HttpClientHandler
{
	private const string AuthenticationType = "Bearer";
	private const int TokenSubtractSeconds = 30;
	private static readonly JsonSerializerOptions JsonOptions = CherwellJson.CreateSerializerOptions();
	private static readonly JsonSerializerOptions IndentedJsonOptions = CherwellJson.CreateSerializerOptions(true);

	private readonly CherwellClientOptions _options;
	private readonly ILogger _logger;
	private readonly HttpClient _authenticatingClient;
	private readonly int _maxAttempts;
	private string? _accessToken;
	private string? _refreshToken;
	private DateTime _tokenRefreshRequiredAt = DateTime.MaxValue;

	public AuthenticatedHttpClientHandler(CherwellClientOptions options, ILogger logger)
	{
		_options = options;
		_logger = logger;
		_maxAttempts = options.MaxAttempts;
		_authenticatingClient = new HttpClient { BaseAddress = new Uri(options.BaseAddress) };
		SetUserAgent(_authenticatingClient, _options.UserAgent);
	}

	/// <summary>
	/// Override of the base method that is used to handle the sending of a request.
	/// </summary>
	/// <param name="request">The request that is to be sent.</param>
	/// <param name="cancellationToken">A cancellation token for the operation.</param>
	/// <returns>The response to the request that was sent.</returns>
	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		try
		{
			var requestId = Guid.NewGuid();
			await AddAuthenticationAsync(request, cancellationToken).ConfigureAwait(false);
			AddCulture(request);
			await LogRequestAsync(requestId, request, cancellationToken).ConfigureAwait(false);
			var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
			await LogResponseAsync(requestId, response, cancellationToken).ConfigureAwait(false);
			await ThrowIfUnsuccessfulAsync(response, cancellationToken).ConfigureAwait(false);
			return response;
		}
		catch (Exception ex) when (ex is not CherwellApiException)
		{
			throw new CherwellApiException("Unexpected Cherwell API exception.", ex);
		}
	}

	private async Task AddAuthenticationAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (request.Headers.Authorization is null)
		{
			var accessToken = await GetAccessTokenAsync(cancellationToken).ConfigureAwait(false);
			request.Headers.Authorization = new AuthenticationHeaderValue(AuthenticationType, accessToken);
		}
	}

	private void AddCulture(HttpRequestMessage request)
	{
		if (_options.Culture is null)
		{
			return;
		}

		var requestUri = request.RequestUri
			?? throw new InvalidOperationException("RequestUri must be set before sending the request.");
		var uriBuilder = new UriBuilder(requestUri);
		var query = HttpUtility.ParseQueryString(uriBuilder.Query);
		query["locale"] = _options.Culture.Name;
		uriBuilder.Query = query.ToString();
		request.RequestUri = uriBuilder.Uri;
	}

	private async Task LogRequestAsync(Guid requestId, HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(LogLevel.Debug))
		{
			return;
		}

		var body = request.Content is null
			? string.Empty
			: await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
		_logger.LogDebug(
			"{RequestId}: REQUEST: Url:{Url}\nHeaders:{Headers}\nBody: {Body}",
			requestId,
			request.RequestUri,
			FormatHeaders(request.Headers),
			FormatJson(body));
	}

	private async Task LogResponseAsync(Guid requestId, HttpResponseMessage response, CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(LogLevel.Debug))
		{
			return;
		}

		var body = response.Content is null
			? string.Empty
			: await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
		_logger.LogDebug(
			"{RequestId}: RESPONSE: {StatusCode}\nHeaders:{Headers}\nBody: {Body}",
			requestId,
			response.StatusCode,
			FormatHeaders(response.Headers),
			FormatJson(body));
	}

	private static string FormatHeaders(HttpHeaders headers) =>
		string.Join("\n", headers.Select(header => $"{header.Key}: {string.Join(", ", header.Value)}"));

	private static string FormatJson(string body)
	{
		try
		{
			using var document = JsonDocument.Parse(body);
			return JsonSerializer.Serialize(document.RootElement, IndentedJsonOptions);
		}
		catch (JsonException)
		{
			return body;
		}
	}

	private static async Task ThrowIfUnsuccessfulAsync(HttpResponseMessage httpResponse, CancellationToken cancellationToken)
	{
		if (httpResponse.IsSuccessStatusCode)
		{
			return;
		}

		var body = httpResponse.Content is null
			? string.Empty
			: await httpResponse.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
		Response? response;
		try
		{
			response = JsonSerializer.Deserialize<Response>(body, JsonOptions);
		}
		catch (JsonException)
		{
			throw CreateUnstructuredResponseException(httpResponse, body);
		}

		if (response is null)
		{
			throw CreateUnstructuredResponseException(httpResponse, body);
		}

		if (response.HttpStatusCode is null or EnumHttpStatusCode.None)
		{
			response.HttpStatusCode = (EnumHttpStatusCode)httpResponse.StatusCode;
		}

		var reason = $"Cherwell responded with {response.ErrorCode} ({response.HttpStatusCode})";
		if (!string.IsNullOrWhiteSpace(response.ErrorMessage))
		{
			reason += $", with message: {response.ErrorMessage}";
		}

		throw new CherwellApiException(response, reason);
	}

	private static CherwellApiException CreateUnstructuredResponseException(HttpResponseMessage response, string body)
	{
		var reason = $"Cherwell responded with {response.StatusCode} ({response.ReasonPhrase})";
		if (!string.IsNullOrWhiteSpace(body))
		{
			reason += $" - {body}";
		}

		return new CherwellApiException(reason);
	}

	private async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken)
	{
		if (_accessToken is null)
		{
			_logger.LogDebug("Requesting authentication token");
			await GenerateAccessTokenAsync(GrantTypes.Password, cancellationToken).ConfigureAwait(false);
			return _accessToken!;
		}

		if (_tokenRefreshRequiredAt > DateTime.Now)
		{
			return _accessToken;
		}

		_logger.LogDebug("Refreshing authentication token");
		await GenerateAccessTokenAsync(GrantTypes.RefreshToken, cancellationToken).ConfigureAwait(false);
		return _accessToken;
	}

	private async Task GenerateAccessTokenAsync(GrantTypes grantType, CancellationToken cancellationToken)
	{
		using var httpClient = CreateTokenClient();
		var grantTypeString = GetGrantTypeValue(grantType);
		var retryDelay = TimeSpan.FromSeconds(10);

		for (var attempt = 1; attempt <= _maxAttempts; attempt++)
		{
			if (_logger.IsEnabled(LogLevel.Information))
			{
				_logger.LogInformation(
					"Cherwell 'GenerateAccessTokenAsync' (attempt {Attempt}/{MaxAttempts})",
					attempt,
					_maxAttempts);
			}
			using var response = await SendTokenRequestAsync(
				httpClient,
				grantTypeString,
				cancellationToken).ConfigureAwait(false);
			var responseBody = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

			if (response.IsSuccessStatusCode)
			{
				StoreToken(responseBody);
				return;
			}

			ThrowIfAuthenticationRejected(response, responseBody);
			if (attempt < _maxAttempts)
			{
				if (_logger.IsEnabled(LogLevel.Information))
				{
					_logger.LogInformation(
						"Cherwell 'GenerateAccessTokenAsync' failed with status code {StatusCode}: waiting {RetryDelayMs}ms before retrying...",
						response.StatusCode,
						retryDelay.TotalMilliseconds);
				}
				await Task.Delay(retryDelay, cancellationToken).ConfigureAwait(false);
				retryDelay *= 2;
			}
		}

		throw new AuthenticationException($"Authentication failed after {_maxAttempts} attempts");
	}

	private HttpClient CreateTokenClient()
	{
		var httpClient = new HttpClient { BaseAddress = new Uri($"{_options.BaseAddress}/token") };
		SetUserAgent(httpClient, _options.UserAgent);
		var credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_options.ClientId}:"));
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
		return httpClient;
	}

	private static string GetGrantTypeValue(GrantTypes grantType) => grantType switch
	{
		GrantTypes.Password => "password",
		GrantTypes.RefreshToken => "refresh_token",
		_ => throw new ArgumentOutOfRangeException(nameof(grantType))
	};

	private async Task<HttpResponseMessage> SendTokenRequestAsync(
		HttpClient httpClient,
		string grantType,
		CancellationToken cancellationToken)
	{
		var values = new List<KeyValuePair<string, string>>
		{
			new("grant_type", grantType),
			new("username", _options.UserName!),
			new("password", _options.Password!)
		};
		if (_refreshToken is not null)
		{
			values.Add(new("refresh_token", _refreshToken));
		}

		using var request = new HttpRequestMessage(HttpMethod.Post, "token")
		{
			Content = new FormUrlEncodedContent(values)
		};
		request.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded")
		{
			CharSet = "UTF-8"
		};
		return await httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
	}

	private void StoreToken(string responseBody)
	{
		var tokenResponse = JsonSerializer.Deserialize<TokenResponse>(responseBody, JsonOptions)
			?? throw new AuthenticationException("Could not deserialize content as a TokenResponse.");
		_accessToken = tokenResponse.AccessToken;
		_refreshToken = tokenResponse.RefreshToken;
		_tokenRefreshRequiredAt = DateTime.Now.AddSeconds(tokenResponse.ExpiresIn - TokenSubtractSeconds);
	}

	private static void ThrowIfAuthenticationRejected(HttpResponseMessage response, string responseBody)
	{
		if ((int)response.StatusCode / 100 != 4)
		{
			return;
		}

		var reason = string.IsNullOrWhiteSpace(response.ReasonPhrase)
			? responseBody
			: $"{response.ReasonPhrase}: {responseBody}";
		throw new AuthenticationException(
			$"Cherwell 'GenerateAccessTokenAsync' response unsuccessful: {reason}");
	}

	private static void SetUserAgent(HttpClient httpClient, string? userAgentString)
	{
		if (userAgentString is null)
		{
			return;
		}

		var userAgentArray = userAgentString.Split('/');
		if (userAgentArray.Length != 2)
		{
			throw new FormatException(
				"UserAgent should be in the form 'SystemName/1.0', where 1.0 is the system version in the form 'Major.Minor'");
		}

		httpClient.DefaultRequestHeaders.UserAgent.Add(
			new ProductInfoHeaderValue(userAgentArray[0], userAgentArray[1]));
	}

	private async Task LogoutAsync()
	{
		if (_accessToken is null)
		{
			return;
		}

		using var request = new HttpRequestMessage(HttpMethod.Delete, "api/V1/logout");
		request.Headers.Authorization = new AuthenticationHeaderValue(AuthenticationType, _accessToken);
		using var response = await _authenticatingClient.SendAsync(request).ConfigureAwait(false);
		if (!response.IsSuccessStatusCode)
		{
			_logger.LogWarning("Could not log out: {Message}", Resources.FailedToLogOut);
#if DEBUG
			throw new AuthenticationException();
#endif
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			LogoutAsync().GetAwaiter().GetResult();
			_authenticatingClient.Dispose();
		}

		base.Dispose(disposing);
	}

	private enum GrantTypes
	{
		Password,
		RefreshToken
	}
}
