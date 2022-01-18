using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Routing
        {
            // Columns
            public string route_id = "route_id";
            public string route_url = "route_url";
            public string route_type = "route_type";
            public string route_counter = "route_counter";
            public string route_permission = "route_permission";

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_CMS_Layout";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name= route_id, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Primary = true },
                 new MySql_Models.Column() { Name = route_url, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = route_type, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = route_counter, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = route_permission, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                };

                return table;
            }
        }
    }
}