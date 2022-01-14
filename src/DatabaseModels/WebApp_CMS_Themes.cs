using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public static MySql_Models.Table WebApp_CMS_Themes()
        {
            var table = new MySql_Models.Table();

            table.TableName = "WebApp_CMS_Themes";

            table.Column = new MySql_Models.Column[] {
                new MySql_Models.Column(true, false,"theme_id", MySql_Models.DataTypes.INT, 10, false, "", ""),
                new MySql_Models.Column(false, false,"theme_name", MySql_Models.DataTypes.VARCHAR, 10, false, "", ""),
                new MySql_Models.Column(false, false,"theme_desc", MySql_Models.DataTypes.VARCHAR, 10, false, "", "")

            };

            return table;
        }
    }
}