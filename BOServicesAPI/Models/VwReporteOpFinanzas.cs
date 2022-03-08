using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwReporteOpFinanzas
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
