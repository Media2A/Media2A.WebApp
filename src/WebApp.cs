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
                CodeLogic_Framework.ValidateConfigFile("database.json", Database_Object.GenerateModel());
                CodeLogic_Framework.ValidateConfigFile("webapp.json", WebApp_Object.GenerateModel());
            }
            catch (Exception ex)
            {
                httpContent.Response.WriteAsync(ex.Message);
            }

            // Load config files

            CodeLogic_Framework.CacheConfigFiles();

        }
        public async static void RequestHandler(HttpContext httpContent)
        {
            // Get values from config
            try
            {
                ConfigModels.WebApp webApp = new ConfigModels.WebApp();

                var SiteProxyEnabled = CodeLogic_Framework.GetConfigValueBool("webapp.json", "SiteProxyEnabled");

                var SessionTimeout = CodeLogic_Framework.GetConfigValueInt("webapp.json", "SessionTimeout");

                

                // Put debug info in html tag
                var outputBegin = "<!-- " + Environment.NewLine;
                var outputContent = "WebApp Debugging:" + Environment.NewLine;
                outputContent = outputContent + "SiteProxyEnabled: " + SiteProxyEnabled.ToString() + Environment.NewLine;
                outputContent = outputContent + "SessionTimeout: " + SessionTimeout.ToString() + Environment.NewLine;
                var outputEnd = "-->";

                await httpContent.Response.WriteAsync(outputBegin + outputContent + outputEnd);
            }
            catch (Exception ex)
            {
                httpContent.Response.WriteAsync(ex.ToString());
            }


        }

    }
}