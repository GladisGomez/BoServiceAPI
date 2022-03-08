using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwEstadosDeCuentum
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
