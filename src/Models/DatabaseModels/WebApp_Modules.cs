using CL.MySQL;
using CL.MySQL.MySqlModels;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_Modules
        {
            // Columns
            [CP(Datatype = MySql_Models.DataTypes.CHAR, Size = 35, Primary = true)]
            public string module_id;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            public string module_type;
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            public string module_func;
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            public string extension_id;

        }
    }
}