using CL.MySQL;
using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static void UpdateSession(HttpContext httpContent)
        {
            var sessionId = httpContent.Session.Id;

            var sessionDataModel = new DatabaseModels.Sessions();
            var sessionData = MySql_Queries.DataModel.GetDataByModelByID(sessionDataModel.GetType(), nameof(sessionDataModel.session_id), sessionId);

            // If session not registered in db... create it

            if (sessionData.Count == 0)
            {
                DatabaseModels.Sessions s = new DatabaseModels.Sessions();
                s.session_id = httpContent.Session.Id;
                s.session_uniqueId = Guid.NewGuid().ToString();
                s.session_clientId = Guid.NewGuid().ToString();
                s.session_dateTimeStarted = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                s.session_dateTimeLast = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                s.session_isBot = CodeLogic_Funcs.IsWebCrawler(httpContent);
                s.session_ipAddress = CodeLogic_Funcs.GetClientIP(httpContent);
                s.session_ipForward = CodeLogic_Funcs.GetClientXforwardIP(httpContent);
                s.session_lastUrl = CodeLogic_Funcs.GetRawUrl(httpContent);

                MySql_Queries.DataModel.InsertDataByModelByID(s);
            }
            else
            {
                DatabaseModels.Sessions s = new DatabaseModels.Sessions();
                s.session_dateTimeLast = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                s.session_lastUrl = CodeLogic_Funcs.GetRawUrl(httpContent);

                MySql_Queries.DataModel.UpdateDataByModelByID(s, nameof(sessionDataModel.session_id), sessionId);
            }
        }

        public static string GetSessionData(string sessionId, string key)
        {
            var sessionDataModel = new DatabaseModels.Sessions();

            var sessionData = MySql_Queries.DataModel.GetAllDataByModelByParm(sessionDataModel.GetType(), new MySql_Models.QueryParameters()
            {
                Select = new MySql_Models.Select[] {
                    new MySql_Models.Select { ColumnName = nameof(sessionDataModel.session_data)
                    } },

                Where = new MySql_Models.Where[] {
                    new MySql_Models.Where { Key = nameof(sessionDataModel.session_id), Value = sessionId },

                }
            });

            if(sessionData.Count > 0)
            {
                var sessionDataJson = sessionData.First().GetValueOrDefault("SessionData");
                return sessionDataJson.ToString();
            }

            return "";
        }

        public static SortedDictionary<string, object> AddDataToSession(string sessionId)
        {
            var sessionDataModel = new DatabaseModels.Sessions();
            var RoutingInfo = MySql_Queries.DataModel.GetDataByModelByID(sessionDataModel.GetType(), nameof(sessionDataModel.session_id), sessionId);

            return RoutingInfo;
        }
    }
}