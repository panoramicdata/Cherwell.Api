using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;

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

	public AuthenticatedHttpClientHandler(CherwellClientOptions options, ILogger logger)
	{
		_options = options;
		_logger = logger;
		_authenticatingClient = new HttpClient
		{
			BaseAddress = new Uri(options.BaseAddress!)
		};
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
		// See if the request has an authorize header
		var auth = request.Headers.Authorization;
		if (auth is null)
		{
			var accessToken = await GetAccessTokenAsync(cancellationToken);
			request.Headers.Authorization = new AuthenticationHeaderValue(_authenticationType, accessToken);
		}

		// Add a user agent to ensure consistent behaviour
		if (_options.UserAgent is not null)
		{
			var userAgentArray = _options.UserAgent.Split('/');
			if (userAgentArray.Length != 2)
			{
				throw new FormatException("UserAgent should be in the form 'SystemName/1.0', where 1.0 is the system version in the form 'Major.Minor'");
			}

			request.Headers.UserAgent.Add(new ProductInfoHeaderValue(userAgentArray[0], userAgentArray[1]));
		}

		return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
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
		using var httpClient = new HttpClient()
		{
			BaseAddress = new($"{_options.BaseAddress}/token"),
		};

		if (_options.UserAgent is not null)
		{
			httpClient.DefaultRequestHeaders.Add("User-Agent", _options.UserAgent);
		}

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

		var response = await httpClient
			.SendAsync(request, cancellationToken)
			.ConfigureAwait(false);

		// TODO: Investigate - and better handle - unsuccessful auth requests
		if (!response.IsSuccessStatusCode)
		{
			throw new AuthenticationException();
		}

		var stringResponse = await response
			.Content
			.ReadAsStringAsync(cancellationToken)
			.ConfigureAwait(false);

		var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(stringResponse);
		if (tokenResponse is null)
		{
			// TODO: Move exception text to Resources file
			throw new AuthenticationException("No body in the response!");
		}

		_accessToken = tokenResponse.AccessToken;
		_refreshToken = tokenResponse.RefreshToken;
		_tokenRefreshRequiredAt = DateTime.Now.AddMinutes((tokenResponse.ExpiresIn ?? 15) - 1);
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

	#region Private Helper Types

	private class TokenRequest
	{
		public string? grant_type { get; set; }
		public string? client_id { get; set; }
		public string? client_secret { get; set; }
		public string? username { get; set; }
		public string? password { get; set; }
		public string? refresh_token { get; set; }
		public string? auth_mode { get; set; }
		public string? site_name { get; set; }
	}

	#endregion
}