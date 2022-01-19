﻿using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public static async void RequestHandler(HttpContext httpContent)
        {
            try
            {
                // ----------- PROCESS HEADERS AND ENFORCEMENT ------------

                // Http headers check - Access-Control-Allow-Origin, etc...

                WebApp_Funcs.HttpHeadersCheck(httpContent);

                // Enforce https if enabled in config

                WebApp_Funcs.HttpsEnforce(httpContent);

                // ----------- PROCESS REQUEST ------------

                // ROUTING

                var routeInfo = WebApp_Funcs.Routing(httpContent); // retrieve routing info from database

                var routingDataModel = new WebApp_DatabaseModels.WebApp_CMS_Routing();

                // Process route type

                var routeType = Enum.Parse<WebApp_AppModels.Cms.RoutingTypes>(routeInfo.GetValueOrDefault(routingDataModel.route_type).ToString());

                switch (routeType)
                {
                    case WebApp_AppModels.Cms.RoutingTypes.PAGE:
                        httpContent.Response.WriteAsync("PAGE");
                        break;

                    case WebApp_AppModels.Cms.RoutingTypes.MODULE:
                        httpContent.Response.WriteAsync("MODULE");
                        break;

                    case WebApp_AppModels.Cms.RoutingTypes.REDIRECT:
                        WebApp_Funcs.Redirect(httpContent);

                        break;

                    case WebApp_AppModels.Cms.RoutingTypes.EXTERNAL:
                        httpContent.Response.WriteAsync("EXTERNAL");
                        break;

                    default:
                        httpContent.Response.WriteAsync("DEFAULT");
                        break;
                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}