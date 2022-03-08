using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryVehiclesSet
    {
        public int Id { get; set; }
        public int? IdVehicle { get; set; }
        public string Plate { get; set; }
        public string Vin { get; set; }
        public string EcoNumber { get; set; }
        public int? PublicId { get; set; }
        public int? YearModel { get; set; }
        public bool? Verified { get; set; }
        public string Comments { get; set; }
        public bool? Service { get; set; }
        public string HelpNameEmployee { get; set; }
        public string HelpComentsTicket { get; set; }
        public bool? ReportOdometer { get; set; }
        public bool? WithTempValues { get; set; }
        public DateTime? WithTempValuesDate { get; set; }
        public DateTime? ExtraordinaryDatetime { get; set; }
        public bool? TotvsUpdated { get; set; }
        public bool? ChangeTotvs { get; set; }
        public string SearchProperty1 { get; set; }
        public string SearchProperty2 { get; set; }
        public DateTime? SingleEventDatetimeStart { get; set; }
        public DateTime? SingleEventDatetimeEnd { get; set; }
        public int? SingleEventMaxCost { get; set; }
        public int? SingleEventMaxVolume { get; set; }
        public string SingleEventFuelType { get; set; }
        public string NumTransactionExternal { get; set; }
        public string ActionTransac { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? HistoryVehiclesBrandModel { get; set; }
        public int? HistoryVehiclesClient { get; set; }
        public int? HistoryVehiclesCostCenter { get; set; }
        public int? HistoryVehiclesFuelType { get; set; }
        public int? HistoryVehiclesRules { get; set; }
        public int? HistoryVehiclesStatus { get; set; }
        public int? HistoryVehiclesVehicleBrand { get; set; }

        public virtual BrandModels HistoryVehiclesBrandModelNavigation { get; set; }
        public virtual Clients HistoryVehiclesClientNavigation { get; set; }
        public virtual CostCenterSet HistoryVehiclesCostCenterNavigation { get; set; }
        public virtual FuelTypes HistoryVehiclesFuelTypeNavigation { get; set; }
        public virtual RulesSet HistoryVehiclesRulesNavigation { get; set; }
        public virtual StatusSet HistoryVehiclesStatusNavigation { get; set; }
        public virtual VehicleBrands HistoryVehiclesVehicleBrandNavigation { get; set; }
    }
}
