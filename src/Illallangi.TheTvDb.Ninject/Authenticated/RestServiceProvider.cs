using Ninject.Activation;
using Refit;

namespace Illallangi.TheTvDb.Authenticated
{
    public sealed class RestServiceProvider<T> : Provider<T>
    {
        public HttpClient HttpClient { get; }

        public RestServiceProvider(
            HttpClient httpClient)
        {
            this.HttpClient = httpClient;
        }

        protected override T CreateInstance(
            IContext context)
        {
            return RestService.For<T>(this.HttpClient);
        }
    }
}