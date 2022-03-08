using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwReporteOpFinanza
    {
        public int Codopr { get; set; }
        public int Nrocta { get; set; }
        public byte Tipope { get; set; }
        public int Nroope { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Fchvto { get; set; }
        public double? Mtopenori { get; set; }
        public double? Mtoopecnv { get; set; }
        public string Cliente { get; set; }
        public string Cuenta { get; set; }
        public string Operacion { get; set; }
    }
}
