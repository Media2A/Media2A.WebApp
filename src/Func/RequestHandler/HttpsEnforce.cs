using CodeLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void HttpsEnforce(HttpContext httpContent)
        {
            var enforceHttps = CodeLogic_Framework.GetConfigValueBool("webapp.json", "SiteEnforceHttps");
            var siteProxyEnabled = CodeLogic_Framework.GetConfigValueBool("webapp.json", "SiteProxyEnabled");
            string redirectUrl = httpContent.Request.GetEncodedUrl();
            string proto = httpContent.Request.Headers["X-Forwarded-Proto"];

            if(proto != null)
            {
                if (enforceHttps & siteProxyEnabled & !proto.Contains("https"))
                {
                    redirectUrl = redirectUrl.Replace("http:", "https:");
                    httpContent.Response.Redirect(redirectUrl, false);
                }
            }

        }
    }
}