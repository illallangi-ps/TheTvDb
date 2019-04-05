using Microsoft.Win32;

namespace Illallangi.TheTvDb.Settings
{
    public sealed class Setting
    {
        private const string KeyName = @"Software\Illallangi Enterprises\TheTvDb Client";

        private const string DefaultBaseUrl = @"https://api.thetvdb.com";

        private const string DefaultUserName = @"illallangi";
        private const string DefaultUserKey = @"6CF491BF3950974F";
        private const string DefaultApiKey = @"53720587389ADB53";

        public string BaseUrl
        {
            get => this.BaseUrl = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.BaseUrl), DefaultBaseUrl);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.BaseUrl), value);
        }

        public string UserName
        {
            get => this.UserName = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.UserName), DefaultUserName);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.UserName), value);
        }

        public string UserKey
        {
            get => this.UserKey = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.UserKey), DefaultUserKey);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.UserKey), value);
        }

        public string ApiKey
        {
            get => this.ApiKey = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.ApiKey), DefaultApiKey);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.ApiKey), value);
        }

        public string Token
        {
            get => this.Token = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.Token));
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.Token), value);
        }
    }
}
