using Newtonsoft.Json;

namespace Illallangi.TheTvDb.Languages
{
    public class Language
    {
        [JsonProperty(@"id")]
        public int Id { get; set; }

        [JsonProperty(@"name")]
        public string Name { get; set; }

        [JsonProperty(@"abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty(@"englishName")]
        public string EnglishName { get; set; }
    }
}
