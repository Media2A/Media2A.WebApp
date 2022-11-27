using CodeLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Net.Http;
using System.Security.Policy;


namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public partial class Cms
        {
            private static string TagProcessor(string[] tagContent, HttpContext httpContext)
            {

                var returnCode = "";
                var tagType = tagContent[0];
                var tagName = tagContent[1];
                var tagData = tagContent[2];

                switch (tagType)
                {
                    case "Module":

                        returnCode = ProcessModule(tagName, tagData).ToString();

                        break;
                    case "WebApp":
                        if (tagName == "Page")
                        {
                            var url = CodeLogic_Framework.GetConfigValueString("webapp.json", "StaticContentUrl");
                            returnCode = url;
                        }
                        break;
                    default:
                        break;
                }

                return returnCode;
            }

            public static string ProcessTags(string templateContent, HttpContext httpContent)
            {
                var output = templateContent;
                var maxRun = 99; // use this for error handling
                var counterRun = 0;

                if (output.Contains("{$"))
                {
                    while (output.Contains("{$") && counterRun < maxRun)
                    {
                        counterRun++;
                        // Seperate tag info
                        var tagRaw = CodeLogic_Funcs.ExtractBetweenTags(output, "{$", "$}", true);
                        var tagClean = tagRaw.Replace("{$", "").Replace("$}", "");
                        var tagContent = tagClean.Split("|");

                        output = output.Replace(tagRaw, TagProcessor(tagContent, httpContent));


                    }
                }

                return output;
            }
        }
    }
}