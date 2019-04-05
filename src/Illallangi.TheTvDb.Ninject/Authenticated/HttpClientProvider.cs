using System;
using Illallangi.TheTvDb.Settings;
using Ninject.Activation;

namespace Illallangi.TheTvDb.Authenticated
{
    public sealed class HttpClientProvider : Provider<HttpClient>
    {
        private readonly JsonSetting setting;
        private readonly ClientHandler clientHandler;

        public HttpClientProvider(
            JsonSetting setting,
            ClientHandler clientHandler)
        {
            this.setting = setting ?? throw new ArgumentNullException(nameof(setting));
            this.clientHandler = clientHandler ?? throw new ArgumentNullException(nameof(clientHandler));
        }

        protected override HttpClient CreateInstance(
            IContext cx)
        {
            return new HttpClient(clientHandler)
            {
                BaseAddress = new Uri(setting.BaseUrl)
            };
        }
    }
}