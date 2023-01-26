using CL.MySQL.ConfigModels;
using CL.Smtp.ConfigModels;
using CodeLogic;
using Media2A.WebApp.ConfigModels;
using System.Xml.XPath;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void Configuration()
        {

            // Make sure folders exist

            var path = CodeLogic_Defaults.GetDataFilePath();

            string[] dirs = { "configs", "localization", "logs", "storage" };

            foreach (var item in dirs)
            {
                Directory.CreateDirectory(path + item);
            }

            Directory.CreateDirectory(path);

            // Localization files
            CodeLogic_Framework.CacheLocalizationFiles();

            // Generate or check Database config
            CodeLogic_Framework.ValidateConfigFile("database.json", Database_Object.GenerateModel());

            // Smtp
            CodeLogic_Framework.ValidateConfigFile("smtp.json", Smtp_Object.GenerateModel());

            // WebApp
            CodeLogic_Framework.ValidateConfigFile("webapp.json", WebApp_Object.GenerateModel());

        }
    }
}