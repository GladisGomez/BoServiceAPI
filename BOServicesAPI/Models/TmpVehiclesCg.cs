using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TmpVehiclesCg
    {
        public int Id { get; set; }
        public int CodigoCliente { get; set; }
        public string Plate { get; set; }
        public string Eco { get; set; }
        public int? Tarjeta { get; set; }
        public string Grupo { get; set; }
        public DateTime Created { get; set; }
        public bool UpdateBo { get; set; }
        public bool ChangePlate { get; set; }
    }
}
