using System;
using System.Net.Http;

using Ninject.Activation;

using Illallangi.TheTvDb.Tokens;

namespace Illallangi.TheTvDb.Authenticated
{
    public sealed class ClientHandlerProvider : Provider<ClientHandler>
    {
        private readonly HttpMessageHandler httpClientHandler;
        private readonly IToken token;
        
        public ClientHandlerProvider(
            HttpClientHandler httpClientHandler,
            IToken token)
        {
            this.httpClientHandler = httpClientHandler ?? throw new ArgumentNullException(nameof(httpClientHandler));
            this.token = token ?? throw new ArgumentException(nameof(token));
        }

        protected override ClientHandler CreateInstance(
            IContext cx)
        {
            return new ClientHandler(
                httpClientHandler,
                token);
        }
    }
}