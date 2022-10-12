using CL.MySQL;
using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void Redirect(HttpContext httpContent)
        {
            var redirectId = CodeLogic_Funcs.SplitUrlString(CodeLogic_Funcs.GetPath(httpContent), 2);
            var redirectDataModel = new WebApp_DatabaseModels.WebApp_CMS_Redirect();
            var redirectData = MySql_Queries.DataModel.GetDataByModelByID(redirectDataModel.ReturnTable(), redirectDataModel.redirect_id, redirectId);

            httpContent.Response.Redirect(redirectData.GetValueOrDefault(redirectDataModel.redirect_url, true).ToString());
            httpContent.Response.StartAsync(); // Force start of response
        }
    }
}