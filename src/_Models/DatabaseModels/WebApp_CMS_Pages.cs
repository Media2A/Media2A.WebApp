using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Pages
        {
            // Columns
            public string page_id;
            public string page_title;
            public string page_description;
            public string page_keywords;
            public string page_content;
            public string page_creationdatetime;
            public string page_lastchangedatetime;
            public string page_author;
            public string page_tags;
            public string page_permission;
            public string page_published;
            public string page_hits;
            public string theme_id;
            public string menu_id;

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();

                table.TableName = "WebApp_CMS_Pages";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name = nameof(page_id), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 36, Primary = true },
                 new MySql_Models.Column() { Name = nameof(page_title), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 50 },
                 new MySql_Models.Column() { Name = nameof(page_description), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = nameof(page_keywords), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = nameof(page_content), Datatype = MySql_Models.DataTypes.MEDIUMTEXT },
                 new MySql_Models.Column() { Name = nameof(page_creationdatetime), Datatype = MySql_Models.DataTypes.DATETIME },
                 new MySql_Models.Column() { Name = nameof(page_lastchangedatetime), Datatype = MySql_Models.DataTypes.DATETIME },
                 new MySql_Models.Column() { Name = nameof(page_author), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = nameof(page_tags), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = nameof(page_permission), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = nameof(page_published), Datatype = MySql_Models.DataTypes.TINYINT },
                 new MySql_Models.Column() { Name = nameof(page_hits), Datatype = MySql_Models.DataTypes.INT },
                 new MySql_Models.Column() { Name = nameof(theme_id), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 50 },
                 new MySql_Models.Column() { Name = nameof(menu_id), Datatype = MySql_Models.DataTypes.VARCHAR, Size = 50 },
                };

                return table;
            }
        }
    }
}