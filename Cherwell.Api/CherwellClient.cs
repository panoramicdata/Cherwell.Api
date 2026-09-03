using Cherwell.Api.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Refit;

namespace Cherwell.Api;

/// <summary>
/// API client is mainly responsible for making the HTTP call to the API backend.
/// </summary>
public class CherwellClient : IDisposable
{
	private readonly HttpClient _httpClient;

	/// <summary>
	/// Create an instance of the client for accessing the Cherwell API
	/// </summary>
	/// <param name="options">The options to be used when accessing the API</param>
	public CherwellClient(CherwellClientOptions options)
		: this(options, null)
	{
	}

	/// <summary>
	/// Create an instance of the client for accessing the Cherwell API.
	/// </summary>
	/// <param name="options">The options to be used when accessing the API.</param>
	/// <param name="logger">Logger to which to output details of the operations performed.</param>
	public CherwellClient(CherwellClientOptions options, ILogger? logger)
	{
		ArgumentNullException.ThrowIfNull(options);
		var effectiveLogger = logger ?? NullLogger.Instance;

		// Validate that all of the necessary configuration has been provided
		options.Validate();

		_httpClient = new HttpClient(new AuthenticatedHttpClientHandler(options, effectiveLogger))
		{
			BaseAddress = new Uri(options.BaseAddress!),
			Timeout = TimeSpan.FromSeconds(options.TimeoutSeconds)
		};

		var refitSettings = new RefitSettings
		{
			Buffered = true,
			ContentSerializer = new SystemTextJsonContentSerializer(
				CherwellJson.CreateSerializerOptions())
		};

		Approval = RestService.For<IApproval>(_httpClient, refitSettings);
		BusinessObject = RestService.For<IBusinessObject>(_httpClient, refitSettings);
		Core = RestService.For<ICore>(_httpClient, refitSettings);
		Forms = RestService.For<IForms>(_httpClient, refitSettings);
		Lifecycle = RestService.For<ILifecycle>(_httpClient, refitSettings);
		OneStepActions = RestService.For<IOneStepActions>(_httpClient, refitSettings);
		Queues = RestService.For<IQueues>(_httpClient, refitSettings);
		Searches = RestService.For<ISearches>(_httpClient, refitSettings);
		Security = RestService.For<ISecurity>(_httpClient, refitSettings);
		Service = RestService.For<IService>(_httpClient, refitSettings);
		Teams = RestService.For<ITeams>(_httpClient, refitSettings);
		Users = RestService.For<IUsers>(_httpClient, refitSettings);
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
			_httpClient.Dispose();
		}
	}

	public void Dispose()
	{
		Dispose(true);

		GC.SuppressFinalize(this);
	}

	#endregion
}
