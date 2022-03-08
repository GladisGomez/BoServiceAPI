using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwEstadosDeCuenta
    {
        public int Numero { get; set; }
        public int? Codigo { get; set; }
        public string Cliente { get; set; }
        public DateTime? Fechadesde { get; set; }
        public DateTime? Fechahasta { get; set; }
        public decimal? Saldoinicial { get; set; }
        public decimal? Despachos { get; set; }
        public double? Cargos { get; set; }
        public double? Iva { get; set; }
        public decimal? Combustible { get; set; }
        public decimal? Saldofinal { get; set; }
    }
}
