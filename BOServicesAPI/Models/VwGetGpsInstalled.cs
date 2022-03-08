using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwGetGpsInstalled
    {
        public string Serial { get; set; }
        public string Embarque { get; set; }
        public string Imei { get; set; }
        public DateTime? FechaDeEmbarque { get; set; }
        public DateTime? FechaDeInstalación { get; set; }
        public DateTime? FechaOdometro { get; set; }
        public string Placa { get; set; }
        public string Eco { get; set; }
        public string Clientes { get; set; }
        public string Cedi { get; set; }
        public int NúmCliente { get; set; }
    }
}
