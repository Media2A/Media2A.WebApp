using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media2A.WebApp.DatabaseModels
{
    public class Database
    {
        public string DatabaseHost { get; set; }
        public string DatabaseUsername { get; set; }
        public string DatabasePassword { get; set; }
        public string DatabaseSchema { get; set; }
    }
     public class Database_Object
    {
        public static object GenerateModel()
        {
            var DataObject = new Database();
            DataObject.DatabaseHost = "";
            DataObject.DatabaseUsername = "";
            DataObject.DatabasePassword = "";
            DataObject.DatabaseSchema = "";
            return DataObject;
        }
    }
}
