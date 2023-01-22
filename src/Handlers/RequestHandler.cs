using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public static async Task RequestHandler(HttpContext httpContent)
        {

            await Task.Run(() =>
            {
                // ----------- PROCESS HEADERS AND CHECKS ------------

                // Enforce https if enabled in config

                WebApp_Funcs.HttpsEnforce(httpContent);

                // Http headers check - Access-Control-Allow-Origin, etc...

                WebApp_Funcs.HttpHeadersCheck(httpContent);

                // Run Security checks

                WebApp_Funcs.HttpSecurityCheck(httpContent);

                // ----------- PROCESS REQUEST ------------

                var pathLookup = CodeLogic_Funcs.SplitUrlString(CodeLogic_Funcs.GetPath(httpContent), 1);

                switch (pathLookup)
                {
                    case "install":
                        httpContent.Response.WriteAsync("Ran installation process");
                        InstallHandler(httpContent);
                        break;
                    case "administration":
                        httpContent.Response.WriteAsync("Administration page");
                        break;
                    case "webapp":
                        var pathLookupWebApp = CodeLogic_Funcs.SplitUrlString(CodeLogic_Funcs.GetPath(httpContent), 2);
                        if (pathLookupWebApp == "module")
                        {
                            var pathLookupModuleName = CodeLogic_Funcs.SplitUrlString(CodeLogic_Funcs.GetPath(httpContent), 3);
                            var pathLookupModuleParm = CodeLogic_Funcs.SplitUrlString(CodeLogic_Funcs.GetPath(httpContent), 4);

                            var moduleReturnCode = WebApp_Funcs.ProcessModule(pathLookupModuleName, pathLookupModuleParm);
                            httpContent.Response.WriteAsync(moduleReturnCode);
                        }
                        break;
                    default:
                        WebApp_Funcs.Routing(httpContent);
                        break;
                }
            });


        }
    }
}