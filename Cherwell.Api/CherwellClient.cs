using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Refit;

namespace Cherwell.Api
{
	/// <summary>
	/// API client is mainly responsible for making the HTTP call to the API backend.
	/// </summary>
	public partial class CherwellClient
	{
		private readonly ILogger _logger;

		private CherwellClient(HttpClient client, ILogger? logger)
		{
			_logger = logger ?? NullLogger.Instance;

			Approval = RestService.For<IApprovalApi>(client);
			BusinessObject = RestService.For<IBusinessObjectApi>(client);
			Core = RestService.For<ICoreApi>(client);
			Forms = RestService.For<IFormsApi>(client);
			Lifecycle = RestService.For<ILifecycleApi>(client);
			OneStepActions = RestService.For<IOneStepActionsApi>(client);
			Queues = RestService.For<IQueuesApi>(client);
			Searches = RestService.For<ISearchesApi>(client);
			Security = RestService.For<ISecurityApi>(client);
			Service = RestService.For<IServiceApi>(client);
			Teams = RestService.For<ITeamsApi>(client);
			Users = RestService.For<IUsersApi>(client);
		}

		/// <param name="options">The options used to configure the behaviour of the client</param>
		public CherwellClient(CherwellClientOptions options, ILogger? logger = null) : this(new HttpClient(new AuthenticatedHttpClientHandler(options))
		{
			BaseAddress = new Uri(options.BaseAddress)
		}, logger)
		{
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


		public string? Scheme { get; }

		public string? Token { get; }

		private Task<Tuple<string, string>> GetSchemeAndToken()
		{
			return Task.FromResult(new Tuple<string, string>(Scheme, Token));
		}

		private bool _disposedValue;

		//protected virtual void Dispose(bool disposing, HttpClient client)
		//{
		//	if (!_disposedValue)
		//	{
		//		if (disposing)
		//		{
		//			/// _logger.LogTrace("{Message}", Resources.Disposing);
		//			client.Dispose();

		//		}
		//	}
		//}
	}
}
