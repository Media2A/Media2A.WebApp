using Microsoft.AspNetCore.Http;
using CodeLogic;
using System.Data;
using CL.MySQL;

namespace Media2A.WebApp
{
    public partial class WebApp_Handlers
    {
        public static void InstallHandler()
        {
            // Create tables
            MySql_Queries.ExecuteNonQuery(MySql_Queries.CreateNewTableFromModel(WebApp_DatabaseModels.WebApp_CMS_Widgets()));
            MySql_Queries.ExecuteNonQuery(MySql_Queries.CreateNewTableFromModel(WebApp_DatabaseModels.WebApp_CMS_Templates()));
            MySql_Queries.ExecuteNonQuery(MySql_Queries.CreateNewTableFromModel(WebApp_DatabaseModels.WebApp_CMS_Themes()));
            MySql_Queries.ExecuteNonQuery(MySql_Queries.CreateNewTableFromModel(WebApp_DatabaseModels.WebApp_CMS_Layouts()));
            MySql_Queries.ExecuteNonQuery(MySql_Queries.CreateNewTableFromModel(WebApp_DatabaseModels.WebApp_CMS_Pages()));


        }
    }
}
