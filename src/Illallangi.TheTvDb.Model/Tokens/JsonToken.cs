using System;
using System.IO;
using Newtonsoft.Json;

namespace Illallangi.TheTvDb.Tokens
{
    public sealed class JsonToken : Observable, IToken
    {
        private const string path = @"%localappdata%\Illallangi Enterprises\TheTvDb\token.json";

        private string token;
        private DateTime expiry;
        private DateTime refresh;

        public static JsonToken Retrieve()
        {
            return File.Exists(Environment.ExpandEnvironmentVariables(path))
                ? JsonConvert.DeserializeObject<JsonToken>(
                    File.ReadAllText(Environment.ExpandEnvironmentVariables(path)))
                : new JsonToken();
        }

        private JsonToken()
        {
            PropertyChanged += (sender, args) =>
            {
                if (!Directory.Exists(Path.GetDirectoryName(Environment.ExpandEnvironmentVariables(path))))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Environment.ExpandEnvironmentVariables(path)));
                }

                File.WriteAllText(Environment.ExpandEnvironmentVariables(path), JsonConvert.SerializeObject(sender, Formatting.Indented));
            };
        }

        [JsonProperty(@"token")]
        public string Token
        {
            get => token;
            set => SetField(ref token, value);
        }

        [JsonProperty(@"expiry")]
        public DateTime Expiry
        {
            get => expiry;
            set => SetField(ref expiry, value);
        }

        [JsonProperty(@"refresh")]
        public DateTime Refresh
        {
            get => refresh;
            set => SetField(ref refresh, value);
        }
    }
}