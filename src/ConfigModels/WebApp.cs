using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media2A.WebApp.ConfigModels
{
    public class WebApp
    {
        public bool SiteProxyEnabled { get; set; }
        public int DebugLevel { get; set; }
        public int SessionTimeout { get; set; }
    }
    public class WebApp_Object
    {
        public static object GenerateModel()
        {
            var DataObject = new WebApp();
            DataObject.SiteProxyEnabled = false;
            DataObject.DebugLevel = 1;
            DataObject.SessionTimeout = 3600;

            return DataObject;
        }
    }
}
