using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwReportePagoEdc
    {
        public int IdEdc { get; set; }
        public int Folio { get; set; }
        public int IdclientGroup { get; set; }
        public string Cliente { get; set; }
        public int IdDatosFiscales { get; set; }
        public string Rfc { get; set; }
        public int Idbilling { get; set; }
        public DateTime FechaPeriodoInicio { get; set; }
        public DateTime FechaPeriodaFin { get; set; }
        public DateTime FechaTimbrado { get; set; }
        public decimal? SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public decimal Total { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? EffectiveDate { get; set; }
    }
}
