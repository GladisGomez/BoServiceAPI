using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwGetVehiclesCg
    {
        public int IdClient { get; set; }
        public string Plate { get; set; }
        public string Nroeco { get; set; }
        public int NrovehCg { get; set; }
    }
}
