using System.Management.Automation;

namespace Illallangi.TheTvDb.Settings
{
    [Cmdlet(VerbsCommon.Set, "TheTvDbSetting")]
    public sealed class SetSetting : TheTvDbSetCmdlet<JsonSetting, ISetting>
    {
        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string ApiKey
        {
            get => this.GetObject().ApiKey;
            set => this.GetObject().ApiKey = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string BaseUrl
        {
            get => this.GetObject().BaseUrl;
            set => this.GetObject().BaseUrl = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string UserKey
        {
            get => this.GetObject().UserKey;
            set => this.GetObject().UserKey = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string UserName
        {
            get => this.GetObject().UserName;
            set => this.GetObject().UserName = value;
        }
    }
}
