using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static object GetMethodResult(string extensionName, string method, HttpContext httpContent)
        {
            var extName = $"WA.{extensionName}.dll";
            var extMethod = $"WA.{extensionName}.{method}";
            var result = CodeLogic_Funcs.GetObjectInvokeDll(extName, extMethod, extMethod);
            return result;
        }
    }
}