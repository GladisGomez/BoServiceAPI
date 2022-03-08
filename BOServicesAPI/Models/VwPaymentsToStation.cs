using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwPaymentsToStation
    {
        public string NombreEstacion { get; set; }
        public string NumeroEstacion { get; set; }
        public string NombreWebAccess { get; set; }
        public string Rfc { get; set; }
        public decimal Importe { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaPeriodoInicio { get; set; }
        public DateTime FechaPeriodaFin { get; set; }
        public int Edefacturado { get; set; }
        public decimal? PorcentajeComision { get; set; }
        public decimal? ImporteComision { get; set; }
        public decimal? IvaComision { get; set; }
        public decimal? TotalComision { get; set; }
        public decimal? TotalaPagar { get; set; }
        public int IdStation { get; set; }
    }
}
