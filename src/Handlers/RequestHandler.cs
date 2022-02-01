using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public static void RequestHandler(HttpContext httpContent)
        {
            try
            {
                // ----------- PROCESS HEADERS AND ENFORCEMENT ------------

                // Http headers check - Access-Control-Allow-Origin, etc...

                WebApp_Funcs.HttpHeadersCheck(httpContent);

                // Enforce https if enabled in config

                WebApp_Funcs.HttpsEnforce(httpContent);

                // SESSION HANDLING

                WebApp_Funcs.UpdateSession(httpContent);

                // ----------- PROCESS REQUEST ------------

                // ROUTING

                var routeInfo = WebApp_Funcs.Routing(httpContent); // retrieve routing info from database

                if(routeInfo.Count < 1)
                {
                    WebApp_Funcs.ErrorPage(httpContent, 404);
                }
                else
                {
                    var routingDataModel = new WebApp_DatabaseModels.WebApp_CMS_Routing();

                    // Process route type

                    var routeType = Enum.Parse<WebApp_AppModels.RequestHandler.RoutingTypes>(routeInfo.GetValueOrDefault(routingDataModel.route_type).ToString());
                    var routeParm = routeInfo.GetValueOrDefault(routingDataModel.route_parameters).ToString();

                    switch (routeType)
                    {
                        case WebApp_AppModels.RequestHandler.RoutingTypes.PAGE:
                            WebApp_Funcs.PageGenerator(httpContent, routeParm);
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

                            var menuTest = WebApp_Funcs.Cms.GenerateMenuByID("fraghunt");
                            httpContent.Response.WriteAsync("TEST MENU: " + menuTest);

                            // var test = CodeLogic_Funcs.GetStringInvokeDll("WebApp.Extension.Testing", "Extension", "Test");

                            //httpContent.Response.WriteAsync(test);
                            break;

                        default:
                            httpContent.Response.WriteAsync("DEFAULT");
                            break;
                    }
                
                }

            }
            catch (Exception ex)
            {
                httpContent.Response.WriteAsync(ex.ToString());
            }
        }
    }
}