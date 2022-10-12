using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_Extensions
        {
            // Columns
            public string extension_id;

            public string extension_name;
            public string extension_desc;
            public string extension_creator;

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_Extensions";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name = nameof(extension_id), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 15,  Primary = true},
                 new MySql_Models.Column() { Name = nameof(extension_name), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Index = true  },
                 new MySql_Models.Column() { Name = nameof(extension_desc), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = nameof(extension_creator), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                };

                return table;
            }
        }
    }
}