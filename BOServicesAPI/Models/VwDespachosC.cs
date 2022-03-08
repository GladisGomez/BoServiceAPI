using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwDespachosC
    {
        public int? NumDespacho { get; set; }
        public string Estacion { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Producto { get; set; }
        public string Estatus { get; set; }
        public string CodCliente { get; set; }
        public string Placa { get; set; }
        public string Economico { get; set; }
        public string Color { get; set; }
        public int CodEstacion { get; set; }
    }
}
