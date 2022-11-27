using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void HttpSecurityCheck(HttpContext httpContent)
        {
            var requestMethod = httpContent.Request.Method.ToString();

            // Run checks here


            if(requestMethod == "POST")
            {
                // Checks here
            }
            else if(requestMethod == "GET")
            {
                // Checks here
            }
            else
            {
                // Prvent other requests
                httpContent.Response.StatusCode = 403;
                httpContent.Response.Clear();
            }
            
        }
    }
}