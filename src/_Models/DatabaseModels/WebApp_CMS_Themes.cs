using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Themes
        {
            // Columns
            public string theme_id;

            public string theme_name;
            public string theme_desc;
            public string theme_imported_datetime;
            public string theme_auther;
            public string theme_default;

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_CMS_Themes";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name = nameof(theme_id), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Primary = true },
                 new MySql_Models.Column() { Name = nameof(theme_name), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = nameof(theme_imported_datetime), Datatype = MySql_Models.DataTypes.DATETIME },
                 new MySql_Models.Column() { Name = nameof(theme_desc), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = nameof(theme_auther), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = nameof(theme_default), Datatype = MySql_Models.DataTypes.TINYINT },
                };

                return table;
            }
        }
    }
}