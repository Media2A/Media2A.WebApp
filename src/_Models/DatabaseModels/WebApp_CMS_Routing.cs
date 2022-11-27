using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Routing
        {
            public int route_id;
            public string route_url;
            public string route_type;
            public string route_parameters;
            public string route_counter;
            public string route_permission;

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_CMS_Routing";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name = nameof(route_id), Datatype = MySql_Models.DataTypes.INT, AutoIncrement = true, Primary = true},
                 new MySql_Models.Column() { Name = nameof(route_url), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255, Index = true  },
                 new MySql_Models.Column() { Name = nameof(route_type), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 15 },
                 new MySql_Models.Column() { Name = nameof(route_parameters), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255, Index = true  },
                 new MySql_Models.Column() { Name = nameof(route_counter), Datatype = MySql_Models.DataTypes.INT },
                 new MySql_Models.Column() { Name = nameof(route_permission), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                };

                return table;
            }
        }
    }
}