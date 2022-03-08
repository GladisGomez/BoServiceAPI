using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwPhoneCouplingReport
    {
        public string Region { get; set; }
        public string Cedis { get; set; }
        public string Direccion { get; set; }
        public string Clasificacion { get; set; }
        public string Eco { get; set; }
        public string Placa { get; set; }
        public string NoEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Puesto { get; set; }
        public string CedisTimeZoneKey { get; set; }
        public DateTime? DateUtc { get; set; }
        public int? VehicleId { get; set; }
    }
}
