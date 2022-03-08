using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwGpsReport
    {
        public string Placa { get; set; }
        public string NumeroEco { get; set; }
        public int IdClienteGrupo { get; set; }
        public string Cliente { get; set; }
        public int IdCedi { get; set; }
        public string Cedi { get; set; }
        public string UnitId { get; set; }
        public string UnitIdhex { get; set; }
        public DateTime? FechaInstalacion { get; set; }
        public decimal? ValorOdometer { get; set; }
        public DateTime? FechaOdometro { get; set; }
        public string Caja { get; set; }
        public string Imei { get; set; }
        public DateTime? DatePackage { get; set; }
        public DateTime? DateGpsSim { get; set; }
        public string Sim { get; set; }
        public string NumeroTelefono { get; set; }
    }
}
