using Cherwell.Api.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Refit;

namespace Cherwell.Api;

/// <summary>
/// API client is mainly responsible for making the HTTP call to the API backend.
/// </summary>
public partial class CherwellClient : IDisposable
{
	private readonly ILogger _logger;
	private readonly HttpClient _httpClient;

	/// <summary>
	/// Create an instance of the client for accessing the Cherwell API
	/// </summary>
	/// <param name="options">The options to be used when accessing the API</param>
	/// <param name="logger">Optional logger to which to output details of the operations performed</param>
	public CherwellClient(CherwellClientOptions options, ILogger? logger = null)
	{
		ArgumentNullException.ThrowIfNull(options);
		_logger = logger ?? NullLogger.Instance;

		// Validate that all of the necessary configuration has been provided
		options.Validate();
		if (string.IsNullOrWhiteSpace(options.UserAgent))
		{
			//options.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36 Edge/12.246";
			options.UserAgent = "Cherwell.Api";
		}

		_httpClient = new HttpClient(new AuthenticatedHttpClientHandler(options, _logger))
		{
			BaseAddress = new Uri(options.BaseAddress!)
		};

		Approval = RestService.For<IApproval>(_httpClient);
		BusinessObject = RestService.For<IBusinessObject>(_httpClient);
		Core = RestService.For<ICore>(_httpClient);
		Forms = RestService.For<IForms>(_httpClient);
		Lifecycle = RestService.For<ILifecycle>(_httpClient);
		OneStepActions = RestService.For<IOneStepActions>(_httpClient);
		Queues = RestService.For<IQueues>(_httpClient);
		Searches = RestService.For<ISearches>(_httpClient);
		Security = RestService.For<ISecurity>(_httpClient);
		Service = RestService.For<IService>(_httpClient);
		Teams = RestService.For<ITeams>(_httpClient);
		Users = RestService.For<IUsers>(_httpClient);
	}

	/// <inheritdoc />
	public IApproval Approval { get; }

	/// <inheritdoc />
	public IBusinessObject BusinessObject { get; }

	/// <inheritdoc />
	public ICore Core { get; }

	/// <inheritdoc />
	public IForms Forms { get; }

	/// <inheritdoc />
	public ILifecycle Lifecycle { get; }

	/// <inheritdoc />
	public IOneStepActions OneStepActions { get; }

	/// <inheritdoc />
	public IQueues Queues { get; }

	/// <inheritdoc />
	public ISearches Searches { get; }

	/// <inheritdoc />
	public ISecurity Security { get; }

	/// <inheritdoc />
	public IService Service { get; }

	/// <inheritdoc />
	public ITeams Teams { get; }

	/// <inheritdoc />
	public IUsers Users { get; }

	#region Dispose

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			/// _logger.LogTrace("{Message}", Resources.Disposing);
			_httpClient.Dispose();
			/// _logger.LogTrace("{Message}", Resources.Disposed);
		}
	}

	public void Dispose()
	{
		Dispose(true);

		GC.SuppressFinalize(this);
	}

	#endregion
}
