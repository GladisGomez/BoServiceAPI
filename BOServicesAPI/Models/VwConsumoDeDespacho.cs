using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwConsumoDeDespacho
    {
        public DateTime? Fecha { get; set; }
        public string Hora { get; set; }
        public string Estacion { get; set; }
        public int? Despacho { get; set; }
        public int? Posicion { get; set; }
        public string Producto { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Importe { get; set; }
        public string Cliente { get; set; }
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string Placa { get; set; }
        public string Datos { get; set; }
        public string NameCenter { get; set; }
    }
}
