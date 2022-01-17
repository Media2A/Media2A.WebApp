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

                //var test = MySql_Queries.GetDataByModelByID(new WebApp_DatabaseModels.WebApp_CMS_Pages().GetTable(), new WebApp_DatabaseModels.WebApp_CMS_Pages().GetColumns(), "123");
                //foreach (var item in test)
                //{
                //    var itemValue = item.Value;
                //    Type actualType = itemValue.GetType();
                //    httpContent.Response.WriteAsync("Key: " + item.Key + " /// Type: " + actualType + " /// Value: " + itemValue);
                //    httpContent.Response.WriteAsync(Environment.NewLine);
                //}
                //MySql_Tools.GetRecordValue(test, "");



            }
            catch (Exception ex)
            {
                
            }



        }
    }
}
