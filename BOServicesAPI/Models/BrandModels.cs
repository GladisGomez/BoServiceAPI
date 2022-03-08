using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class BrandModels
    {
        public BrandModels()
        {
            HistoryVehiclesSet = new HashSet<HistoryVehiclesSet>();
            Vehicles = new HashSet<Vehicles>();
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

        public virtual VehicleBrands BrandModelVehicleBrandNavigation { get; set; }
        public virtual FuelTypes BrandModelsFuelTypesNavigation { get; set; }
        public virtual OdometerUnits BrandModelsOdometerUnitsNavigation { get; set; }
        public virtual VehicleTypes BrandModelsVehicleTypesNavigation { get; set; }
        public virtual ICollection<HistoryVehiclesSet> HistoryVehiclesSet { get; set; }
        public virtual ICollection<Vehicles> Vehicles { get; set; }
    }
}
