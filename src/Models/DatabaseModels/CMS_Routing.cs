using CL.MySQL;
using CL.MySQL.MySqlModels;

namespace Media2A.WebApp
{
    public partial class DatabaseModels
    {
        public class CMS_Routing
        {
            [CP(Datatype = MySql_Models.DataTypes.INT, AutoIncrement = true, Primary = true)]
            public int route_id;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255, Index = true)]
            public string route_url;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 15)]
            public string route_type;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255, Index = true)]
            public string route_parameters;

            [CP(Datatype = MySql_Models.DataTypes.INT)]
            public string route_counter;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string route_permission;
        }
    }
}