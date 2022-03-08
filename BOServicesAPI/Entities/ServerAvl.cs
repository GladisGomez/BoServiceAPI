using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    public class ServerAvl
    {
        public string ServerName { get; set; }
        public int AppId { get; set; }
        public int AviAppId { get; set; }
        public string Url { get; set; }
        public string SessionId { get; set; }
        public string UrlVehicleTracker { get; set; }
        public string urlVehTrI { get; set; }
        public string ServerVehicleTracker { get; set; }
    }
}
