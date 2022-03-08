using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwPreciosEstacion
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Type { get; set; }
        public decimal Iesp { get; set; }
        public decimal Price { get; set; }
        public int IdEstacion { get; set; }
    }
}
