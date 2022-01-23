using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_Extensions
        {
            // Columns
            public string extension_id = "extension_id";
            public string extension_name = "extension_name";
            public string extension_desc = "extension_desc";
            public string extension_creator = "extension_creator";

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_Extensions";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name = extension_id, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 15,  Primary = true},
                 new MySql_Models.Column() { Name = extension_name, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Index = true  },
                 new MySql_Models.Column() { Name = extension_desc, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = extension_creator, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                };

                return table;
            }
        }
    }
}