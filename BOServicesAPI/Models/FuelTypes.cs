using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class FuelTypes
    {
        public FuelTypes()
        {
            BrandModels = new HashSet<BrandModels>();
            ContingencySet = new HashSet<ContingencySet>();
            ContingencyWithoutVehicleSet = new HashSet<ContingencyWithoutVehicleSet>();
            DispatchSet = new HashSet<DispatchSet>();
            FuelSet = new HashSet<FuelSet>();
            HistoryReaders = new HashSet<HistoryReaders>();
            HistoryVehiclesSet = new HashSet<HistoryVehiclesSet>();
            Iepsset = new HashSet<Iepsset>();
            ProductCodeSet = new HashSet<ProductCodeSet>();
            Readers = new HashSet<Readers>();
            RulesSet = new HashSet<RulesSet>();
            Vehicles = new HashSet<Vehicles>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public int Code { get; set; }
        public string Type { get; set; }
        public bool ShowOnSite { get; set; }
        public decimal? Price { get; set; }
        public string CveUnidad { get; set; }
        public string DescriptionUnidad { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int? FuelTypeClaveProdServ { get; set; }

        public virtual ClaveProdServSet FuelTypeClaveProdServNavigation { get; set; }
        public virtual ICollection<BrandModels> BrandModels { get; set; }
        public virtual ICollection<ContingencySet> ContingencySet { get; set; }
        public virtual ICollection<ContingencyWithoutVehicleSet> ContingencyWithoutVehicleSet { get; set; }
        public virtual ICollection<DispatchSet> DispatchSet { get; set; }
        public virtual ICollection<FuelSet> FuelSet { get; set; }
        public virtual ICollection<HistoryReaders> HistoryReaders { get; set; }
        public virtual ICollection<HistoryVehiclesSet> HistoryVehiclesSet { get; set; }
        public virtual ICollection<Iepsset> Iepsset { get; set; }
        public virtual ICollection<ProductCodeSet> ProductCodeSet { get; set; }
        public virtual ICollection<Readers> Readers { get; set; }
        public virtual ICollection<RulesSet> RulesSet { get; set; }
        public virtual ICollection<Vehicles> Vehicles { get; set; }
    }
}
