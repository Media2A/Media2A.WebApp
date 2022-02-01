using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using CodeLogic;
using CL.MySQL;
using System.Data;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void PageGenerator(HttpContext httpContent, string routeParm)
        {

            // Get page data

            var pageModel = new WebApp_DatabaseModels.WebApp_CMS_Pages();
            var pageData = CL.MySQL.MySql_Queries.DataModel.GetDataByModelByID(pageModel.ReturnTable(), pageModel.page_id, routeParm);
            
            // Variables from data

            pageModel.page_title = MySql_Tools.GetRecordValue(pageData, pageModel.page_title);
            pageModel.page_description = MySql_Tools.GetRecordValue(pageData, pageModel.page_description);
            pageModel.page_content = MySql_Tools.GetRecordValue(pageData, pageModel.page_content);
            pageModel.menu_id = MySql_Tools.GetRecordValue(pageData, pageModel.menu_id);
            pageModel.theme_id = MySql_Tools.GetRecordValue(pageData, pageModel.theme_id);


            var themeTemplate = WebApp_Funcs.Cms.GetTemplateByID($"{pageModel.theme_id}_{WebApp_AppModels.Cms.TemplateTypes.THEME.ToString()}");
 
            // Do page work

            var pageOutput = themeTemplate;

            pageOutput = WebApp_Funcs.Cms.DefaultTemplateProcessing(pageOutput, httpContent);

            // ------------   Do initial work

            // [tags]

            // Title
            pageOutput = CodeLogic_Funcs.SimpleReplaceTag(pageOutput, WebApp_AppModels.Cms.PageElements.PAGE_TITLE.ToString(), pageModel.page_title);

            // Generate menu

            // var menuContent = GenerateMenuByID(pageModel.menu_id);
            httpContent.Response.WriteAsync(pageOutput);
        }
    }
}
