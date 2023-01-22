using CL.MySQL;
using CL.MySQL.MySqlModels;

namespace Media2A.WebApp
{
    public partial class WebApp_DatabaseModels
    {
        public class WebApp_CMS_Redirect
        {
            // Columns
            [CP(Datatype = MySql_Models.DataTypes.INT, AutoIncrement = true, Primary = true)]
            public string redirect_id;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255, Index = true)]
            public string redirect_url;

            [CP(Datatype = MySql_Models.DataTypes.INT)]
            public string redirect_counter;

            [CP(Datatype = MySql_Models.DataTypes.VARCHAR, Size = 255)]
            public string redirect_permission;

        }
    }
}