﻿using CL.MySQL;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void Module(HttpContext httpContent, string moduleName)
        {
            // Get module info

            var moduleModel = new WebApp_DatabaseModels.WebApp_Modules();
            var moduleData = MySql_Queries.DataModel.GetDataByModelByID(moduleModel.ReturnTable(), moduleModel.module_id, moduleName);

            var funcName = moduleData.GetValueOrDefault(moduleModel.module_func);

            // CodeLogic_Funcs.GetObjectInvokeDll()
        }
    }
}