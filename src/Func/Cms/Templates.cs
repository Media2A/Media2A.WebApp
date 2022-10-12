﻿using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public partial class Cms
        {
            public static string GetTemplateByID(string templateId)
            {
                var templateModel = new WebApp_DatabaseModels.WebApp_CMS_Templates();

                var menuData = CL.MySQL.MySql_Queries.DataModel.GetDataByModelByID(templateModel.ReturnTable(), nameof(templateModel.template_id), templateId);

                // Menu items
                templateModel.template_content = MySql_Tools.GetRecordValue(menuData, nameof(templateModel.template_content));

                return templateModel.template_content;
            }

            public static string GetTemplateByIDWithReplace(string templateId, List<string[]> ts)
            {
                var templateModel = new WebApp_DatabaseModels.WebApp_CMS_Templates();

                var menuData = CL.MySQL.MySql_Queries.DataModel.GetDataByModelByID(templateModel.ReturnTable(), nameof(templateModel.template_id), templateId);

                // Menu items
                templateModel.template_content = MySql_Tools.GetRecordValue(menuData, nameof(templateModel.template_content));

                return templateModel.template_content;
            }
        }
    }
}