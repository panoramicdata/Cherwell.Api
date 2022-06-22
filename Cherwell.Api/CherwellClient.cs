using Refit;

namespace Cherwell.Api
{
	/// <summary>
	/// API client is mainly responsible for making the HTTP call to the API backend.
	/// </summary>
	public partial class CherwellClient
	{
		private CherwellClient(HttpClient client)
		{
			ApprovalApiClient = RestService.For<IApprovalApi>(client);
			BusinessObjectApiClient = RestService.For<IBusinessObjectApi>(client);
			CoreApiClient = RestService.For<ICoreApi>(client);
			FormsApiClient = RestService.For<IFormsApi>(client);
			LifecycleApiClient = RestService.For<ILifecycleApi>(client);
			OneStepActionsApiClient = RestService.For<IOneStepActionsApi>(client);
			QueuesApiClient = RestService.For<IQueuesApi>(client);
			SearchesApiClient = RestService.For<ISearchesApi>(client);
			SecurityApiClient = RestService.For<ISecurityApi>(client);
			ServiceApiClient = RestService.For<IServiceApi>(client);
			TeamsApiClient = RestService.For<ITeamsApi>(client);
			UsersApiClient = RestService.For<IUsersApi>(client);
		}

		/// <param name="options">The options used to configure the behaviour of the client</param>
		public CherwellClient(CherwellClientOptions options) : this(new HttpClient(new AuthenticatedHttpClientHandler(options))
		{
			BaseAddress = new Uri(options.BaseAddress)
		})
		{
		}

		/// <inheritdoc />
		public IApprovalApi ApprovalApiClient { get; }

		/// <inheritdoc />
		public IBusinessObjectApi BusinessObjectApiClient { get; }

		/// <inheritdoc />
		public ICoreApi CoreApiClient { get; }

		/// <inheritdoc />
		public IFormsApi FormsApiClient { get; }

		/// <inheritdoc />
		public ILifecycleApi LifecycleApiClient { get; }

		/// <inheritdoc />
		public IOneStepActionsApi OneStepActionsApiClient { get; }

		/// <inheritdoc />
		public IQueuesApi QueuesApiClient { get; }

		/// <inheritdoc />
		public ISearchesApi SearchesApiClient { get; }

		/// <inheritdoc />
		public ISecurityApi SecurityApiClient { get; }

		/// <inheritdoc />
		public IServiceApi ServiceApiClient { get; }

		/// <inheritdoc />
		public ITeamsApi TeamsApiClient { get; }

		/// <inheritdoc />
		public IUsersApi UsersApiClient { get; }


		public string? Scheme { get; }

		public string? Token { get; }

		private Task<Tuple<string, string>> GetSchemeAndToken()
		{
			return Task.FromResult(new Tuple<string, string>(Scheme, Token));
		}
	}
}
