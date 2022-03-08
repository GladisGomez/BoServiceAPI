using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryImageInstallationSet
    {
        public int Id { get; set; }
        public int? IdImageInst { get; set; }
        public string Comments { get; set; }
        public string ActionTransac { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? HistoryImageInstallationAccesories { get; set; }
        public int? HistoryImageInstallationAccesories1 { get; set; }
        public int? HistoryImageInstallationAntenna { get; set; }
        public int? HistoryImageInstallationBattery { get; set; }
        public int? HistoryImageInstallationBattery1 { get; set; }
        public int? HistoryImageInstallationChangeRequestPlate { get; set; }
        public int? HistoryImageInstallationGasStationExtraActivities { get; set; }
        public int? HistoryImageInstallationGasStation { get; set; }
        public int? HistoryImageInstallationGps { get; set; }
        public int? HistoryImageInstallationGps1 { get; set; }
        public int? HistoryImageInstallationMeter { get; set; }
        public int? HistoryImageInstallationMeter1 { get; set; }
        public int? HistoryImageInstallationReader { get; set; }
        public int? HistoryImageInstallationTag { get; set; }
        public int? HistoryImageInstallationTag1 { get; set; }
        public int? HistoryImageInstallationVehicle { get; set; }

        public virtual AccesoriesSet HistoryImageInstallationAccesories1Navigation { get; set; }
        public virtual AccesoriesSet HistoryImageInstallationAccesoriesNavigation { get; set; }
        public virtual Antennas HistoryImageInstallationAntennaNavigation { get; set; }
        public virtual BatterySet HistoryImageInstallationBattery1Navigation { get; set; }
        public virtual BatterySet HistoryImageInstallationBatteryNavigation { get; set; }
        public virtual ChangeRequestPlateSet HistoryImageInstallationChangeRequestPlateNavigation { get; set; }
        public virtual GasStationExtraActivitiesSet HistoryImageInstallationGasStationExtraActivitiesNavigation { get; set; }
        public virtual GasStations HistoryImageInstallationGasStationNavigation { get; set; }
        public virtual GpsSet HistoryImageInstallationGps1Navigation { get; set; }
        public virtual GpsSet HistoryImageInstallationGpsNavigation { get; set; }
        public virtual Meters HistoryImageInstallationMeter1Navigation { get; set; }
        public virtual Meters HistoryImageInstallationMeterNavigation { get; set; }
        public virtual Readers HistoryImageInstallationReaderNavigation { get; set; }
        public virtual Tags HistoryImageInstallationTag1Navigation { get; set; }
        public virtual Tags HistoryImageInstallationTagNavigation { get; set; }
        public virtual Vehicles HistoryImageInstallationVehicleNavigation { get; set; }
    }
}
