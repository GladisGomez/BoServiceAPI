using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ImageInstallationSet
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public byte[] ImageInstaller { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int? AccesoriesImageInstallation { get; set; }
        public int? AccesoriesImageInstallation1 { get; set; }
        public int? AntennaImageInstallation { get; set; }
        public int? BatteryImageInstallation { get; set; }
        public int? ImageInstallationBattery { get; set; }
        public int? ChangeRequestPlateImageInstallation { get; set; }
        public int? GasStationExtraActivitiesImageInstallation { get; set; }
        public int? ImageInstallationGasStation { get; set; }
        public int? GpsImageInstallation { get; set; }
        public int? GpsImageInstallation1 { get; set; }
        public int? MeterImageInstallation { get; set; }
        public int? MeterImageInstallation1 { get; set; }
        public int? ReaderImageInstallation { get; set; }
        public int? TagImageTag { get; set; }
        public int? TagImageTag1 { get; set; }
        public int? ImageInstallationVehicle { get; set; }

        public virtual AccesoriesSet AccesoriesImageInstallation1Navigation { get; set; }
        public virtual AccesoriesSet AccesoriesImageInstallationNavigation { get; set; }
        public virtual Antennas AntennaImageInstallationNavigation { get; set; }
        public virtual BatterySet BatteryImageInstallationNavigation { get; set; }
        public virtual ChangeRequestPlateSet ChangeRequestPlateImageInstallationNavigation { get; set; }
        public virtual GasStationExtraActivitiesSet GasStationExtraActivitiesImageInstallationNavigation { get; set; }
        public virtual GpsSet GpsImageInstallation1Navigation { get; set; }
        public virtual GpsSet GpsImageInstallationNavigation { get; set; }
        public virtual BatterySet ImageInstallationBatteryNavigation { get; set; }
        public virtual GasStations ImageInstallationGasStationNavigation { get; set; }
        public virtual Vehicles ImageInstallationVehicleNavigation { get; set; }
        public virtual Meters MeterImageInstallation1Navigation { get; set; }
        public virtual Meters MeterImageInstallationNavigation { get; set; }
        public virtual Readers ReaderImageInstallationNavigation { get; set; }
        public virtual Tags TagImageTag1Navigation { get; set; }
        public virtual Tags TagImageTagNavigation { get; set; }
    }
}
