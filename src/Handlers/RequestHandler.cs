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
            // Get configuration from Files


            // Get configuration from database in put in Array/Lib
            // Get values from config

            try
            {

                // Http headers check - Access-Control-Allow-Origin, etc...

                WebApp_Funcs.HttpHeadersCheck(httpContent);

                // Enforce https if enabled in config

                WebApp_Funcs.HttpsEnforce(httpContent);

                // TESTING STUFF

                var test = MySql_Queries.GetDataByModelByID(WebApp_DatabaseModels.WebApp_CMS_Pages(), "123");
                foreach (var item in test)
                {
                    // httpContent.Response.WriteAsync("Key: " + item.Key + " /// Value: " + Convert.ToString(item.Value));
                    // httpContent.Response.WriteAsync(Environment.NewLine);
                }

                
            }
            catch (Exception ex)
            {
                
            }



        }
    }
}
