using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TankVehiclesSet
    {
        public TankVehiclesSet()
        {
            AccesoriesSet = new HashSet<AccesoriesSet>();
        }

        public int Id { get; set; }
        public double CapacityTank { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? TankVehiclesTankIdentifier { get; set; }
        public int? VehicleTankVehicles { get; set; }

        public virtual TankIdentifiers TankVehiclesTankIdentifierNavigation { get; set; }
        public virtual Vehicles VehicleTankVehiclesNavigation { get; set; }
        public virtual ICollection<AccesoriesSet> AccesoriesSet { get; set; }
    }
}
