using System.Net.Http;

namespace Illallangi.TheTvDb.Authenticated
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