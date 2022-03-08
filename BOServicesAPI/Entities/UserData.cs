using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    public class UserData
    {
        public int id { get; set; }
        public string deviceActivity { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string email { get; set; }
    }
}
