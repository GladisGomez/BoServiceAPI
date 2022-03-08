using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class FuelSet
    {
        public FuelSet()
        {
            PriceFuelSet = new HashSet<PriceFuelSet>();
        }

        public int Id { get; set; }
        public int? MaxLimitVolume { get; set; }
        public int? MaxLimitCost { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? FuelFuelType { get; set; }
        public int FuelGasStation { get; set; }

        public virtual FuelTypes FuelFuelTypeNavigation { get; set; }
        public virtual GasStations FuelGasStationNavigation { get; set; }
        public virtual ICollection<PriceFuelSet> PriceFuelSet { get; set; }
    }
}
