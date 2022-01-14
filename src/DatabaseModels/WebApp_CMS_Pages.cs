using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public static MySql_Models.Table WebApp_CMS_Pages()
        {
            var table = new MySql_Models.Table();

            table.TableName = "WebApp_CMS_Pages";

            table.Column = new MySql_Models.Column[] {
                new MySql_Models.Column(true, false,"page_id", MySql_Models.DataTypes.INT, 10, false, "", ""),
                new MySql_Models.Column(false, false,"page_title", MySql_Models.DataTypes.VARCHAR, 10, false, "", ""),
                new MySql_Models.Column(false, false,"page_description", MySql_Models.DataTypes.VARCHAR, 10, false, "", ""),
                new MySql_Models.Column(false, false,"page_creationdate", MySql_Models.DataTypes.DATETIME, 10, false, "", ""),
                new MySql_Models.Column(false, false,"page_modifieddate", MySql_Models.DataTypes.DATETIME, 10, false, "", ""),
                new MySql_Models.Column(false, false,"page_author", MySql_Models.DataTypes.VARCHAR, 10, false, "", ""),
                new MySql_Models.Column(false, false,"page_tags", MySql_Models.DataTypes.VARCHAR, 10, false, "", ""),
                new MySql_Models.Column(false, false,"page_permission", MySql_Models.DataTypes.VARCHAR, 10, false, "", ""),
                new MySql_Models.Column(false, false,"page_published", MySql_Models.DataTypes.SMALLINT, 10, false, "", ""),
                new MySql_Models.Column(false, false,"page_hits", MySql_Models.DataTypes.INT, 10, false, "", ""),
                new MySql_Models.Column(false, false,"theme_id", MySql_Models.DataTypes.VARCHAR, 10, false, "", ""),
                new MySql_Models.Column(false, false,"layout_id", MySql_Models.DataTypes.VARCHAR, 10, false, "", ""),
                new MySql_Models.Column(false, false,"template_id", MySql_Models.DataTypes.VARCHAR, 10, false, "", ""),
            };

            return table;
        }
    }
}