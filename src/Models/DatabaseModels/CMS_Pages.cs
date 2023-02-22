using CL.MySQL.MySqlModels;

namespace Media2A.WebApp
{
    public partial class DatabaseModels
    {
        public class CMS_Pages
        {
            // Columns
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 36, Primary = true)]
            public string? page_id;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 50)]
            public string? page_title;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            public string? page_description;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            public string? page_keywords;

            [CP(Datatype = MySql_Models.DataTypes.MEDIUMTEXT)]
            public string? page_content;

            [CP(Datatype = MySql_Models.DataTypes.DATETIME)]
            public string? page_creationdatetime;

            [CP(Datatype = MySql_Models.DataTypes.DATETIME)]
            public string? page_lastchangedatetime;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            public string? page_author;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            public string? page_tags;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            public string? page_permission;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 3)]
            public string? page_type;

            [CP(Datatype = MySql_Models.DataTypes.TINYINT)]
            public bool? page_published;

            [CP(Datatype = MySql_Models.DataTypes.INT)]
            public string? page_hits;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            [CA(ReferenceKey = nameof(CMS_Themes.theme_id), ReferenceTable = nameof(CMS_Themes))]
            public string? theme_id;

        }
    }
}