using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_Sessions
        {
            // Columns
            public string session_id;

            public string session_uniqueId;
            public string session_clientId;
            public string session_dateTimeStarted;
            public string session_dateTimeLast;
            public string session_data;
            public bool session_isBot;
            public string session_ipAddress;
            public string session_ipForward;
            public string session_lastUrl;

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_Sessions";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name = nameof(session_id), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255, Primary = true},
                 new MySql_Models.Column() { Name = nameof(session_uniqueId), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255  },
                 new MySql_Models.Column() { Name = nameof(session_clientId), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255  },
                 new MySql_Models.Column() { Name = nameof(session_dateTimeStarted), Datatype = MySql_Models.DataTypes.DATETIME  },
                 new MySql_Models.Column() { Name = nameof(session_dateTimeLast), Datatype = MySql_Models.DataTypes.DATETIME  },
                 new MySql_Models.Column() { Name = nameof(session_data), Datatype = MySql_Models.DataTypes.JSON  },
                 new MySql_Models.Column() { Name = nameof(session_isBot), Datatype = MySql_Models.DataTypes.TINYINT},
                 new MySql_Models.Column() { Name = nameof(session_ipAddress), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = nameof(session_ipForward), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = nameof(session_lastUrl), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                };

                return table;
            }
        }
    }
}