﻿using CL.MySQL;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {

        private static void CreateTables()
        {
            // WebApp

            var WebApp_Extensions = new WebApp_DatabaseModels.WebApp_Extensions().ReturnTable();
            MySql_Queries.CreateNewTableFromModel(WebApp_Extensions);

            var WebApp_Modules = new WebApp_DatabaseModels.WebApp_Modules().ReturnTable();
            MySql_Queries.CreateNewTableFromModel(WebApp_Modules);

            var WebApp_CMS_Routing = new WebApp_DatabaseModels.WebApp_CMS_Routing().ReturnTable();
            MySql_Queries.CreateNewTableFromModel(WebApp_CMS_Routing);

            var WebApp_CMS_Redirect = new WebApp_DatabaseModels.WebApp_CMS_Redirect().ReturnTable();
            MySql_Queries.CreateNewTableFromModel(WebApp_CMS_Redirect);

            var WebApp_CMS_Themes = new WebApp_DatabaseModels.WebApp_Modules().ReturnTable();
            MySql_Queries.CreateNewTableFromModel(WebApp_CMS_Themes);

            // CMS

            var WebApp_CMS_Pages = new WebApp_DatabaseModels.WebApp_CMS_Pages().ReturnTable();
            MySql_Queries.CreateNewTableFromModel(WebApp_CMS_Pages);

            var WebApp_CMS_Layouts = new WebApp_DatabaseModels.WebApp_CMS_Layouts().ReturnTable();
            MySql_Queries.CreateNewTableFromModel(WebApp_CMS_Layouts);









        }
        public static void InstallHandler(HttpContext httpContent)
        {
            CreateTables();
        }

    }
}