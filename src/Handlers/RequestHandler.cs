using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public static void RequestHandler(HttpContext httpContent)
        {
            try
            {
                // ----------- PROCESS HEADERS AND CHECKS ------------

                // Enforce https if enabled in config

                WebApp_Funcs.HttpsEnforce(httpContent);

                // Http headers check - Access-Control-Allow-Origin, etc...

                WebApp_Funcs.HttpHeadersCheck(httpContent);

                // ----------- PROCESS REQUEST ------------


                var pathLookup = CodeLogic_Funcs.SplitUrlString(CodeLogic_Funcs.GetPath(httpContent), 1);

                // Installation check

                if(pathLookup == "install")
                {
                    httpContent.Response.WriteAsync("Ran installation process");
                    InstallHandler(httpContent);
                }

                // Administration page

                else if (pathLookup == "administration")
                {
                    httpContent.Response.WriteAsync("Administration page");

                    // Administration page here...
                }

                // Send request to Router
                else
                {
                    WebApp_Funcs.Routing(httpContent);
                }



            }
            catch (Exception ex)
            {
                httpContent.Response.WriteAsync(ex.ToString());
            }
        }
    }
}