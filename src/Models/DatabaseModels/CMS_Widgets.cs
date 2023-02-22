using CL.MySQL;
using CL.MySQL.MySqlModels;

namespace Media2A.WebApp
{
    public partial class DatabaseModels
    {
        public class CMS_Widgets
        {
            // Columns
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Primary = true)]
            public string widget_id;

            [CP(Datatype = MySql_Models.DataTypes.MEDIUMTEXT)]
            public string widget_content;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            [CA(ReferenceKey = nameof(CMS_Themes.theme_id), ReferenceTable = nameof(CMS_Themes))]
            public string theme_id;
        }
    }
}