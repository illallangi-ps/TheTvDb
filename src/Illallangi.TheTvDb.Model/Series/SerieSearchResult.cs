using System.Collections.Generic;
using Newtonsoft.Json;

namespace Illallangi.TheTvDb.Series
{
    public class SerieSearchResult
    {
        [JsonProperty(@"id")]
        public int Id { get; set; }

        [JsonProperty(@"seriesName")]
        public string SeriesName { get; set; }
    }
}
