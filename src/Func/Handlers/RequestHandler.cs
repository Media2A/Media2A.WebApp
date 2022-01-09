using Microsoft.AspNetCore.Http;
using CodeLogic;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public async static void RequestHandler(HttpContext httpContent)
        {
            // Get configuration from Files


            // Get configuration from database in put in Array/Lib
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
