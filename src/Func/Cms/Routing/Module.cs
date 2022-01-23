using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using CodeLogic;
using CL.MySQL;
using Media2A.WebApp;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void Module(HttpContext httpContent)
        {

            var redirectId = CodeLogic_Funcs.SplitUrlString(CodeLogic_Funcs.GetPath(httpContent),2);
            var redirectDataModel = new WebApp_DatabaseModels.WebApp_CMS_Redirect();
            var redirectData = MySql_Queries.GetDataByModelByID(redirectDataModel.ReturnTable(), redirectDataModel.redirect_id, redirectId);


            httpContent.Response.Redirect(redirectData.GetValueOrDefault(redirectDataModel.redirect_url, true).ToString());
            httpContent.Response.StartAsync(); // Force start of response



        }
    }
}
