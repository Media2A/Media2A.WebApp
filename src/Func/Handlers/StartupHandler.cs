using Microsoft.AspNetCore.Http;
using CodeLogic;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public static void StartupHandler(HttpContext httpContent)
        {
            // Check default config files and generate them if none is found.
            try
            {
                WebApp_Funcs.Configuration();
                CodeLogic_Framework.CacheConfigFiles();
            }
            catch (Exception ex)
            {
                httpContent.Response.WriteAsync(ex.Message);
            }

            // Load config files

            

        }

    }
}
