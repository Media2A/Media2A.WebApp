using CodeLogic;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static object ProcessModule(string moduleName, string[] moduleParm)
        {
            var filePath = $"{CodeLogic_Defaults.GetStorageFilePath()}/extensions/";
            var result = CodeLogic_Funcs.GetStringInvokeDll(filePath, $"WA.{moduleName}", "");
            // [$MODULE|WA.Core.Menus|Menu$]
            return result;
        }

    }
}