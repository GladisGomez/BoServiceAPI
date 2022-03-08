using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class Meter
    {
        public Meter()
        {
            HistoryImageInstallationSetHistoryImageInstallationMeter1Navigations = new HashSet<HistoryImageInstallationSet>();
            HistoryImageInstallationSetHistoryImageInstallationMeterNavigations = new HashSet<HistoryImageInstallationSet>();
            ImageInstallationSetMeterImageInstallation1Navigations = new HashSet<ImageInstallationSet>();
            ImageInstallationSetMeterImageInstallationNavigations = new HashSet<ImageInstallationSet>();
            RevisionMeterSets = new HashSet<RevisionMeterSet>();
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

        public virtual Employee MeterEmployeeNavigation { get; set; }
        public virtual MeterType MeterMeterTypeNavigation { get; set; }
        public virtual ReplacementReason MeterReplacementReasonNavigation { get; set; }
        public virtual TreatmentType MeterTreatmentTypeNavigation { get; set; }
        public virtual ProductsSet ProductsMeterNavigation { get; set; }
        public virtual Vehicle VehicleMeterNavigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationMeter1Navigations { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationMeterNavigations { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetMeterImageInstallation1Navigations { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetMeterImageInstallationNavigations { get; set; }
        public virtual ICollection<RevisionMeterSet> RevisionMeterSets { get; set; }
    }
}
