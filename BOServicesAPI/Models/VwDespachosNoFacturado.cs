using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwDespachosNoFacturado
    {
        public int? Tarjeta { get; set; }
        public string Placa { get; set; }
        public string Economico { get; set; }
        public string Descripcion { get; set; }
        public int? Despacho { get; set; }
        public int? Bomba { get; set; }
        public string Producto { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Monto { get; set; }
        public string Estacion { get; set; }
        public int? CodEstacion { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
    }
}
