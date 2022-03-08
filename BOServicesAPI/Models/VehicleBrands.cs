using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VehicleBrands
    {
        public VehicleBrands()
        {
            BrandModels = new HashSet<BrandModels>();
            HistoryVehiclesSet = new HashSet<HistoryVehiclesSet>();
            Vehicles = new HashSet<Vehicles>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Brand { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<BrandModels> BrandModels { get; set; }
        public virtual ICollection<HistoryVehiclesSet> HistoryVehiclesSet { get; set; }
        public virtual ICollection<Vehicles> Vehicles { get; set; }
    }
}
