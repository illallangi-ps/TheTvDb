using System;
using Illallangi.TheTvDb.Settings;
using Ninject.Activation;

namespace Illallangi.TheTvDb.Anonymous
{
    public sealed class HttpClientProvider : Provider<HttpClient>
    {
        private readonly JsonSetting setting;
        
        public HttpClientProvider(
            JsonSetting setting)
        {
            this.setting = setting ?? throw new ArgumentNullException(nameof(setting));
            
        }

        protected override HttpClient CreateInstance(
            IContext cx)
        {
            return new HttpClient()
            {
                BaseAddress = new Uri(setting.BaseUrl)
            };
        }
    }
}