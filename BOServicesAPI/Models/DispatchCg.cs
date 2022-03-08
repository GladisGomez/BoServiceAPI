using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DispatchCg
    {
        public int Id { get; set; }
        public int IdStation { get; set; }
        public int IdVehiculo { get; set; }
        public int PublicId { get; set; }
        public string Placa { get; set; }
        public int IdClient { get; set; }
        public int FolioOperacion { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int IdCombustible { get; set; }
        public int CodigoCombustible { get; set; }
        public string NombreCombustible { get; set; }
        public string Rfcestacion { get; set; }
        public string ClaveEstacion { get; set; }
        public string NombreEstacion { get; set; }
        public decimal Ieps { get; set; }
        public int Tar { get; set; }
        public double Iva { get; set; }
        public decimal Litros { get; set; }
        public decimal Monto { get; set; }
        public decimal PrecioPub { get; set; }
        public string Eco { get; set; }
        public string Descripcion { get; set; }
        public string Grupo { get; set; }
        public decimal Odometro { get; set; }
        public int PumpNumber { get; set; }
        public int? IdBilling { get; set; }
    }
}
