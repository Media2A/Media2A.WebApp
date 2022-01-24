using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Widgets
        {
            // Columns
            public string layout_id = "widget_id";

            public string layout_content = "moduleee";
            public string themeid = "themeid";

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_CMS_Widgets";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name= layout_id, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Primary = true },
                 new MySql_Models.Column() { Name = layout_content, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = themeid, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                };

                return table;
            }
        }
    }
}