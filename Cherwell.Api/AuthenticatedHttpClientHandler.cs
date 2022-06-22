using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Authentication;
using System.Text.Json;

namespace Cherwell.Api
{
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
			_authenticatingClient = new HttpClient();
			_authenticatingClient.BaseAddress = new Uri(options.BaseAddress!);
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
			var grantTypeString = grantType switch
			{
				GrantTypes.Password => "password",
				GrantTypes.RefreshToken => "refresh_token",
				_ => throw new ArgumentOutOfRangeException(nameof(grantType))
			};
			var tokenRequest = new TokenRequest()
			{
				grant_type = grantTypeString,
				client_id = _options.ClientId,
				username = _options.UserName,
				password = _options.Password,
				refresh_token = _refreshToken,
				auth_mode = _options.AuthenticationMode
			};

			var response = await _authenticatingClient
				.PostAsJsonAsync("/token", tokenRequest, cancellationToken)
				.ConfigureAwait(false);

			// TODO: Investigate - and better handle - unsuccessful auth requests
			if (!response.IsSuccessStatusCode)
			{
				throw new AuthenticationException();
			}

			var tokenResponse = await response
				.Content
				.ReadFromJsonAsync<SecurityTokenResponse>(new JsonSerializerOptions(), cancellationToken)
				.ConfigureAwait(false);
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
			var request = new HttpRequestMessage(HttpMethod.Delete, "/api/V1/logout");
			request.Headers.Authorization = new AuthenticationHeaderValue(_authenticationType, _accessToken);

			var response = await _authenticatingClient
				.SendAsync(request)
				.ConfigureAwait(false);
			if (!response.IsSuccessStatusCode)
			{
				_logger.LogWarning(Resources.FailedToLogOut);
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
}
