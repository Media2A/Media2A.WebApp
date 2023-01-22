using CL.MySQL;
using CL.MySQL.MySqlModels;
using System.ComponentModel.DataAnnotations;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Templates
        {
            // Columns
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 50)]
            public string template_id;
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255, Index = true)]
            public string template_description;
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            public string template_type;
            [CP(Datatype = MySql_Models.DataTypes.MEDIUMTEXT)]
            public string template_content;
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string template_reference;
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string theme_id;

        }
    }
}