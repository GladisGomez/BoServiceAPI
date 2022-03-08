using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class VehicleBrand
    {
        public VehicleBrand()
        {
            BrandModels = new HashSet<BrandModel>();
            HistoryVehiclesSets = new HashSet<HistoryVehiclesSet>();
            Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Brand { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<BrandModel> BrandModels { get; set; }
        public virtual ICollection<HistoryVehiclesSet> HistoryVehiclesSets { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
