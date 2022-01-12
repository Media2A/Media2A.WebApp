using Microsoft.AspNetCore.Http;
using CodeLogic;
using CL.MySQL;
using System.Data;
using Microsoft.AspNetCore.Http.Extensions;

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

                WebApp_Funcs.HttpsEnforce(httpContent);


                var MysqltestQuery = MySql_Queries.GetResultByQuery("WebApp_CMS_Templates", "template_content", "");

                foreach (DataRow dataRow in MysqltestQuery.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        await httpContent.Response.WriteAsync(item.ToString());
                    }
                }
                await httpContent.Response.WriteAsync("url:" + httpContent.Request.GetEncodedUrl());

                
            }
            catch (Exception ex)
            {
                httpContent.Response.WriteAsync(ex.ToString());
            }



        }
    }
}
