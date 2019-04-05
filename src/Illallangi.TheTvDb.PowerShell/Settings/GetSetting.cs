using System.Management.Automation;

namespace Illallangi.TheTvDb.Settings
{
    [Cmdlet(VerbsCommon.Get, "TheTvDbSetting")]
    public class GetSetting : TheTvDbGetCmdlet<ISetting>
    {
    }
}
