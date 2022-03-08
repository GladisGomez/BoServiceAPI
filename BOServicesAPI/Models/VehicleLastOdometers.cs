using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VehicleLastOdometers
    {
        public int Id { get; set; }
        public decimal LastOdometer { get; set; }
        public DateTime LastOdometerDate { get; set; }
        public long? LastOdometerDateLong { get; set; }
        public int UserId { get; set; }
        public string UnitIdHex { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? VehicleLastOdometerVehicle { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public double? Lat { get; set; }
        public double? Lon { get; set; }
        public decimal? Speed { get; set; }
        public bool? Ignition { get; set; }
        public double? Heading { get; set; }
    }
}
