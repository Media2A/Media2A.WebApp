using CL.MySQL;
using CL.MySQL.MySqlModels;

namespace Media2A.WebApp
{
    public partial class DatabaseModels
    {
        public class CMS_Themes
        {
            // Columns
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Primary = true)]
            public string theme_id;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string theme_name;

            [CP(Datatype = MySql_Models.DataTypes.DATETIME)]
            public string theme_desc;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string theme_imported_datetime;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            public string theme_auther;

            [CP(Datatype = MySql_Models.DataTypes.TINYINT)]
            public string theme_default;
        }
    }
}
