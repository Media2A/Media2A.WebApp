using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_Modules
        {
            // Columns
            public string module_id;

            public string module_type;
            public string module_func;
            public string extension_id;

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_Modules";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name = nameof(module_id), Datatype = MySql_Models.DataTypes.CHAR, Size = 35, Primary = true},
                 new MySql_Models.Column() { Name = nameof(module_type), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35  },
                 new MySql_Models.Column() { Name = nameof(module_func), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = nameof(extension_id), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                };

                return table;
            }
        }
    }
}