using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Pages
        {
            // Columns
            public string page_id = "page_id";
            public string page_title = "page_title";
            public string page_description = "page_description";
            public string page_creationdate = "page_creationdate";
            public string page_modifieddate = "page_modifieddate";
            public string page_author = "page_author";
            public string page_tags = "page_tags";
            public string page_permission = "page_permission";
            public string page_published = "page_published";
            public string page_hits = "page_hits";
            public string page_template = "page_template";

            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_CMS_Pages";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name=page_id, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Primary = true },
                 new MySql_Models.Column() { Name = page_title, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = page_description, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = page_creationdate, Datatype = MySql_Models.DataTypes.DATETIME },
                 new MySql_Models.Column() { Name = page_modifieddate, Datatype = MySql_Models.DataTypes.DATETIME },
                 new MySql_Models.Column() { Name = page_author, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = page_tags, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = page_permission, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = page_published, Datatype = MySql_Models.DataTypes.TINYINT },
                 new MySql_Models.Column() { Name = page_hits, Datatype = MySql_Models.DataTypes.INT },
                 new MySql_Models.Column() { Name = page_template, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 50 }
                };

                return table;
            }
        }
    }
}