using Cherwell.Api.Exceptions;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Web;

namespace Cherwell.Api;

public partial class AuthenticatedHttpClientHandler : HttpClientHandler
{
	private const string AuthenticationType = "Bearer";
	private const int TokenSubtractSeconds = 30;
	private static readonly JsonSerializerOptions JsonOptions = CherwellJson.CreateSerializerOptions();

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
		if (_options.IsReadOnly && !IsReadRequest(request))
		{
			throw new InvalidOperationException($"{request.Method} {request.RequestUri} is refused because CherwellClientOptions.IsReadOnly is set.");
		}

		try
		{
			return await SendRequestAsync(request, cancellationToken).ConfigureAwait(false);
		}
		catch (Exception ex) when (ex is not CherwellApiException)
		{
			throw new CherwellApiException("Unexpected Cherwell API exception.", ex);
		}
	}

	private static readonly HashSet<string> ReadOnlyPostOperations = new(StringComparer.OrdinalIgnoreCase)
	{
		"fieldvalueslookup",
		"getbusinessobjectattachments",
		"getbusinessobjectbatch",
		"getbusinessobjecttemplate",
		"getquicksearchconfigurationforbusobs",
		"getquicksearchresults",
		"getquicksearchspecificresults",
		"getrelatedbusinessobject",
		"getsearchresults",
		"getsearchresultsexport",
		"getuserbatch",
		"storedsearches"
	};

	// Cherwell reads some data with POST, so those operations are allowed by name.
	internal static bool IsReadRequest(HttpRequestMessage request)
	{
		if (request.Method == HttpMethod.Get || request.Method == HttpMethod.Head || request.Method == HttpMethod.Options)
		{
			return true;
		}

		if (request.Method != HttpMethod.Post)
		{
			return false;
		}

		var uri = request.RequestUri;
		var path = uri is null ? string.Empty : uri.IsAbsoluteUri ? uri.AbsolutePath : uri.OriginalString.Split('?')[0];
		return ReadOnlyPostOperations.Contains(path.TrimEnd('/').Split('/')[^1]);
	}

	private async Task<HttpResponseMessage> SendRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
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
}
