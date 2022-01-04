using CodeLogic;
using Media2A.WebApp.ConfigModels;

using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
     public static partial class Handlers
    {

        public static void StartupHandler(HttpContext httpContent)
        {
            // Check default config files and generate them if none is found.
            try
            {
                Framework.ValidateConfigFile("database.json", Database_Object.DO());
                Framework.ValidateConfigFile("webapp.json", WebApp_Object.DO());
            }
            catch (Exception ex)
            {
                httpContent.Response.WriteAsync(ex.Message);
            }
            Framework.ValidateConfigFile("database.json", Database_Object.DO());
            Framework.ValidateConfigFile("webapp.json", WebApp_Object.DO());

            // Load config files

            Framework.CacheConfigFiles();

        }
        public async static void RequestHandler(HttpContext httpContent)
        {
            // Get values from config
            try
            {
                ConfigModels.WebApp webApp = new ConfigModels.WebApp();

                bool responseFromHandler = Framework.GetConfigValueBool("webapp.json", "SiteProxyEnabled");

                await httpContent.Response.WriteAsync(responseFromHandler.ToString());
            }
            catch (Exception ex)
            {
                httpContent.Response.WriteAsync(ex.ToString());
            }


        }

    }
}