using CodeLogic;
using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public partial class Cms
        {
            public static string GetTemplateByID(string templateId)
            {
                var templateModel = new WebApp_DatabaseModels.WebApp_CMS_Templates();

                var templateContent = CL.MySQL.MySql_Queries.DataModel.GetDataByModelByID(templateModel.GetType(), nameof(templateModel.template_id), templateId);

                return templateContent.GetValueOrDefault(nameof(templateModel.template_content)).ToString();
            }

            public static string GetTemplateByIDWithReplace(string templateId, List<string[]> ts)
            {
                var templateModel = new WebApp_DatabaseModels.WebApp_CMS_Templates();

                var menuData = CL.MySQL.MySql_Queries.DataModel.GetDataByModelByID(templateModel.GetType(), nameof(templateModel.template_id), templateId);

                // Menu items
                //templateModel.template_content = MySql_Tools.GetRecordValue(menuData, );

                return templateModel.template_content;
            }
            public static string GetTemplateStaticDefault(string file)
            {
                var filePath = $"{CodeLogic_Defaults.GetBaseFilePath()}/wwwroot/WebApp/Themes/Default/" + file;

                var templateModel = CodeLogic_Funcs.ReadTextFile(filePath);

                return templateModel;
            }
            public static string GetTemplateStatic(string file, string themeId)
            {
                var filePath = $"{CodeLogic_Defaults.GetBaseFilePath()}/wwwroot/WebApp/Themes/" + themeId  + "/" + file;

                var templateModel = CodeLogic_Funcs.ReadTextFile(filePath);

                return templateModel;
            }
        }
    }
}