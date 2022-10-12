using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public partial class Cms
        {
            public static string DefaultTemplateProcessing(string templateContent, HttpContext httpContent)
            {
                // Get CDN domain

                var contentUrl = CodeLogic_Framework.GetConfigValueString("webapp.json", "StaticContentUrl");
                templateContent = CodeLogic_Funcs.SimpleReplaceTag(templateContent, "SITE_CDN_URL", contentUrl);

                return templateContent;
            }
        }
    }
}