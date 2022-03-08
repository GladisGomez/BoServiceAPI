using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ContingencyWithoutVehicleSet
    {
        public int Id { get; set; }
        public string IdContingency { get; set; }
        public string Plate { get; set; }
        public DateTime DateOperation { get; set; }
        public DateTime TimeOperation { get; set; }
        public double Quantity { get; set; }
        public double Amount { get; set; }
        public bool? Received { get; set; }
        public string PathInvoice { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int ContingencyWithoutVehicleClient { get; set; }
        public int? ContingencyWebContingencyWithoutVehicle1 { get; set; }
        public int ContingencyWithoutVehicleFuelType { get; set; }
        public int ContingencyWithoutVehicleGasStation { get; set; }

        public virtual ContingencyWebSet ContingencyWebContingencyWithoutVehicle1Navigation { get; set; }
        public virtual Clients ContingencyWithoutVehicleClientNavigation { get; set; }
        public virtual FuelTypes ContingencyWithoutVehicleFuelTypeNavigation { get; set; }
        public virtual GasStations ContingencyWithoutVehicleGasStationNavigation { get; set; }
    }
}
