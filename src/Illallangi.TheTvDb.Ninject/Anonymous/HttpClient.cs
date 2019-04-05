using System.Net.Http;

namespace Illallangi.TheTvDb.Anonymous
{
    public sealed class HttpClient : System.Net.Http.HttpClient
    {
        public HttpClient() : base()
        {
        }

        public HttpClient(HttpMessageHandler handler) : base(handler)
        {
        }
    }
}
