using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Media2A.WebApp.Models
{
    public class Extension
    {
        string webappId { get; set; }
        string id { get; set; }
        string name { get; set; }
        string desc { get; set; }
        string[] dependencies { get; set; }
        string updateURL { get; set; }
        string changelog { get; set; }
        string documentation { get; set; }
        string licence { get; set; }

    }
}
