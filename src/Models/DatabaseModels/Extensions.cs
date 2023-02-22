using CL.MySQL;
using CL.MySQL.MySqlModels;

namespace Media2A.WebApp
{
    public partial class DatabaseModels
    {
        public class Extensions
        {
            // Columns
            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 15, Primary = true)]
            public string extension_id;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35, Index = true)]
            public string extension_name;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string extension_desc;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 35)]
            public string extension_creator;
        }
    }
}