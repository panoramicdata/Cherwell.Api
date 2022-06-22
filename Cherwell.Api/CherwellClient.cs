using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Refit;

namespace Cherwell.Api
{
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

			_httpClient = new HttpClient(new AuthenticatedHttpClientHandler(options, _logger))
			{
				BaseAddress = new Uri(options.BaseAddress!)
			};

			Approval = RestService.For<IApprovalApi>(_httpClient);
			BusinessObject = RestService.For<IBusinessObjectApi>(_httpClient);
			Core = RestService.For<ICoreApi>(_httpClient);
			Forms = RestService.For<IFormsApi>(_httpClient);
			Lifecycle = RestService.For<ILifecycleApi>(_httpClient);
			OneStepActions = RestService.For<IOneStepActionsApi>(_httpClient);
			Queues = RestService.For<IQueuesApi>(_httpClient);
			Searches = RestService.For<ISearchesApi>(_httpClient);
			Security = RestService.For<ISecurityApi>(_httpClient);
			Service = RestService.For<IServiceApi>(_httpClient);
			Teams = RestService.For<ITeamsApi>(_httpClient);
			Users = RestService.For<IUsersApi>(_httpClient);
		}

		/// <inheritdoc />
		public IApprovalApi Approval { get; }

		/// <inheritdoc />
		public IBusinessObjectApi BusinessObject { get; }

		/// <inheritdoc />
		public ICoreApi Core { get; }

		/// <inheritdoc />
		public IFormsApi Forms { get; }

		/// <inheritdoc />
		public ILifecycleApi Lifecycle { get; }

		/// <inheritdoc />
		public IOneStepActionsApi OneStepActions { get; }

		/// <inheritdoc />
		public IQueuesApi Queues { get; }

		/// <inheritdoc />
		public ISearchesApi Searches { get; }

		/// <inheritdoc />
		public ISecurityApi Security { get; }

		/// <inheritdoc />
		public IServiceApi Service { get; }

		/// <inheritdoc />
		public ITeamsApi Teams { get; }

		/// <inheritdoc />
		public IUsersApi Users { get; }

		#region Dispose

		private bool _disposedValue;

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposedValue)
			{
				if (disposing)
				{
					/// _logger.LogTrace("{Message}", Resources.Disposing);
					_httpClient.Dispose();
					/// _logger.LogTrace("{Message}", Resources.Disposed);
				}
			}
		}

		public void Dispose()
		{
			Dispose(true);

			GC.SuppressFinalize(this);
		}

		#endregion
	}
}
