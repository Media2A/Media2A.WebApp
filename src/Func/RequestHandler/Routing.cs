using CL.MySQL;
using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static SortedDictionary<string, object> RoutingLookup(HttpContext httpContent)
        {
            var pathLookup = CodeLogic_Funcs.SplitUrlString(CodeLogic_Funcs.GetPath(httpContent), 1);
            var routingDataModel = new WebApp_DatabaseModels.WebApp_CMS_Routing();
            var RoutingInfo = MySql_Queries.DataModel.GetDataByModelByID(routingDataModel.ReturnTable(), nameof(routingDataModel.route_url), pathLookup);

            return RoutingInfo;
        }

        public static void Routing(HttpContext httpContent)
        {
            var routeInfo = WebApp_Funcs.RoutingLookup(httpContent); // retrieve routing info from database

            if (routeInfo.Count < 1)
            {
                WebApp_Funcs.ErrorPage(httpContent, 404);
            }


            // If no errors or checks fails - continue with page lookup
            else
            {
                // Update session

                WebApp_Funcs.UpdateSession(httpContent);

                var routingDataModel = new WebApp_DatabaseModels.WebApp_CMS_Routing();

                // Process route type

                var routeType = Enum.Parse<WebApp_AppModels.RequestHandler.RoutingTypes>(routeInfo.GetValueOrDefault(routingDataModel.route_type).ToString());
                var routeParm = routeInfo.GetValueOrDefault(routingDataModel.route_parameters).ToString();

                switch (routeType)
                {
                    case WebApp_AppModels.RequestHandler.RoutingTypes.PAGE:
                        // WebApp_Funcs.PageGenerator(httpContent, routeParm);
                        break;

                    case WebApp_AppModels.RequestHandler.RoutingTypes.COMPONENT:

                        var file = AppDomain.CurrentDomain.BaseDirectory + "WebApp.Extension.Tddesting";

                        var test2 = CodeLogic_Funcs.GetObjectInvokeDll("WebApp.Extension.Testing.dll", "WebApp.Extension.Testing.Extension", "Test");

                        httpContent.Response.WriteAsync(test2.ToString());
                        break;

                    case WebApp_AppModels.RequestHandler.RoutingTypes.REDIRECT:
                        WebApp_Funcs.Redirect(httpContent);

                        break;

                    case WebApp_AppModels.RequestHandler.RoutingTypes.EXTERNAL:
                        httpContent.Response.WriteAsync("EXTERNAL");

                        // var test = CodeLogic_Funcs.GetStringInvokeDll("WebApp.Extension.Testing", "Extension", "Test");

                        //httpContent.Response.WriteAsync(test);
                        break;

                    case WebApp_AppModels.RequestHandler.RoutingTypes.COMPONENT_API:
                        httpContent.Response.WriteAsync("COMPONENT_API");

                        // var test = CodeLogic_Funcs.GetStringInvokeDll("WebApp.Extension.Testing", "Extension", "Test");

                        //httpContent.Response.WriteAsync(test);
                        break;

                    default:
                        httpContent.Response.WriteAsync("DEFAULT");
                        break;
                }
            }
        }
    }
}