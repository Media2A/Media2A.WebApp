using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media2A.WebApp.DatabaseModels
{
    public class WebApp_CMS_Pages
    {
        public Guid page_id { get; set; }
        public string page_title { get; set; }
        public string page_description { get; set; }
        public string page_tags { get; set; }
        public string page_permission { get; set; }
        public bool page_published { get; set; }
        public int page_hits { get; set; }
        public string page_templateid { get; set; }
    }
     public class WebApp_CMS_Pages_Object
    {
        public static object GenerateModel()
        {
            var DataObject = new WebApp_CMS_Pages();
            DataObject.page_id = Guid.NewGuid();
            DataObject.page_title = "";
            DataObject.page_tags = "";
            DataObject.page_permission = "";
            DataObject.page_published = false;
            DataObject.page_hits = 0;
            DataObject.page_templateid = "";
            return DataObject;
        }
    }
}
