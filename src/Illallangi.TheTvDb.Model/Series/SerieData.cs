using Newtonsoft.Json;

namespace Illallangi.TheTvDb.Series
{
    public sealed class SerieData
    {
        [JsonProperty(@"data")]
        public Serie Data { get; set; }
    }
}
