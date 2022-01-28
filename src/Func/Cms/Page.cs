using System;
using CodeLogic;
using CL.MySQL.ConfigModels;
using CL.Smtp.ConfigModels;
using Media2A.WebApp.ConfigModels;
using CL.MySQL;
using Microsoft.AspNetCore.Http;


namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public partial class Cms
        {
            public static string GeneratePageByID(string pageID, HttpContext httpContent)
            {

                var pageOutput = "";

                // ----------   +Get page details from page id
                var pageModel = new WebApp_DatabaseModels.WebApp_CMS_Pages();

                var pageData = CL.MySQL.MySql_Queries.DataModel.GetDataByModelByID(pageModel.ReturnTable(), pageModel.page_id, pageID);

                pageModel.page_title = MySql_Tools.GetRecordValue(pageData, pageModel.page_title);
                pageModel.page_description = MySql_Tools.GetRecordValue(pageData, pageModel.page_description);
                pageModel.page_content = MySql_Tools.GetRecordValue(pageData, pageModel.page_content);
                pageModel.menu_id = MySql_Tools.GetRecordValue(pageData, pageModel.page_content);

                pageOutput = pageModel.page_content;

                // ------------   Do initial work

                // [tags]

                // Title
                pageOutput = CodeLogic_Funcs.SimpleReplaceTag(pageOutput, WebApp_AppModels.Cms.PageElements.PAGE_TITLE.ToString(), pageModel.page_title);

                // Generate menu

                // var menuContent = GenerateMenuByID(pageModel.menu_id);

                return pageOutput;
            }

        }
        
    }
}
