using CL.MySQL;
using Microsoft.AspNetCore.Http;

// Temp installation handler...

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        private static void CreateTables()
        {
            // WebApp

            var WebApp_Extensions = new WebApp_DatabaseModels.WebApp_Extensions().ReturnTable();
            MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_Extensions);

            var WebApp_Modules = new WebApp_DatabaseModels.WebApp_Modules().ReturnTable();
            MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_Modules);

            var WebApp_CMS_Routing = new WebApp_DatabaseModels.WebApp_CMS_Routing().ReturnTable();
            MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_CMS_Routing);

            var WebApp_CMS_Redirect = new WebApp_DatabaseModels.WebApp_CMS_Redirect().ReturnTable();
            MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_CMS_Redirect);

            // CMS
            var WebApp_CMS_Themes = new WebApp_DatabaseModels.WebApp_CMS_Themes().ReturnTable();
            MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_CMS_Themes);

            var WebApp_CMS_Pages = new WebApp_DatabaseModels.WebApp_CMS_Pages().ReturnTable();
            MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_CMS_Pages);

            var WebApp_CMS_Layouts = new WebApp_DatabaseModels.WebApp_CMS_Layouts().ReturnTable();
            MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_CMS_Layouts);

            var WebApp_CMS_Templates = new WebApp_DatabaseModels.WebApp_CMS_Templates().ReturnTable();
            MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_CMS_Templates);

            var WebApp_Sessions = new WebApp_DatabaseModels.WebApp_Sessions().ReturnTable();
            MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_Sessions);

            var WebApp_CMS_Widgets = new WebApp_DatabaseModels.WebApp_CMS_Widgets().ReturnTable();
            MySql_Queries.DataModel.CreateNewTableFromModel(WebApp_CMS_Widgets);
        }

        private static void ExtensionsInstall()
        {
            var extensionPath = CodeLogic.CodeLogic_Defaults.GetBaseFilePath();
            string[] extensionDlls = Directory.GetFiles(extensionPath, "WA.*.dll", SearchOption.AllDirectories);

            foreach (var dll in extensionDlls)
            {
                var filename = Path.GetFileName(dll);

                var result = CodeLogic.CodeLogic_Funcs.GetStringInvokeDll(filename, "Extension", "Install");
            }
        }

        public static void InstallHandler(HttpContext httpContent)
        {
            // Core

            CreateTables();

            // Extensions

            ExtensionsInstall();
        }
    }
}