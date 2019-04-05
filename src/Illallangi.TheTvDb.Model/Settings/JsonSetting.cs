using System;
using System.IO;
using Newtonsoft.Json;

namespace Illallangi.TheTvDb.Settings
{
    public sealed class JsonSetting : Observable, ISetting
    {
        private const string defaultBaseUrl = @"https://api.thetvdb.com/";
        private const string path = @"%localappdata%\Illallangi Enterprises\TheTvDb\setting.json";

        private string apiKey;
        private string baseUrl;
        private string userKey;
        private string userName;
        
        public static JsonSetting Retrieve()
        {
            return File.Exists(Environment.ExpandEnvironmentVariables(path))
                ? JsonConvert.DeserializeObject<JsonSetting>(
                    File.ReadAllText(Environment.ExpandEnvironmentVariables(path)))
                : new JsonSetting {BaseUrl = defaultBaseUrl};
        }

        private JsonSetting()
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
        
        [JsonProperty(@"baseUrl")]
        public string BaseUrl
        {
            get => baseUrl;
            set => SetField(ref baseUrl, value);
        }

        [JsonProperty(@"apikey")]
        public string ApiKey
        {
            get => apiKey;
            set => SetField(ref apiKey, value);
        }

        [JsonProperty(@"userkey")]
        public string UserKey
        {
            get => userKey;
            set => SetField(ref userKey, value);
        }

        [JsonProperty(@"username")]
        public string UserName
        {
            get => userName;
            set => SetField(ref userName, value);
        }
    }
}