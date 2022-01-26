using Microsoft.AspNetCore.Http;
using CodeLogic;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public static void StartupHandler(HttpContext httpContent)
        {
            WebApp_Funcs.Configuration();
            CodeLogic_Framework.CacheConfigFiles();

            // Load config files

            InstallHandler(httpContent);

        }

    }
}
