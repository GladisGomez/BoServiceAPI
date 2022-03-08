using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DispatchExternSet2222
    {
        public int Id { get; set; }
        public int IdClientGroup { get; set; }
        public int IdDispatch { get; set; }
        public string FolioTransaction { get; set; }
        public DateTime LastRecord { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public string AplicationName { get; set; }
        public decimal? OdometerResult { get; set; }
        public DateTime? OdometerResultDateUtc { get; set; }
        public DateTime? SearchedInDateUtc { get; set; }
        public int? MinuteToFind { get; set; }
        public string IdStationNumber { get; set; }
        public double? GasstationLatitude { get; set; }
        public double? GasstationLongitude { get; set; }
        public int? VehicleId { get; set; }
        public double? OdoTrackingLatitude { get; set; }
        public double? OdoTrackingLongitude { get; set; }
        public string OdometerFoundInSection { get; set; }
        public string OverSection { get; set; }
        public double? DistanceM { get; set; }
        public decimal? NearestOdometer { get; set; }
        public DateTime? NearestOdometerDateUtc { get; set; }
    }
}
