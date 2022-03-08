using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class Tag
    {
        public Tag()
        {
            ControlPrintTargetSets = new HashSet<ControlPrintTargetSet>();
            HistoryImageInstallationSetHistoryImageInstallationTag1Navigations = new HashSet<HistoryImageInstallationSet>();
            HistoryImageInstallationSetHistoryImageInstallationTagNavigations = new HashSet<HistoryImageInstallationSet>();
            ImageInstallationSetTagImageTag1Navigations = new HashSet<ImageInstallationSet>();
            ImageInstallationSetTagImageTagNavigations = new HashSet<ImageInstallationSet>();
            NipsSets = new HashSet<NipsSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Sid { get; set; }
        public string Uid { get; set; }
        public string FolioTheService { get; set; }
        public bool WithNth { get; set; }
        public bool Active { get; set; }
        public DateTime ServiceDataTime { get; set; }
        public string Comments { get; set; }
        public DateTime? ActivationDateTime { get; set; }
        public int? CapacidadTanque { get; set; }
        public string SerialMeter { get; set; }
        public DateTime? ReviewDate { get; set; }
        public int NipWrongCount { get; set; }
        public string ESid { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int TagEmployee { get; set; }
        public int? GasStationTag { get; set; }
        public int? ProductsTag { get; set; }
        public int? TagReplacementReason { get; set; }
        public int TagTagType { get; set; }
        public int? TagTankIdentifier { get; set; }
        public int? TagTicket { get; set; }
        public int TagTreatmentType { get; set; }
        public int? TagVehicle { get; set; }

        public virtual GasStation GasStationTagNavigation { get; set; }
        public virtual ProductsSet ProductsTagNavigation { get; set; }
        public virtual Employee TagEmployeeNavigation { get; set; }
        public virtual ReplacementReason TagReplacementReasonNavigation { get; set; }
        public virtual TagType TagTagTypeNavigation { get; set; }
        public virtual TankIdentifier TagTankIdentifierNavigation { get; set; }
        public virtual TicketSet TagTicketNavigation { get; set; }
        public virtual TreatmentType TagTreatmentTypeNavigation { get; set; }
        public virtual Vehicle TagVehicleNavigation { get; set; }
        public virtual ICollection<ControlPrintTargetSet> ControlPrintTargetSets { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationTag1Navigations { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationTagNavigations { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetTagImageTag1Navigations { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetTagImageTagNavigations { get; set; }
        public virtual ICollection<NipsSet> NipsSets { get; set; }
    }
}
