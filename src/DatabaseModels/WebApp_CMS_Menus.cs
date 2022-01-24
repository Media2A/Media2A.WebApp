using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Menus
        {
            // Columns
            public string layout_id = "layout_id";
            public string layout_content = "layout_content";
            public string theme_id = "theme_id";

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_CMS_Layouts";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name= layout_id, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Primary = true },
                 new MySql_Models.Column() { Name = layout_content, Datatype = MySql_Models.DataTypes.MEDIUMTEXT },
                 new MySql_Models.Column() { Name = theme_id, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                };

                return table;
            }
        }
    }
}