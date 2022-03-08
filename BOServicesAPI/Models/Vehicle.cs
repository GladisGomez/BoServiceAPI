using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            AccesoriesSets = new HashSet<AccesoriesSet>();
            CallRecordSets = new HashSet<CallRecordSet>();
            CatDeviceSets = new HashSet<CatDeviceSet>();
            ChangeRequestPlateSets = new HashSet<ChangeRequestPlateSet>();
            ContingencySets = new HashSet<ContingencySet>();
            ControlPrintTargetSets = new HashSet<ControlPrintTargetSet>();
            CustomFieldsToVehiclesSets = new HashSet<CustomFieldsToVehiclesSet>();
            DispatchSets = new HashSet<DispatchSet>();
            DriversVehiclesSets = new HashSet<DriversVehiclesSet>();
            GpsOdometerSets = new HashSet<GpsOdometerSet>();
            GpsSets = new HashSet<GpsSet>();
            HistoryGpsSets = new HashSet<HistoryGpsSet>();
            HistoryImageInstallationSets = new HashSet<HistoryImageInstallationSet>();
            HistoryMetersSets = new HashSet<HistoryMetersSet>();
            HistoryTags = new HashSet<HistoryTag>();
            HistoryTankVehicleSets = new HashSet<HistoryTankVehicleSet>();
            ImageInstallationSets = new HashSet<ImageInstallationSet>();
            MalfunctionReports = new HashSet<MalfunctionReport>();
            Meters = new HashSet<Meter>();
            Tags = new HashSet<Tag>();
            TankVehiclesSets = new HashSet<TankVehiclesSet>();
            TicketEventsSets = new HashSet<TicketEventsSet>();
            TicketSets = new HashSet<TicketSet>();
            VehiclePhoneCouplingSets = new HashSet<VehiclePhoneCouplingSet>();
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
        public virtual BrandModel VehicleBrandModelNavigation { get; set; }
        public virtual Client VehicleClientNavigation { get; set; }
        public virtual FuelType VehicleFuelTypeNavigation { get; set; }
        public virtual StatusSet VehicleStatusNavigation { get; set; }
        public virtual VehicleBrand VehicleVehicleBrandNavigation { get; set; }
        public virtual ICollection<AccesoriesSet> AccesoriesSets { get; set; }
        public virtual ICollection<CallRecordSet> CallRecordSets { get; set; }
        public virtual ICollection<CatDeviceSet> CatDeviceSets { get; set; }
        public virtual ICollection<ChangeRequestPlateSet> ChangeRequestPlateSets { get; set; }
        public virtual ICollection<ContingencySet> ContingencySets { get; set; }
        public virtual ICollection<ControlPrintTargetSet> ControlPrintTargetSets { get; set; }
        public virtual ICollection<CustomFieldsToVehiclesSet> CustomFieldsToVehiclesSets { get; set; }
        public virtual ICollection<DispatchSet> DispatchSets { get; set; }
        public virtual ICollection<DriversVehiclesSet> DriversVehiclesSets { get; set; }
        public virtual ICollection<GpsOdometerSet> GpsOdometerSets { get; set; }
        public virtual ICollection<GpsSet> GpsSets { get; set; }
        public virtual ICollection<HistoryGpsSet> HistoryGpsSets { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSets { get; set; }
        public virtual ICollection<HistoryMetersSet> HistoryMetersSets { get; set; }
        public virtual ICollection<HistoryTag> HistoryTags { get; set; }
        public virtual ICollection<HistoryTankVehicleSet> HistoryTankVehicleSets { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSets { get; set; }
        public virtual ICollection<MalfunctionReport> MalfunctionReports { get; set; }
        public virtual ICollection<Meter> Meters { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<TankVehiclesSet> TankVehiclesSets { get; set; }
        public virtual ICollection<TicketEventsSet> TicketEventsSets { get; set; }
        public virtual ICollection<TicketSet> TicketSets { get; set; }
        public virtual ICollection<VehiclePhoneCouplingSet> VehiclePhoneCouplingSets { get; set; }
    }
}
