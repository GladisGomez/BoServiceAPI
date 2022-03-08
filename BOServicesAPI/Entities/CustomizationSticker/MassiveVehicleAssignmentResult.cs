using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities.CustomizationSticker
{
    public class MassiveVehicleAssignmentResult : Result
    {

        public string plates { get; set; }       
        
        public string UID { get; set; }

    }

    public class MassiveVehicleAssignmentDtos: MassiveVehicleAssignmentResult
    {
        public int idVehicle { get; set; }
    }
}
