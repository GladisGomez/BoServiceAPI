using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class GpsSet
    {
        public GpsSet()
        {
            AccesoriesSet = new HashSet<AccesoriesSet>();
            HistoryImageInstallationSetHistoryImageInstallationGps1Navigation = new HashSet<HistoryImageInstallationSet>();
            HistoryImageInstallationSetHistoryImageInstallationGpsNavigation = new HashSet<HistoryImageInstallationSet>();
            HistorySimgpsSet = new HashSet<HistorySimgpsSet>();
            ImageInstallationSetGpsImageInstallation1Navigation = new HashSet<ImageInstallationSet>();
            ImageInstallationSetGpsImageInstallationNavigation = new HashSet<ImageInstallationSet>();
            SimgpsSet = new HashSet<SimgpsSet>();
        }

        public int Id { get; set; }
        public string UnitId { get; set; }
        public string UnitIdhex { get; set; }
        public string Fw { get; set; }
        public string ParamVersion { get; set; }
        public DateTime? DateInstallation { get; set; }
        public decimal? ValorOdometer { get; set; }
        public DateTime? OdometerDate { get; set; }
        public string Comentarios { get; set; }
        public bool? Verified { get; set; }
        public bool Active { get; set; }
        public string UnitType { get; set; }
        public string Box { get; set; }
        public string Imei { get; set; }
        public DateTime? DatePackage { get; set; }
        public DateTime? DateGpsSim { get; set; }
        public bool? ReportOdometer { get; set; }
        public int? IdClientGate { get; set; }
        public bool SentTelephony { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int GpsEmployee { get; set; }
        public int? GpsEmployee1 { get; set; }
        public int? GpsGpsServer { get; set; }
        public int? GpsVersionGps { get; set; }
        public int? GpsParametersGps { get; set; }
        public int? ProductsGps { get; set; }
        public int? GpsStatus { get; set; }
        public int? VehicleGps { get; set; }

        public virtual Employees GpsEmployee1Navigation { get; set; }
        public virtual Employees GpsEmployeeNavigation { get; set; }
        public virtual GpsServerSet GpsGpsServerNavigation { get; set; }
        public virtual GpsParametersSet GpsParametersGpsNavigation { get; set; }
        public virtual StatusSet GpsStatusNavigation { get; set; }
        public virtual GpsVersionSet GpsVersionGpsNavigation { get; set; }
        public virtual ProductsSet ProductsGpsNavigation { get; set; }
        public virtual Vehicles VehicleGpsNavigation { get; set; }
        public virtual ICollection<AccesoriesSet> AccesoriesSet { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationGps1Navigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationGpsNavigation { get; set; }
        public virtual ICollection<HistorySimgpsSet> HistorySimgpsSet { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetGpsImageInstallation1Navigation { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetGpsImageInstallationNavigation { get; set; }
        public virtual ICollection<SimgpsSet> SimgpsSet { get; set; }
    }
}
