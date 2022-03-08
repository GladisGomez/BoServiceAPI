using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class FuelType
    {
        public FuelType()
        {
            BrandModels = new HashSet<BrandModel>();
            ContingencySets = new HashSet<ContingencySet>();
            ContingencyWithoutVehicleSets = new HashSet<ContingencyWithoutVehicleSet>();
            DispatchSets = new HashSet<DispatchSet>();
            FuelSets = new HashSet<FuelSet>();
            HistoryReaders = new HashSet<HistoryReader>();
            HistoryVehiclesSets = new HashSet<HistoryVehiclesSet>();
            Iepssets = new HashSet<Iepsset>();
            ProductCodeSets = new HashSet<ProductCodeSet>();
            Readers = new HashSet<Reader>();
            RulesSets = new HashSet<RulesSet>();
            Vehicles = new HashSet<Vehicle>();
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
        public virtual ICollection<BrandModel> BrandModels { get; set; }
        public virtual ICollection<ContingencySet> ContingencySets { get; set; }
        public virtual ICollection<ContingencyWithoutVehicleSet> ContingencyWithoutVehicleSets { get; set; }
        public virtual ICollection<DispatchSet> DispatchSets { get; set; }
        public virtual ICollection<FuelSet> FuelSets { get; set; }
        public virtual ICollection<HistoryReader> HistoryReaders { get; set; }
        public virtual ICollection<HistoryVehiclesSet> HistoryVehiclesSets { get; set; }
        public virtual ICollection<Iepsset> Iepssets { get; set; }
        public virtual ICollection<ProductCodeSet> ProductCodeSets { get; set; }
        public virtual ICollection<Reader> Readers { get; set; }
        public virtual ICollection<RulesSet> RulesSets { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
