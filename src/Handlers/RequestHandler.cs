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

                // Http headers check - Access-Control-Allow-Origin, etc...

                WebApp_Funcs.HttpHeadersCheck(httpContent);

                // Enforce https if enabled in config

                WebApp_Funcs.HttpsEnforce(httpContent);

                // ----------- PROCESS REQUEST ------------




            }
            catch (Exception ex)
            {
                
            }



        }
    }
}
