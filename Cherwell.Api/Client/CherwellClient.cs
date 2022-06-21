using System.Net.Http.Headers;
using Cherwell.Api;
using Refit;

namespace Cherwell.Client
{
	/// <summary>
	/// API client is mainly responsible for making the HTTP call to the API backend.
	/// </summary>
	public partial class CherwellClient
    {
        public CherwellClient(HttpClient client)
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

        /// <param name="getSchemeAndToken"></param>
        public CherwellClient(string url, Func<Task<Tuple<string, string>>> getSchemeAndToken) : this(new HttpClient(new AuthenticatedHttpClientHandler(getSchemeAndToken))
            {
            BaseAddress = new Uri(url)
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

    public class AuthenticatedHttpClientHandler : HttpClientHandler
    {
        private readonly Func<Task<Tuple<string, string>>> getSchemeAndToken;

        public AuthenticatedHttpClientHandler(Func<Task<Tuple<string, string>>> getSchemeAndToken)
        {
            this.getSchemeAndToken = getSchemeAndToken;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            // See if the request has an authorize header
            var auth = request.Headers.Authorization;
            var schemeAndToken = await getSchemeAndToken().ConfigureAwait(false);

            if (schemeAndToken != null)
            {
            request.Headers.Authorization = new AuthenticationHeaderValue(schemeAndToken.Item1, schemeAndToken.Item2);
            }


            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
