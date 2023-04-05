using System.Configuration;

namespace LumaAutomatedWebTestingProject
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string Username = ConfigurationManager.AppSettings["valid_username"];
        public static readonly string Password = ConfigurationManager.AppSettings["valid_password"];
    }
}
