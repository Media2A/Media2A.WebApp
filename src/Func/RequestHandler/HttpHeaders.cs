using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void HttpHeadersCheck(HttpContext httpContent)
        {
            var CrossOriginDomains = CodeLogic_Framework.GetConfigValueString("webapp.json", "CrossOriginDomains");

            if (CrossOriginDomains == null || CrossOriginDomains == "")
            {
                httpContent.Response.Headers.Remove("Access-Control-Allow-Origin");
                httpContent.Response.Headers.Append("Access-Control-Allow-Origin", CrossOriginDomains);

                httpContent.Response.Headers.Remove("Access-Control-Allow-Credentials");
                httpContent.Response.Headers.Append("Access-Control-Allow-Credentials", "true");

                httpContent.Response.Headers.Remove("Access-Control-Allow-Methods");
                httpContent.Response.Headers.Append("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
            }
        }
    }
}