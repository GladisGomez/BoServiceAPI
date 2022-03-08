using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    public class CatalogsDTOS
    {
        public CatalogsDTOS()
        {

        }

        public class AuxBrandModels
        {
            public int Id { get; set; }
            public string ModelName { get; set; }
            public int TanksQuantity { get; set; }
        }

        public class AuxVehicleBrands
        {
            public int Id { get; set; }
            public string Brand { get; set; }
        }

        public class AuxVehicleTypes
        {
            public int Id { get; set; }
            public string Type { get; set; }
        }
        public class AuxCostCenter
        {
            public int Id { get; set; }
            public string CostCenter { get; set; }
        }

        public class AuxVehicleStatus
        {
            public int Id { get; set; }
            public string NameStatus { get; set; }
            public  bool Enable { get; set; }
        }

        public class AuxFuelTypes
        {
            public int Id { get; set; }
            public int Code { get; set; }
            public string Type { get; set; }
            public bool ShowOnSite { get; set; }
            public double Price { get; set; }
            public string CveUnidad { get; set; }
            public string DescriptionUnidad { get; set; }

        }

        public class AuxOdometerUnits
        {
            public int Id { get; set; }
            public string Unit { get; set; }
        }
    }
}
