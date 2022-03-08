using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ProductCodeSet
    {
        public ProductCodeSet()
        {
            DispatchSet = new HashSet<DispatchSet>();
            FuelCodesByStationSet = new HashSet<FuelCodesByStationSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public bool ShowToUser { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ProductCodeClaveProdServ { get; set; }
        public int? ProductCodeFuelType { get; set; }
        public int CatCombustibleProductCode { get; set; }

        public virtual CatCombustibleSet CatCombustibleProductCodeNavigation { get; set; }
        public virtual ClaveProdServSet ProductCodeClaveProdServNavigation { get; set; }
        public virtual FuelTypes ProductCodeFuelTypeNavigation { get; set; }
        public virtual ICollection<DispatchSet> DispatchSet { get; set; }
        public virtual ICollection<FuelCodesByStationSet> FuelCodesByStationSet { get; set; }
    }
}
