using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using CodeLogic;
using CL.MySQL;
using Media2A.WebApp;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void UpdateSession(HttpContext httpContent)
        {
            var sessionId = httpContent.Session.Id;

            var sessionDataModel = new WebApp_DatabaseModels.WebApp_Sessions();
            var sessionData = MySql_Queries.DataModel.GetDataByModelByID(sessionDataModel.ReturnTable(), sessionDataModel.session_id, sessionId);

            // If session not registered in db... create it

            if (sessionData.Count == 0)
            {

                WebApp_DatabaseModels.WebApp_Sessions s = new WebApp_DatabaseModels.WebApp_Sessions();
                s.session_id = httpContent.Session.Id;
                s.session_uniqueId = Guid.NewGuid().ToString();
                s.session_clientId = Guid.NewGuid().ToString();
                s.session_dateTimeStarted = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"); 
                s.session_dateTimeLast = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                s.session_userId = "";
                s.session_isBot = CodeLogic_Funcs.IsWebCrawler(httpContent).ToString();
                s.session_ipAddress = CodeLogic_Funcs.GetClientIP(httpContent);
                s.session_ipForward = CodeLogic_Funcs.GetClientXforwardIP(httpContent);
                s.session_lastUrl = CodeLogic_Funcs.GetRawUrl(httpContent);

                httpContent.Response.WriteAsync(MySql_Queries.DataModel.InsertDataByModelByID(s));
            }
            else
            {
               

                //MySql_Queries.DataModel.InsertDataByModelByID(s);
                // var pathLookup = CodeLogic_Funcs.SplitUrlString(CodeLogic_Funcs.GetPath(httpContent), 1);
                // var routingDataModel = new WebApp_DatabaseModels.WebApp_CMS_Routing();

                //var RoutingInfo = MySql_Queries.DataModel.GetDataByModelByID(routingDataModel.ReturnTable(), routingDataModel.route_url, pathLookup);
            }



        }

        public static SortedDictionary<string, object> GetSessionData(string sessionId)
        {

            var sessionDataModel = new WebApp_DatabaseModels.WebApp_Sessions();
            var RoutingInfo = MySql_Queries.DataModel.GetDataByModelByID(sessionDataModel.ReturnTable(), sessionDataModel.session_id, sessionId);

            return RoutingInfo;


        }
    }
}
