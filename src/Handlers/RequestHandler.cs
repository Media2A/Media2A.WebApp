using Microsoft.AspNetCore.Http;
using CodeLogic;
using System.Data;
using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public async static void RequestHandler(HttpContext httpContent)
        {
            try
            {
                // ----------- PROCESS HEADERS AND ENFORCEMENT ------------

                // Http headers check - Access-Control-Allow-Origin, etc...

                WebApp_Funcs.HttpHeadersCheck(httpContent);

                // Enforce https if enabled in config

                WebApp_Funcs.HttpsEnforce(httpContent);

                // ----------- PROCESS REQUEST ------------
                
                // Lookup routing informations from database
                var routeInfo = WebApp_Funcs.Routing(httpContent);
                var routingDataModel = new WebApp_DatabaseModels.WebApp_CMS_Routing();

                routeInfo.GetValueOrDefault(routingDataModel.route_id);

                var pathLookup = CodeLogic_Funcs.SplitUrlString(CodeLogic_Funcs.GetPath(httpContent), 1);
                httpContent.Response.WriteAsync(pathLookup);

            }
            catch (Exception ex)
            {
                
            }



        }
    }
}
