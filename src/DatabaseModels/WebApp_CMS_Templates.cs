using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Templates
        {
            // Columns
            public string template_id = "template_id";
            public string template_description = "template_description";
            public string template_type = "template_type";
            public string template_content = "template_content";
            public string template_reference = "template_reference";
            public string theme_id = "theme_id";


            public MySql_Models.Table ReturnTable()
            {
                MySql_Models.Table table = new MySql_Models.Table();
                table.TableName = "WebApp_CMS_Templates";
                table.TableEngine = MySql_Models.TableEngine.INNODB;
                table.Columns = new MySql_Models.Column[] {
                 new MySql_Models.Column() { Name = template_id, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 50 },
                 new MySql_Models.Column() { Name = template_description, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255, Index = true  },
                 new MySql_Models.Column() { Name = template_type, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35 },
                 new MySql_Models.Column() { Name = template_content, Datatype = MySql_Models.DataTypes.MEDIUMTEXT },
                 new MySql_Models.Column() { Name = template_reference, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 },
                 new MySql_Models.Column() { Name = theme_id, Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255 }
                };

                return table;
            }
        }
    }
}