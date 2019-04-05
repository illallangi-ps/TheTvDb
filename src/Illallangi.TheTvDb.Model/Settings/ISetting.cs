namespace Illallangi.TheTvDb.Settings
{
    public interface ISetting
    {
        string ApiKey { get; set; }
        string BaseUrl { get; set; }
        string UserKey { get; set; }
        string UserName { get; set; }
    }
}