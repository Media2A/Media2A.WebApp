using CodeLogic;
using Microsoft.AspNetCore.Http;

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

            // Process template

            foreach (var item in collection)
            {

            }

            // [tags]

            // Title
            pageOutput = CodeLogic_Funcs.SimpleReplaceTag(pageOutput, WebApp_AppModels.Cms.PageElements_Base.PAGE_TITLE.ToString(), "Page not found");

            // Generate menu

            // var menuContent = GenerateMenuByID(pageModel.menu_id);
            httpContent.Response.WriteAsync(pageOutput);
        }
    }
}