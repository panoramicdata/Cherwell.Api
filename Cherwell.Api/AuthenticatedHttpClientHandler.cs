using Cherwell.Api.Exceptions;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Web;

namespace Cherwell.Api;

public class AuthenticatedHttpClientHandler : HttpClientHandler
{
	private readonly CherwellClientOptions _options;
	private readonly ILogger _logger;
	private readonly HttpClient _authenticatingClient;
	private string? _accessToken;
	private string? _refreshToken;
	private DateTime _tokenRefreshRequiredAt = DateTime.MaxValue;
	private const string _authenticationType = "Bearer";
	private const int _tokenSubtractSeconds = 30;   // Used as a 'safe window' to refresh the token N seconds before expiry. Was previously 5
	private readonly int _maxAttempts = 5;

	public AuthenticatedHttpClientHandler(CherwellClientOptions options, ILogger logger)
	{
		_options = options;
		_logger = logger;
		_maxAttempts = options.MaxAttempts;

		_authenticatingClient = new HttpClient
		{
			BaseAddress = new Uri(options.BaseAddress)
		};
		SetUserAgent(_authenticatingClient, _options.UserAgent);
	}

	/// <summary>
	/// Override of the base method that is used to handle the sending of a request
	/// </summary>
	/// <param name="request">The request that is to be sent</param>
	/// <param name="cancellationToken">A cancellation token for the operation</param>
	/// <returns>The response to the request that was sent</returns>
	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		// Generate a unique request id
		var requestId = Guid.NewGuid();

		// Does the request has an authorize header?
		var auth = request.Headers.Authorization;
		if (auth is null)
		{
			// No.  Add one.
			var accessToken = await GetAccessTokenAsync(cancellationToken);
			request.Headers.Authorization = new AuthenticationHeaderValue(_authenticationType, accessToken);
		}
		// The request now has an authorize header

		// Check the logging level as the operation to
		// extract the content is expensive
		if (_logger.IsEnabled(LogLevel.Debug))
		{
			var url = request.RequestUri!.ToString();
			var headers = string.Join("\n", request.Headers.Select(h => $"{h.Key}: {string.Join(", ", h.Value.Select(v => v))}"));
			var body = request.Content is not null
				? await request.Content.ReadAsStringAsync().ConfigureAwait(false)
				: string.Empty;
			var jObject = JsonConvert.DeserializeObject<JObject>(body);
			if (jObject is not null)
			{
				body = JsonConvert.SerializeObject(jObject, Formatting.Indented);
			}

			_logger.LogDebug(
				"{RequestId}: REQUEST: Url:{Url}\nHeaders:{Headers}\nBody: {Body}",
				requestId,
				url,
				headers,
				body);
		}

		if (_options.Culture is not null)
		{
			// Add the culture as a query parameter
			var uriBuilder = new UriBuilder(request.RequestUri);
			var query = HttpUtility.ParseQueryString(uriBuilder.Query);
			query["locale"] = _options.Culture.Name;
			uriBuilder.Query = query.ToString();
			request.RequestUri = uriBuilder.Uri;
		}

		// Make the HTTP call
		var httpResponse = await base
			.SendAsync(request, cancellationToken)
			.ConfigureAwait(false);

		// Check the logging level as the operation to
		// extract the content is expensive
		if (_logger.IsEnabled(LogLevel.Debug))
		{
			var headers = string.Join("\n", httpResponse.Headers.Select(h => $"{h.Key}: {string.Join(", ", h.Value.Select(v => v))}"));
			var body = httpResponse.Content is not null
				? await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false)
				: string.Empty;
			try
			{
				var jObject = JsonConvert.DeserializeObject<JObject>(body);
				if (jObject is not null)
				{
					body = JsonConvert.SerializeObject(jObject, Formatting.Indented);
				}
			}
			catch (Exception)
			{
				// This doesn't work for arrays, which return the JArray type
			}

			_logger.LogDebug(
				"{RequestId}: RESPONSE: {StatusCode}\nHeaders:{Headers}\nBody: {Body}",
				requestId,
				httpResponse.StatusCode,
				headers,
				body);
		}

		// Was the request successful?
		if (!httpResponse.IsSuccessStatusCode)
		{
			// No.

			// Is this a Cherwell Response?
			var body = httpResponse.Content is not null
				? await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false)
				: string.Empty;
			var response = JsonConvert.DeserializeObject<Response>(body);
			if (response is not null)
			{
				// Yes.

				// Update the status code if not set
				if (response.HttpStatusCode is null || response.HttpStatusCode == EnumHttpStatusCode.None)
				{
					response.HttpStatusCode = (EnumHttpStatusCode)httpResponse.StatusCode;
				}

				// Throw a CherwellApiException before Refit can get hold of it.
				throw new CherwellApiException(response);
			}
		}

		return httpResponse;
	}

	/// <summary>
	/// Get the access token, either a cached value, or one requested from the source
	/// </summary>
	/// <param name="cancellationToken">The token used to manage cancellation</param>
	/// <returns>The required access token for access to the Cherwell API</returns>
	private async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken)
	{
		if (_accessToken is null)
		{
			// First connection; we need to create a token
			_logger.LogDebug("Requesting authentication token");
			await GenerateAccessTokenAsync(GrantTypes.Password, cancellationToken)
				.ConfigureAwait(false);
			return _accessToken!;
		}

		if (_tokenRefreshRequiredAt > DateTime.Now)
		{
			return _accessToken;
		}

		// The time has come to refresh the token
		_logger.LogDebug("Refreshing authentication token");
		await GenerateAccessTokenAsync(GrantTypes.RefreshToken, cancellationToken)
			.ConfigureAwait(false);
		return _accessToken;
	}

	/// <summary>
	/// Generate an access token by attempting to get one from the remote service
	/// </summary>
	/// <param name="grantType">The type of grant required</param>
	/// <param name="cancellationToken">The token used to manage cancellation</param>
	/// <exception cref="AuthenticationException">The authentication attempt was not successful</exception>
	private async Task GenerateAccessTokenAsync(GrantTypes grantType, CancellationToken cancellationToken)
	{
		using var httpClient = new HttpClient
		{
			BaseAddress = new($"{_options.BaseAddress}/token"),
		};
		SetUserAgent(httpClient, _options.UserAgent);

		var base64String = (string?)Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_options.ClientId}:"));
		httpClient.DefaultRequestHeaders.Add("Authorization", $"Basic {base64String}");

		var grantTypeString = grantType switch
		{
			GrantTypes.Password => "password",
			GrantTypes.RefreshToken => "refresh_token",
			_ => throw new ArgumentOutOfRangeException(nameof(grantType))
		};

		var request = new HttpRequestMessage(HttpMethod.Post, "token");

		var keyValues = new List<KeyValuePair<string, string>>
		{
			new KeyValuePair<string, string>("grant_type", grantTypeString),
			new KeyValuePair<string, string>("username", _options.UserName!),
			new KeyValuePair<string, string>("password", _options.Password!)
		};

		if (_refreshToken is not null)
		{
			keyValues.Add(new KeyValuePair<string, string>("refresh_token", _refreshToken!));
		}

		request.Content = new FormUrlEncodedContent(keyValues);
		request.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded")
		{
			CharSet = "UTF-8"
		};

		HttpResponseMessage? response = null;
		var attemptCount = 0;
		do
		{
			attemptCount++;

			response = await httpClient
				.SendAsync(request, cancellationToken)
				.ConfigureAwait(false);

			if (response.IsSuccessStatusCode)
			{
				// Exit the while loop
				break;
			}

			// Was not successful
			if (attemptCount >= _maxAttempts)
			{
				if (!string.IsNullOrWhiteSpace(response.ReasonPhrase))
				{
					_logger.LogError("Response unsuccessfull: {Reason}", response.ReasonPhrase);
					throw new AuthenticationException(response.ReasonPhrase);
				}

				throw new AuthenticationException("Response unsuccessful. No reason phrase was provided by the server.");
			}

			// Wait 10 seconds
			await Task.Delay(10000, cancellationToken).ConfigureAwait(false);
		}
		while (attemptCount <= _maxAttempts);

		var stringResponse = await response
			.Content
			.ReadAsStringAsync()
			.ConfigureAwait(false);

		var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(stringResponse);
		if (tokenResponse is null)
		{
			// TODO: Move exception text to Resources file
			throw new AuthenticationException("No body in the response!");
		}

		_accessToken = tokenResponse.AccessToken;
		_refreshToken = tokenResponse.RefreshToken;
		_tokenRefreshRequiredAt = DateTime.Now.AddSeconds((tokenResponse.ExpiresIn) - _tokenSubtractSeconds);
	}

	private static void SetUserAgent(HttpClient httpClient, string? userAgentString)
	{
		// Add a user agent to ensure consistent behaviour
		if (userAgentString is null)
		{
			return;
		}

		var userAgentArray = userAgentString.Split('/');
		if (userAgentArray.Length != 2)
		{
			throw new FormatException("UserAgent should be in the form 'SystemName/1.0', where 1.0 is the system version in the form 'Major.Minor'");
		}

		httpClient
			.DefaultRequestHeaders
			.UserAgent
			.Add(new ProductInfoHeaderValue(userAgentArray[0], userAgentArray[1]));
	}

	/// <summary>
	/// Log out, invalidating the access token for improved security
	/// </summary>
	private async Task LogoutAsync()
	{
		if (_accessToken is null)
		{
			return;
		}

		// TODO: Should we parameterise the version of the API in use?
		var request = new HttpRequestMessage(HttpMethod.Delete, "api/V1/logout");
		request.Headers.Authorization = new AuthenticationHeaderValue(_authenticationType, _accessToken);

		var response = await _authenticatingClient
			.SendAsync(request)
			.ConfigureAwait(false);
		if (!response.IsSuccessStatusCode)
		{
			_logger.LogWarning("Could not log out: {Message}", Resources.FailedToLogOut);
#if DEBUG
			throw new AuthenticationException();
#endif
		}
	}

	#region Dispose

	protected override async void Dispose(bool disposing)
	{
		// Tidy up, including logging out
		await LogoutAsync()
			.ConfigureAwait(false);
		_authenticatingClient?.Dispose();

		base.Dispose(disposing);
	}

	#endregion

	#region Private Enums

	private enum GrantTypes
	{
		Password = 0,
		RefreshToken = 1
	}

	#endregion
}