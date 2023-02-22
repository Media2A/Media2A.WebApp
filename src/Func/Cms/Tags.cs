using CL.MySQL;
using CodeLogic;
using Microsoft.AspNetCore.Http;


namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public partial class Cms
        {
            private static string TagProcessor(SortedDictionary<string, object> pageData, string[] tagContent, HttpContext httpContext)
            {
                var returnCode = "";

                // Get tag values
                var tagType = tagContent[0];
                var tagName = tagContent[1];
                var tagData = tagContent[2];

                switch (Enum.Parse<WebApp_AppModels.Cms.TagType>(tagType))
                {
                    case WebApp_AppModels.Cms.TagType.Module:
                        // returnCode = ProcessModule(tagName, tagData).ToString();
                        break;

                    case WebApp_AppModels.Cms.TagType.WebApp:
                        returnCode = Tag_Page(pageData, tagData);
                        break;

                    default:
                        break;
                }

                return returnCode;
            }

            public static string ProcessTags(SortedDictionary<string, object> pageData, string templateContent, HttpContext httpContent)
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

                        output = output.Replace(tagRaw, TagProcessor(pageData, tagContent, httpContent));
                    }
                }

                return output;
            }

            // Tag functionailty

            public static string Tag_Page(SortedDictionary<string, object> pageData, string tagContent)
            {

                var returnCode = "";
                var pageModel = new DatabaseModels.CMS_Pages();

                switch (Enum.Parse<WebApp_AppModels.Cms.PageElements>(tagContent))
                {
                    case WebApp_AppModels.Cms.PageElements.CONTENT_URL:
                        returnCode = CodeLogic_Framework.GetConfigValueString("webapp.json", "StaticContentUrl");
                        break;
                    case WebApp_AppModels.Cms.PageElements.WEBAPP_URL:
                        returnCode = "/webapp";
                        break;
                    case WebApp_AppModels.Cms.PageElements.PAGE_TITLE:
                        returnCode = MySql_Tools.GetRecordValue(pageData, nameof(pageModel.page_title));
                        break;
                    case WebApp_AppModels.Cms.PageElements.PAGE_KEYWORDS:
                        
                        returnCode = MySql_Tools.GetRecordValue(pageData, nameof(pageModel.page_keywords));
                        break;
                    case WebApp_AppModels.Cms.PageElements.PAGE_DESCRIPTION:
                        returnCode = MySql_Tools.GetRecordValue(pageData, nameof(pageModel.page_description));
                        break;
                    case WebApp_AppModels.Cms.PageElements.PAGE_AUTHOR:
                        returnCode = MySql_Tools.GetRecordValue(pageData, nameof(pageModel.page_author));
                        break;
                    case WebApp_AppModels.Cms.PageElements.PAGE_CONTENT:
                        returnCode = MySql_Tools.GetRecordValue(pageData, nameof(pageModel.page_content));
                        break;
                    default:
                        break;
                }
                return returnCode;
            }
        }
    }
}