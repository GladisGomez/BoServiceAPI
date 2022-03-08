using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwDespachos
    {
        public int Tarjeta { get; set; }
        public string Placa { get; set; }
        public string Descripcion { get; set; }
        public string Grupo { get; set; }
        public string EstControlGas { get; set; }
        public string Estacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int? Despacho { get; set; }
        public int? Bomba { get; set; }
        public string Producto { get; set; }
        public decimal? Litros { get; set; }
        public decimal? Monto { get; set; }
        public string Flota { get; set; }
        public decimal? Odometro { get; set; }
        public int CodCli { get; set; }
        public string NumberStation { get; set; }
        public string Eco { get; set; }
    }
}
