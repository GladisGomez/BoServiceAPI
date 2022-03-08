using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class BrandModel
    {
        public BrandModel()
        {
            HistoryVehiclesSets = new HashSet<HistoryVehiclesSet>();
            Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string ModelName { get; set; }
        public int TanksQuantity { get; set; }
        public decimal DefaultEstimatedCons { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int BrandModelVehicleBrand { get; set; }
        public int BrandModelsFuelTypes { get; set; }
        public int BrandModelsOdometerUnits { get; set; }
        public int BrandModelsVehicleTypes { get; set; }

        public virtual VehicleBrand BrandModelVehicleBrandNavigation { get; set; }
        public virtual FuelType BrandModelsFuelTypesNavigation { get; set; }
        public virtual OdometerUnit BrandModelsOdometerUnitsNavigation { get; set; }
        public virtual VehicleType BrandModelsVehicleTypesNavigation { get; set; }
        public virtual ICollection<HistoryVehiclesSet> HistoryVehiclesSets { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
