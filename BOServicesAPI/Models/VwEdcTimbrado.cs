using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwEdcTimbrado
    {
        public int Id { get; set; }
        public string OficialName { get; set; }
        public int IdEdc { get; set; }
        public bool Cancelada { get; set; }
        public int TimbroCorrecto { get; set; }
        public string Estatus { get; set; }
        public int? Folio { get; set; }
        public DateTime FechaPeriodoInicio { get; set; }
        public DateTime FechaPeriodaFin { get; set; }
        public DateTime FechaTimbrado { get; set; }
        public decimal Total { get; set; }
        public string Rfc { get; set; }
        public decimal? SaldoInicial { get; set; }
        public decimal SaldoFinal { get; set; }
        public decimal? Depositos { get; set; }
    }
}
