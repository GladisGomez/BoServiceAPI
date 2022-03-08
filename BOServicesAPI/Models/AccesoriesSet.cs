using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AccesoriesSet
    {
        public AccesoriesSet()
        {
            HistoryImageInstallationSetHistoryImageInstallationAccesories1Navigation = new HashSet<HistoryImageInstallationSet>();
            HistoryImageInstallationSetHistoryImageInstallationAccesoriesNavigation = new HashSet<HistoryImageInstallationSet>();
            ImageInstallationSetAccesoriesImageInstallation1Navigation = new HashSet<ImageInstallationSet>();
            ImageInstallationSetAccesoriesImageInstallationNavigation = new HashSet<ImageInstallationSet>();
        }

        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ActivationDateTime { get; set; }
        public bool Active { get; set; }
        public DateTime ServiceDataTime { get; set; }
        public string FolioTheService { get; set; }
        public string Comments { get; set; }
        public string FisicalLocation { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? AccesoriesGasStation { get; set; }
        public int? AccesoriesGps { get; set; }
        public int? ProductsAccesories { get; set; }
        public int? AccesoriesReplacementReason { get; set; }
        public int? AccesoriesTankVehicles { get; set; }
        public int? TestingProductsAccesories { get; set; }
        public int? AccesoriesTreatmentType { get; set; }
        public int? AccesoriesVehicle { get; set; }

        public virtual GasStations AccesoriesGasStationNavigation { get; set; }
        public virtual GpsSet AccesoriesGpsNavigation { get; set; }
        public virtual ReplacementReasons AccesoriesReplacementReasonNavigation { get; set; }
        public virtual TankVehiclesSet AccesoriesTankVehiclesNavigation { get; set; }
        public virtual TreatmentTypes AccesoriesTreatmentTypeNavigation { get; set; }
        public virtual Vehicles AccesoriesVehicleNavigation { get; set; }
        public virtual ProductsSet ProductsAccesoriesNavigation { get; set; }
        public virtual TestingProductsSet TestingProductsAccesoriesNavigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationAccesories1Navigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationAccesoriesNavigation { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetAccesoriesImageInstallation1Navigation { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetAccesoriesImageInstallationNavigation { get; set; }
    }
}
