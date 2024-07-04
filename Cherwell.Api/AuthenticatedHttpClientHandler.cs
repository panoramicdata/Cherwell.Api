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

	public AuthenticatedHttpClientHandler(
		CherwellClientOptions options,
		ILogger logger)
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
	protected override async Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		try
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
					? await request
						.Content
						.ReadAsStringAsync()
						.ConfigureAwait(false)
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
				;

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
					? await httpResponse
						.Content
						.ReadAsStringAsync()
						.ConfigureAwait(false)
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
					throw string.IsNullOrWhiteSpace(response.ErrorMessage)
						? new CherwellApiException(response, $"Cherwell responded with {response.ErrorCode} ({response.HttpStatusCode})")
						: new CherwellApiException(response, $"Cherwell responded with {response.ErrorCode} ({response.HttpStatusCode}), with message: {response.ErrorMessage}");
				}
			}

			return httpResponse;
		}
		catch (CherwellApiException)
		{
			throw;
		}
		catch (Exception ex)
		{
			throw new CherwellApiException("Unexpected Cherwell API exception.", ex);
		}
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
				;
			return _accessToken!;
		}

		if (_tokenRefreshRequiredAt > DateTime.Now)
		{
			return _accessToken;
		}

		// The time has come to refresh the token
		_logger.LogDebug("Refreshing authentication token");
		await GenerateAccessTokenAsync(GrantTypes.RefreshToken, cancellationToken)
			;
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

		HttpResponseMessage? response = null;
		var attemptCount = 0;
		var retryDelayMs = 10000;
		do
		{
			attemptCount++;
			_logger.LogInformation(
				"Cherwell 'GenerateAccessTokenAsync' (attempt {Attempt}/{MaxAttempts})",
				attemptCount,
				_maxAttempts
			);

			using (var request = new HttpRequestMessage(HttpMethod.Post, "token"))
			{

				var keyValues = new List<KeyValuePair<string, string>>
				{
					new("grant_type", grantTypeString),
					new("username", _options.UserName!),
					new("password", _options.Password!)
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

				response = await httpClient
					.SendAsync(request, cancellationToken)
					;
			}

			var stringResponse = await response
				.Content
				.ReadAsStringAsync()
				;

			// Did auth succeed?
			if (response.IsSuccessStatusCode)
			{
				// Yes.  Try to parse the response
				var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(stringResponse);

				// Did we parse the token?
				if (tokenResponse is null)
				{
					// No.
					_logger.LogError("Could not deserialize content as a TokenResponse.");
					throw new AuthenticationException("Could not deserialize content as a TokenResponse.");
				}
				// Yes

				// Store and return
				_accessToken = tokenResponse.AccessToken;
				_refreshToken = tokenResponse.RefreshToken;
				_tokenRefreshRequiredAt = DateTime.Now.AddSeconds((tokenResponse.ExpiresIn) - _tokenSubtractSeconds);
				return;
			}
			// No.

			// Is it a 4xx error?
			if ((int)response.StatusCode / 100 == 4)
			{
				// Yes.  Log the error and throw an exception
				if (!string.IsNullOrWhiteSpace(response.ReasonPhrase))
				{
					_logger.LogError(
						"Cherwell 'GenerateAccessTokenAsync' response unsuccessful: {Reason}: {Content}",
						response.ReasonPhrase,
						stringResponse);

					throw new AuthenticationException($"Cherwell 'GenerateAccessTokenAsync' response unsuccessful: {response.ReasonPhrase}: {stringResponse}");
				}

				throw new AuthenticationException(
					$"Cherwell 'GenerateAccessTokenAsync' response unsuccessful: {stringResponse}");
			}

			// Wait before retrying
			_logger.LogInformation(
				"Cherwell 'GenerateAccessTokenAsync' failed with status code {StatusCode}: waiting {RetryDelayMs}ms before retrying...",
				response.StatusCode,
				retryDelayMs);

			await Task.Delay(retryDelayMs, cancellationToken).ConfigureAwait(false);
			retryDelayMs *= 2;
			continue;
		}
		while (attemptCount <= _maxAttempts);

		throw new AuthenticationException(
			$"Authentication failed after {_maxAttempts} attempts");
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
			.SendAsync(request);

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
		if (_accessToken is not null)
		{
			await LogoutAsync();
		}

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