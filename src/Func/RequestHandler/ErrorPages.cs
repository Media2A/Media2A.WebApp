using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using CodeLogic;
using CL.MySQL;
using System.Data;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void ErrorPage(HttpContext httpContent, int errorCode)
        {

            // Get page data

            var themeTemplate = WebApp_Funcs.Cms.GetTemplateByID($"DEFAULT_{WebApp_AppModels.Cms.TemplateTypes.ERROR.ToString()}");

            // Do page work

            var pageOutput = themeTemplate;

            // ------------   Do initial work

            // [tags]

            // Title
            pageOutput = CodeLogic_Funcs.SimpleReplaceTag(pageOutput, WebApp_AppModels.Cms.PageElements.PAGE_TITLE.ToString(), "Page not found");

            // Generate menu

            // var menuContent = GenerateMenuByID(pageModel.menu_id);
            httpContent.Response.WriteAsync(pageOutput);
        }
    }
}
