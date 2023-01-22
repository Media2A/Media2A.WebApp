using CL.MySQL;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public static void ExtensionHandler(string moduleName, HttpContext httpContent)
        {
            //var WebApp_CMS_Pages = new WebApp_DatabaseModels.WebApp_CMS_Pages().ReturnTable();
            //var WebApp_CMS_Routing = new WebApp_DatabaseModels.WebApp_CMS_Routing().ReturnTable();
            //var WebApp_CMS_Redirect = new WebApp_DatabaseModels.WebApp_CMS_Redirect().ReturnTable();

            //MySql_Queries.DataModel.create(WebApp_CMS_Pages);
            //MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_CMS_Routing);
            //MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_CMS_Redirect);
        }
    }
}