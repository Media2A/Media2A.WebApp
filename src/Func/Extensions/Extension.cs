using Microsoft.AspNetCore.Http;
using CodeLogic;
using CL.MySQL;
using System.Data;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static object GetMethodResult(string extensionName, string method, HttpContext httpContent)
        {
            var extName = $"WA.{extensionName}.dll";
            var extMethod = $"WA.{extensionName}.{method}"; 
            CodeLogic_Funcs.GetObjectInvokeDll(extName, extMethod, extMethod);
            return "";
        }

    }
}
