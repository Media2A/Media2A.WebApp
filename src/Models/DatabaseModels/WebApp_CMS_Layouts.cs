using CL.MySQL;
using CL.MySQL.MySqlModels;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        [TP(TableEngine = MySql_Models.TableEngine.INNODB)]
        public class WebApp_CMS_Layouts : CP
        {
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Primary = true)]
            public string layout_id;

            [CP(Datatype = MySql_Models.DataTypes.MEDIUMTEXT)]
            public string layout_content;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            [CA(ReferenceKey = nameof(WebApp_CMS_Themes.theme_id), ReferenceTable = nameof(WebApp_CMS_Themes))]
            public string theme_id;
        }
    }
}