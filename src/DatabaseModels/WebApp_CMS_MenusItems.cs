using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_MenusItems
        {
            // Columns

            public string menuitem_name = "menuitem_name";
            public string menuitem_description = "menuitem_description";
            public string menuitem_type = "menuitem_type";
            public string menuitem_value = "menuitem_value";
            public string menuitem_hovertext = "menuitem_hovertext";
            public string menuitem_level = "menuitem_level";
            public string menuitem_order = "menuitem_order";
            public string menu_id = "menu_id";
            public string template_id = "template_id";

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_CMS_MenusItems";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name = menuitem_name, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = menuitem_description, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = menuitem_type, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = menuitem_value, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = menuitem_hovertext, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = menuitem_level, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = menuitem_order, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = menu_id, Datatype = MySql_Models.DataTypes.INT },
                 new MySql_Models.Column() { Name = template_id, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                };

                return table;
            }
        }
    }
}