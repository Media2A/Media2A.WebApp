using CL.MySQL;
using Microsoft.AspNetCore.Http;
using System.Reflection;

// Temp installation handler...

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        private static void CreateTables()
        {

            MySql_Queries.DataModel.CreateTablesFromModels(typeof(WebApp_DatabaseModels));
            
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