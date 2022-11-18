using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public partial class Cms
        {
            public static string ProcessTags(string templateContent, HttpContext httpContent)
            {

                // Seperate tag info
                var tagRaw = CodeLogic_Funcs.ExtractBetweenTags(templateContent, "{", "}", true);
                var tagContent = tagRaw.Replace("{", "").Replace("}", "").Split(":");

                var tagType = tagContent[0];
                var tagName = tagContent[1];
                var tagData = tagContent[2].Split("|");

                var returnCode = "";

                switch (tagType)
                {
                    case "module":
                        returnCode = ProcessModule(tagName, tagData).ToString();
                        break;
                    default:
                        break;
                }

                // Execute module and replace code

                // Clean up tag from templateContent

                templateContent = templateContent.Replace(tagRaw, returnCode);

                return templateContent;
            }
        }
    }
}