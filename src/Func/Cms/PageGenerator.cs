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
        public class Cms
        {
            public static void GeneratePageByID(string pageID, HttpContext httpContent)
            {
                

                // General variables
                var pageModel = new WebApp_DatabaseModels.WebApp_CMS_Pages();

                var pageData = CL.MySQL.MySql_Queries.GetDataByModelByID(pageModel.ReturnTable(), pageModel.page_id, pageID);

                pageModel.page_title = MySql_Tools.GetRecordValue(pageData, pageModel.page_title);
                pageModel.page_description = MySql_Tools.GetRecordValue(pageData, pageModel.page_description);
                pageModel.page_content = MySql_Tools.GetRecordValue(pageData, pageModel.page_content);

                httpContent.Response.WriteAsync(pageModel.page_content);
            }

        }
        
    }
}
