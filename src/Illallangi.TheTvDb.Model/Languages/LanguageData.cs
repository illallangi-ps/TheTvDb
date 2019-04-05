using System.Collections.Generic;
using Newtonsoft.Json;

namespace Illallangi.TheTvDb.Languages
{
    public class LanguageData
    {
        [JsonProperty(@"data")]
        public List<Language> Data { get; set; }
    }
}
