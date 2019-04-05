using System.Collections.Generic;
using Newtonsoft.Json;

namespace Illallangi.TheTvDb.Series
{
    public sealed class SerieSearchResults
    {
        [JsonProperty(@"data")]
        public List<SerieSearchResult> Data { get; set; }
    }
}
