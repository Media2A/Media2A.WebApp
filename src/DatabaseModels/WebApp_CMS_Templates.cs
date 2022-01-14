using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public static MySql_Models.Table WebApp_CMS_Templates()
        {
            var table = new MySql_Models.Table();

            table.TableName = "WebApp_CMS_Templates";

            table.Column = new MySql_Models.Column[] {
                new MySql_Models.Column(true, false,"template_id", MySql_Models.DataTypes.INT, 0, false, "", ""),
                new MySql_Models.Column(false, false,"template_name", MySql_Models.DataTypes.VARCHAR, 10, false, "", ""),
                new MySql_Models.Column(false, false,"template_desc", MySql_Models.DataTypes.VARCHAR, 10, false, "", ""),
                new MySql_Models.Column(false, false,"template_content", MySql_Models.DataTypes.BLOB, 0, false, "", ""),
                new MySql_Models.Column(false, false,"theme_id", MySql_Models.DataTypes.BLOB, 0, false, "", "")

            };

            return table;
        }
    }
}