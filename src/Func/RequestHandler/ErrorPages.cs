using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void ErrorPage(HttpContext context, int errorCode)
        {
            // Get page template

            var themeTemplate = WebApp_Funcs.Cms.GetTemplateStaticDefault("error.html");

            // Switch depending of error code

            var langFile = "webapp.errorpage";

            string header = "";
            string desc = "";

            switch (errorCode)
            {
                case 404:
                    header = WebApp_Funcs.Cms.GetLocalizationString(langFile, "errorpage.404-header", context);
                    desc = WebApp_Funcs.Cms.GetLocalizationString(langFile, "errorpage.404-desc", context);
                    break;
                case 500:
                    header = WebApp_Funcs.Cms.GetLocalizationString(langFile, "errorpage.500-header", context);
                    desc = WebApp_Funcs.Cms.GetLocalizationString(langFile, "errorpage.500-desc", context);
                    break;
                default:
                    header = WebApp_Funcs.Cms.GetLocalizationString(langFile, "errorpage.0-header", context);
                    desc = WebApp_Funcs.Cms.GetLocalizationString(langFile, "errorpage.0-desc", context);
                    break;
            }


            themeTemplate = themeTemplate.Replace("{error}", errorCode.ToString());

            themeTemplate = themeTemplate.Replace("{title}", $"{errorCode.ToString()} - {header}");
            themeTemplate = themeTemplate.Replace("{header}", $"{header}");
            themeTemplate = themeTemplate.Replace("{content}", $"{desc}");

            // Do page work

            var pageOutput = themeTemplate;

            context.Response.WriteAsync(pageOutput);
        }

        public static void DebugPage(HttpContext context, int errorCode, string customText)
        {
            // Get page template

            var themeTemplate = WebApp_Funcs.Cms.GetTemplateStaticDefault("debug.html");

            // Switch depending of error code

            var langFile = "webapp.errorpage";

            string header = "";
            string desc = "";

            switch (errorCode)
            {
                default:
                    header = WebApp_Funcs.Cms.GetLocalizationString(langFile, "errorpage.0-header", context);
                    desc = WebApp_Funcs.Cms.GetLocalizationString(langFile, "errorpage.0-desc", context);
                    break;
            }


            themeTemplate = themeTemplate.Replace("{error}", errorCode.ToString());

            themeTemplate = themeTemplate.Replace("{title}", $"{errorCode.ToString()} - {header}");
            themeTemplate = themeTemplate.Replace("{header}", $"{header}");
            themeTemplate = themeTemplate.Replace("{content}", $"{customText}");

            // Do page work

            var pageOutput = themeTemplate;

            context.Response.WriteAsync(pageOutput);
        }
    }
}