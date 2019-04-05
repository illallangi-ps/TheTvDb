using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Illallangi.TheTvDb.Tokens;

namespace Illallangi.TheTvDb.Authenticated
{
    public sealed class ClientHandler : DelegatingHandler
    {
        private readonly IToken token;
        
        public ClientHandler(
            HttpMessageHandler innerHandler,
            IToken token) :
            base(innerHandler)
        {
            this.token = token ?? throw new ArgumentNullException(nameof(token));
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            // See if the request has an authorize header
            var auth = request.Headers.Authorization;
            if (auth != null)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue(auth.Scheme, token.Token);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}