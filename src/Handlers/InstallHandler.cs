using CL.MySQL;
using System.Reflection;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public static void InstallHandler(HttpContext httpContent)
        {
            //WebApp_DatabaseModels.WebApp_CMS_Pages webApp_CMS_Pages = new WebApp_DatabaseModels.WebApp_CMS_Pages();
            //httpContent.Response.WriteAsync( MySql_Queries.CreateTableFromModel(webApp_CMS_Pages));

            var outdd = new WebApp_DatabaseModels.WebApp_CMS_Pages().ReturnTable();



            httpContent.Response.WriteAsync(MySql_Queries.CreateNewTableFromModel(outdd));

        }
    }
}