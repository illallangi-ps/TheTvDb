using Ninject.Activation;
using Refit;

namespace Illallangi.TheTvDb.Anonymous
{
    public sealed class RestServiceProvider<T> : Provider<T>
    {
        public HttpClient HttpClient { get; }

        public RestServiceProvider(
            HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected override T CreateInstance(
            IContext context)
        {
            return RestService.For<T>(this.HttpClient);
        }
    }
}