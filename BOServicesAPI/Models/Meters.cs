using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Meters
    {
        public Meters()
        {
            HistoryImageInstallationSetHistoryImageInstallationMeter1Navigation = new HashSet<HistoryImageInstallationSet>();
            HistoryImageInstallationSetHistoryImageInstallationMeterNavigation = new HashSet<HistoryImageInstallationSet>();
            ImageInstallationSetMeterImageInstallation1Navigation = new HashSet<ImageInstallationSet>();
            ImageInstallationSetMeterImageInstallationNavigation = new HashSet<ImageInstallationSet>();
            RevisionMeterSet = new HashSet<RevisionMeterSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Serial { get; set; }
        public string FolioTheService { get; set; }
        public string Connector { get; set; }
        public DateTime ServiceDataTime { get; set; }
        public bool Active { get; set; }
        public DateTime ActivationDateTime { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int MeterEmployee { get; set; }
        public int MeterMeterType { get; set; }
        public int? ProductsMeter { get; set; }
        public int? MeterReplacementReason { get; set; }
        public int MeterTreatmentType { get; set; }
        public int? VehicleMeter { get; set; }

        public virtual Employees MeterEmployeeNavigation { get; set; }
        public virtual MeterTypes MeterMeterTypeNavigation { get; set; }
        public virtual ReplacementReasons MeterReplacementReasonNavigation { get; set; }
        public virtual TreatmentTypes MeterTreatmentTypeNavigation { get; set; }
        public virtual ProductsSet ProductsMeterNavigation { get; set; }
        public virtual Vehicles VehicleMeterNavigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationMeter1Navigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationMeterNavigation { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetMeterImageInstallation1Navigation { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetMeterImageInstallationNavigation { get; set; }
        public virtual ICollection<RevisionMeterSet> RevisionMeterSet { get; set; }
    }
}
