using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public partial class Cms
        {
            public static string GetLocalizationString(string localizationFile, string key, HttpContext httpContext)
            {
                // Defaults
                var defaultLang = "en";
                var lang = CodeLogic_Funcs.GetClientLanguage(httpContext);
                var stringContent = "";
                var langFile = $"{localizationFile}.{lang}.json";

                if (!CodeLogic_Funcs.CheckCachedObject(langFile))
                {
                    stringContent = CodeLogic_Framework.GetLocalizationValueString($"{localizationFile}.{defaultLang}.json", key);
                }
                else
                {
                    stringContent = CodeLogic_Framework.GetLocalizationValueString(langFile, key);
                }

                return stringContent;
            }
        }
    }
}