using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class GpsOdometerSet
    {
        public int Id { get; set; }
        public decimal OdometerValueBefore { get; set; }
        public decimal OdometerValue { get; set; }
        public DateTime OdometerDate { get; set; }
        public string Comments { get; set; }
        public decimal? DeltaValue { get; set; }
        public DateTime? OdometerDateLocal { get; set; }
        public string UnitIdHex { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? GpsOdometerEmployee { get; set; }
        public int? GpsOdometerVehicle { get; set; }

        public virtual Employees GpsOdometerEmployeeNavigation { get; set; }
        public virtual Vehicles GpsOdometerVehicleNavigation { get; set; }
    }
}
