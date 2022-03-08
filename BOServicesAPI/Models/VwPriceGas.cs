using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwPriceGas
    {
        public DateTime? Fecha { get; set; }
        public int Codprd { get; set; }
        public decimal? Precios { get; set; }
    }
}
