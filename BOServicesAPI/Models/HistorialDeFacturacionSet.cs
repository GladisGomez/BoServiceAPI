using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistorialDeFacturacionSet
    {
        public int Id { get; set; }
        public int IdClientGroup { get; set; }
        public int IdClient { get; set; }
        public int? IdVehicle { get; set; }
        public int? IdMeter { get; set; }
        public int? IdTag { get; set; }
        public int? IdGps { get; set; }
        public int? IdStation { get; set; }
        public int? IdAntenna { get; set; }
        public int? IdReader { get; set; }
        public int? IdBattery { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public bool? Retrieve { get; set; }
        public bool? IsBilling { get; set; }
        public string StatusDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
