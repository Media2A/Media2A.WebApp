using CodeLogic;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static string ProcessModule(string moduleName, string moduleParm)
        {
            var fileName = $"WA.Core.{ CodeLogic_Funcs.UpperCaseFirstCharacter(moduleName) }";
            var moduleType = $"WA.Core.{CodeLogic_Funcs.UpperCaseFirstCharacter(moduleName)}.Module";
            string[] moduleParms = { moduleParm };
            var result = CodeLogic_Funcs.GetStringInvokeDllWithParm(fileName+ ".dll", moduleType, "ModuleProcessor", moduleParms);
            return result;
        }
    }
}