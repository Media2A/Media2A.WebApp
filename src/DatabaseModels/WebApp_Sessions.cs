using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_Sessions
        {
            // Columns
            public string session_id = "session_id";
            public string session_uniqueId = "session_uniqueId";
            public string session_clientId = "session_clientId";
            public string session_dateTimeStarted = "session_dateTimeStarted";
            public string session_dateTimeLast = "session_dateTimeLast";
            public string session_userId = "session_userId";
            public string session_isBot = "session_isBot";
            public string session_ipAddress = "session_ipAddress";
            public string session_ipForward = "session_ipForward";
            public string session_lastUrl = "session_lastUrl";

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_Sessions";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name = session_id, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255, Primary = true},
                 new MySql_Models.Column() { Name = session_uniqueId, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255  },
                 new MySql_Models.Column() { Name = session_clientId, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255  },
                 new MySql_Models.Column() { Name = session_dateTimeStarted, Datatype = MySql_Models.DataTypes.DATETIME  },
                 new MySql_Models.Column() { Name = session_dateTimeLast, Datatype = MySql_Models.DataTypes.DATETIME  },
                 new MySql_Models.Column() { Name = session_userId, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255  },
                 new MySql_Models.Column() { Name = session_isBot, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = session_ipAddress, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = session_ipForward, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = session_lastUrl, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                };

                return table;
            }
        }
    }
}