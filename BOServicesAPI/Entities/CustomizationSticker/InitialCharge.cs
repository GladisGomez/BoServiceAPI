using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities.CustomizationSticker
{
    public class InitialCharge
    {
        public string SID { get; set; }
        public string SIDPers { get; set; }
    }

    public class InitialChargeResult
    {
        
        public int Total { get; set; }
        public int Result { get; set; }
    }

}
