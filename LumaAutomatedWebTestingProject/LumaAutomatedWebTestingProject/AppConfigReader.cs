using System.Configuration;

namespace LumaAutomatedWebTestingProject
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string Username = ConfigurationManager.AppSettings["Valid_Username"];
        public static readonly string Password = ConfigurationManager.AppSettings["Valid_Password"];
    }
}
