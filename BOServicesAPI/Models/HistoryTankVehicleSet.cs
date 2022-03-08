using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryTankVehicleSet
    {
        public int Id { get; set; }
        public int? IdTankVeh { get; set; }
        public double CapacityTank { get; set; }
        public string ActionTransac { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? HistoryTankVehicleTankIdentifier { get; set; }
        public int? HistoryTankVehicleVehicle { get; set; }

        public virtual TankIdentifiers HistoryTankVehicleTankIdentifierNavigation { get; set; }
        public virtual Vehicles HistoryTankVehicleVehicleNavigation { get; set; }
    }
}
