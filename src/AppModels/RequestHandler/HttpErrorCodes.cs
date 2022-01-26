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
            public enum HttpErrorCodes
            {
                _400,
                _401,
                _403,
                _404,
                _500,
            }
        }
    }
}
