using System.Net.Http.Headers;

namespace Cherwell.Api
{
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
