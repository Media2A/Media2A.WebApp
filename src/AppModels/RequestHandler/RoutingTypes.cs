using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media2A.WebApp
{
    public partial class WebApp_AppModels
    {
        public partial class RequestHandler
        {
            public enum RoutingTypes
            {
                REDIRECT,
                PAGE,
                MODULE,
                EXTERNAL,
            }
        }
    }
}
