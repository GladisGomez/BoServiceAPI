using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Vehicles
    {
        public Vehicles()
        {
            AccesoriesSet = new HashSet<AccesoriesSet>();
            CallRecordSet = new HashSet<CallRecordSet>();
            CatDeviceSet = new HashSet<CatDeviceSet>();
            ChangeRequestPlateSet = new HashSet<ChangeRequestPlateSet>();
            ContingencySet = new HashSet<ContingencySet>();
            ControlPrintTargetSet = new HashSet<ControlPrintTargetSet>();
            CustomFieldsToVehiclesSet = new HashSet<CustomFieldsToVehiclesSet>();
            DispatchSet = new HashSet<DispatchSet>();
            DriversVehiclesSet = new HashSet<DriversVehiclesSet>();
            GpsOdometerSet = new HashSet<GpsOdometerSet>();
            GpsSet = new HashSet<GpsSet>();
            HistoryGpsSet = new HashSet<HistoryGpsSet>();
            HistoryImageInstallationSet = new HashSet<HistoryImageInstallationSet>();
            HistoryMetersSet = new HashSet<HistoryMetersSet>();
            HistoryTags = new HashSet<HistoryTags>();
            HistoryTankVehicleSet = new HashSet<HistoryTankVehicleSet>();
            ImageInstallationSet = new HashSet<ImageInstallationSet>();
            MalfunctionReports = new HashSet<MalfunctionReports>();
            Meters = new HashSet<Meters>();
            Tags = new HashSet<Tags>();
            TankVehiclesSet = new HashSet<TankVehiclesSet>();
            TicketEventsSet = new HashSet<TicketEventsSet>();
            TicketSet = new HashSet<TicketSet>();
            VehiclePhoneCouplingSet = new HashSet<VehiclePhoneCouplingSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Plate { get; set; }
        public string Vin { get; set; }
        public string EcoNumber { get; set; }
        public int PublicId { get; set; }
        public int YearModel { get; set; }
        public bool? Verified { get; set; }
        public string Comments { get; set; }
        public bool? Service { get; set; }
        public string HelpNameEmployee { get; set; }
        public string HelpComentsTicket { get; set; }
        public bool? ReportOdometer { get; set; }
        public bool? WithTempValues { get; set; }
        public DateTime? WithTempValuesDate { get; set; }
        public DateTime? ExtraordinaryDatetime { get; set; }
        public bool TotvsUpdated { get; set; }
        public bool ChangeTotvs { get; set; }
        public string SearchProperty1 { get; set; }
        public string SearchProperty2 { get; set; }
        public DateTime? SingleEventDatetimeStart { get; set; }
        public DateTime? SingleEventDatetimeEnd { get; set; }
        public int? SingleEventMaxCost { get; set; }
        public int? SingleEventMaxVolume { get; set; }
        public int? SingleEventFuelType { get; set; }
        public string NumTransactionExternal { get; set; }
        public int? IdClientGate { get; set; }
        public decimal? EstimatedFuelCons { get; set; }
        public int? IsParent { get; set; }
        public bool IsCloned { get; set; }
        public bool CancelEvent { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int? AppointmentServiceVehicle { get; set; }
        public int VehicleBrandModel { get; set; }
        public int VehicleClient { get; set; }
        public int? CostCenterVehicle { get; set; }
        public int? VehicleFuelType { get; set; }
        public int? RulesVehicle { get; set; }
        public int VehicleStatus { get; set; }
        public int VehicleVehicleBrand { get; set; }

        public virtual AppointmentServiceSet AppointmentServiceVehicleNavigation { get; set; }
        public virtual CostCenterSet CostCenterVehicleNavigation { get; set; }
        public virtual RulesSet RulesVehicleNavigation { get; set; }
        public virtual BrandModels VehicleBrandModelNavigation { get; set; }
        public virtual Clients VehicleClientNavigation { get; set; }
        public virtual FuelTypes VehicleFuelTypeNavigation { get; set; }
        public virtual StatusSet VehicleStatusNavigation { get; set; }
        public virtual VehicleBrands VehicleVehicleBrandNavigation { get; set; }
        public virtual ICollection<AccesoriesSet> AccesoriesSet { get; set; }
        public virtual ICollection<CallRecordSet> CallRecordSet { get; set; }
        public virtual ICollection<CatDeviceSet> CatDeviceSet { get; set; }
        public virtual ICollection<ChangeRequestPlateSet> ChangeRequestPlateSet { get; set; }
        public virtual ICollection<ContingencySet> ContingencySet { get; set; }
        public virtual ICollection<ControlPrintTargetSet> ControlPrintTargetSet { get; set; }
        public virtual ICollection<CustomFieldsToVehiclesSet> CustomFieldsToVehiclesSet { get; set; }
        public virtual ICollection<DispatchSet> DispatchSet { get; set; }
        public virtual ICollection<DriversVehiclesSet> DriversVehiclesSet { get; set; }
        public virtual ICollection<GpsOdometerSet> GpsOdometerSet { get; set; }
        public virtual ICollection<GpsSet> GpsSet { get; set; }
        public virtual ICollection<HistoryGpsSet> HistoryGpsSet { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSet { get; set; }
        public virtual ICollection<HistoryMetersSet> HistoryMetersSet { get; set; }
        public virtual ICollection<HistoryTags> HistoryTags { get; set; }
        public virtual ICollection<HistoryTankVehicleSet> HistoryTankVehicleSet { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSet { get; set; }
        public virtual ICollection<MalfunctionReports> MalfunctionReports { get; set; }
        public virtual ICollection<Meters> Meters { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
        public virtual ICollection<TankVehiclesSet> TankVehiclesSet { get; set; }
        public virtual ICollection<TicketEventsSet> TicketEventsSet { get; set; }
        public virtual ICollection<TicketSet> TicketSet { get; set; }
        public virtual ICollection<VehiclePhoneCouplingSet> VehiclePhoneCouplingSet { get; set; }
    }
}
