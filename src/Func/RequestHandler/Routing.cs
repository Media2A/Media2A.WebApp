using CL.MySQL;
using CodeLogic;
using Microsoft.AspNetCore.Http;

namespace Media2A.WebApp
{
    public partial class WebApp_Funcs
    {
        public static SortedDictionary<string, object> Routing(HttpContext httpContent)
        {
            var pathLookup = CodeLogic_Funcs.SplitUrlString(CodeLogic_Funcs.GetPath(httpContent), 1);
            var routingDataModel = new WebApp_DatabaseModels.WebApp_CMS_Routing();
            var RoutingInfo = MySql_Queries.DataModel.GetDataByModelByID(routingDataModel.ReturnTable(), nameof(routingDataModel.route_url), pathLookup);

            return RoutingInfo;
        }
    }
}