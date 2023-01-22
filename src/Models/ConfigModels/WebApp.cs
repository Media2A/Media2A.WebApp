namespace Media2A.WebApp.ConfigModels
{
    public class WebApp
    {
        public bool SiteProxyEnabled;
        public bool SiteEnforceHttps;
        public int DebugLevel;
        public int SessionTimeout;
        public string CrossOriginDomains;
        public string StaticContentUrl;
    }

    public class WebApp_Object
    {
        public static object GenerateModel()
        {
            var DataObject = new WebApp();
            DataObject.SiteProxyEnabled = false;
            DataObject.DebugLevel = 1;
            DataObject.SessionTimeout = 3600;
            DataObject.CrossOriginDomains = "*";
            DataObject.StaticContentUrl = "";

            return DataObject;
        }
    }
}