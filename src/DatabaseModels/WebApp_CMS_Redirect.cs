using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Redirect
        {
            // Columns
            public string redirect_id = "redirect_id";
            public string redirect_url = "redirect_url";
            public string redirect_counter = "redirect_counter";
            public string redirect_permission = "redirect_permission";

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_CMS_Redirects";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name = redirect_id, Datatype = MySql_Models.DataTypes.INT, AutoIncrement = true, Primary = true},
                 new MySql_Models.Column() { Name = redirect_url, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255, Index = true  },
                 new MySql_Models.Column() { Name = redirect_counter, Datatype = MySql_Models.DataTypes.INT },
                 new MySql_Models.Column() { Name = redirect_permission, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                };

                return table;
            }
        }
    }
}