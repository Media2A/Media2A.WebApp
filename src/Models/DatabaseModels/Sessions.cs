using CL.MySQL;
using CL.MySQL.MySqlModels;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Media2A.WebApp
{
    public partial class DatabaseModels
    {
        public class Sessions
        {
            // Columns
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Primary = true)]
            public string session_id;
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string session_uniqueId;
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string session_clientId;
            [CP(Datatype = MySql_Models.DataTypes.DATETIME)]
            public string session_dateTimeStarted;
            [CP(Datatype = MySql_Models.DataTypes.DATETIME)]
            public string session_dateTimeLast;
            [CP(Datatype = MySql_Models.DataTypes.JSON)]
            public string session_data;
            [CP(Datatype = MySql_Models.DataTypes.TINYINT)]
            public bool session_isBot;
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string session_ipAddress;
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string session_ipForward;
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string session_lastUrl;

        }
    }
}