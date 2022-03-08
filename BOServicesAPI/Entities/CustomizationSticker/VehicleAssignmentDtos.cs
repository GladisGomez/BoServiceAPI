using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    public class VehicleAssignmentDtos: UidDtos
    {
        [Required]
        public int idVehicle { get; set; }        
        
    }

    public class UidDtos
    {
        [Required]
        public string UID { get; set; }

        [Required]
        public int IdUserWebSet { get; set; }

    }


}
