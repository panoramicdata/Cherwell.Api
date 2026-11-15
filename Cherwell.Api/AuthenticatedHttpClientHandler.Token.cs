using Cherwell.Api.Exceptions;
using Microsoft.Extensions.Logging;
using System.Security.Authentication;
using System.Text;
using System.Text.Json;
using System.Net.Http.Headers;

namespace Cherwell.Api;

public partial class AuthenticatedHttpClientHandler
{
	private const int TokenSubtractSeconds = 30;
	private string? _accessToken;
	private string? _refreshToken;
	private DateTime _tokenRefreshRequiredAt = DateTime.MaxValue;

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
			LogTokenAttempt(attempt);
			using var response = await SendTokenRequestAsync(
				httpClient,
				grantTypeString,
				cancellationToken).ConfigureAwait(false);
			var responseBody = await ReadBodyAsync(response.Content, cancellationToken).ConfigureAwait(false);

			if (response.IsSuccessStatusCode)
			{
				StoreToken(responseBody);
				return;
			}

			retryDelay = await HandleTokenFailureAsync(response, responseBody, attempt, retryDelay, cancellationToken)
				.ConfigureAwait(false);
		}

		throw new AuthenticationException($"Authentication failed after {_maxAttempts} attempts");
	}

	private async Task<HttpResponseMessage> SendTokenRequestAsync(
		HttpClient httpClient,
		string grantType,
		CancellationToken cancellationToken)
	{
		using var request = CreateTokenRequest(grantType);
		return await httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
	}

	private async Task<TimeSpan> HandleTokenFailureAsync(
		HttpResponseMessage response,
		string responseBody,
		int attempt,
		TimeSpan retryDelay,
		CancellationToken cancellationToken)
	{
		ThrowIfAuthenticationRejected(response, responseBody);
		if (attempt < _maxAttempts)
		{
			LogTokenRetry(response, retryDelay);
			await Task.Delay(retryDelay, cancellationToken).ConfigureAwait(false);
			retryDelay *= 2;
		}

		return retryDelay;
	}

	private void LogTokenAttempt(int attempt)
	{
		if (_logger.IsEnabled(LogLevel.Information))
		{
			_logger.LogInformation(
				"Cherwell 'GenerateAccessTokenAsync' (attempt {Attempt}/{MaxAttempts})",
				attempt,
				_maxAttempts);
		}
	}

	private void LogTokenRetry(HttpResponseMessage response, TimeSpan retryDelay)
	{
		if (_logger.IsEnabled(LogLevel.Information))
		{
			_logger.LogInformation(
				"Cherwell 'GenerateAccessTokenAsync' failed with status code {StatusCode}: waiting {RetryDelayMs}ms before retrying...",
				response.StatusCode,
				retryDelay.TotalMilliseconds);
		}
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

	/// <summary>
	/// Builds the OAuth2 token request.
	/// </summary>
	/// <remarks>
	/// Cherwell expects the authentication mode as the "auth_mode" query parameter and the API client id
	/// as the "client_id" form field. Sending the client id only as an HTTP Basic credential, and omitting
	/// auth_mode entirely, is rejected by Windows and LDAP configured instances - which is what made
	/// AuthenticationMode a setting that validated but did nothing. See
	/// https://help.ivanti.com/ch/help/en_US/CSM/10.5/documentation_bundle/system_administration/rest_api/csm_rest_oauth2_windows_ldap_entered_credentials_authentication.html
	/// </remarks>
	/// <param name="grantType">The OAuth2 grant type being requested.</param>
	internal HttpRequestMessage CreateTokenRequest(string grantType)
	{
		var values = CreateTokenValues(grantType);

		var requestUri = $"token?auth_mode={Uri.EscapeDataString(_options.AuthenticationMode)}";
		var request = new HttpRequestMessage(HttpMethod.Post, requestUri)
		{
			Content = new FormUrlEncodedContent(values)
		};
		request.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded")
		{
			CharSet = "UTF-8"
		};
		return request;
	}

	private List<KeyValuePair<string, string>> CreateTokenValues(string grantType)
	{
		var values = new List<KeyValuePair<string, string>>
		{
			new("grant_type", grantType),
			new("client_id", _options.ClientId!),
			new("username", _options.UserName!),
			new("password", _options.Password!)
		};
		AddRefreshTokenValue(values);
		return values;
	}

	private void AddRefreshTokenValue(List<KeyValuePair<string, string>> values)
	{
		if (_refreshToken is not null)
		{
			values.Add(new("refresh_token", _refreshToken));
		}
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

	private enum GrantTypes
	{
		Password,
		RefreshToken
	}
}
