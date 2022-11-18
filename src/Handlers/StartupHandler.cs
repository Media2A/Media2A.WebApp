using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public static void StartupHandler(HttpContext httpContent)
        {
            WebApp_Funcs.Configuration();
            CodeLogic_Framework.CacheConfigFiles();

        }
    }
}