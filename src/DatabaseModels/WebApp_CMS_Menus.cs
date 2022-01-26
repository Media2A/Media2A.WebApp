using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Menus
        {
            // Columns
            public string menu_id = "menu_id";
            public string menu_name = "menu_name";
            public string menu_description = "menu_description";
            public string menu_default = "menu_default";
            public string template_id = "template_id";


            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_CMS_Menus";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name= menu_id, Datatype = MySql_Models.DataTypes.INT, AutoIncrement = true, Primary = true },
                 new MySql_Models.Column() { Name = menu_name, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 150 },
                 new MySql_Models.Column() { Name = menu_description, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = menu_default, Datatype = MySql_Models.DataTypes.TINYINT },
                 new MySql_Models.Column() { Name = template_id, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },

                };

                return table;
            }
        }
    }
}