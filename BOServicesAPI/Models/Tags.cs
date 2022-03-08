﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Tags
    {
        public Tags()
        {
            ControlPrintTargetSet = new HashSet<ControlPrintTargetSet>();
            CustomStickers = new HashSet<CustomStickers>();
            CustomStickersTrakings = new HashSet<CustomStickersTrakings>();
            HistoryImageInstallationSetHistoryImageInstallationTag1Navigation = new HashSet<HistoryImageInstallationSet>();
            HistoryImageInstallationSetHistoryImageInstallationTagNavigation = new HashSet<HistoryImageInstallationSet>();
            ImageInstallationSetTagImageTag1Navigation = new HashSet<ImageInstallationSet>();
            ImageInstallationSetTagImageTagNavigation = new HashSet<ImageInstallationSet>();
            NipsSet = new HashSet<NipsSet>();
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

        public virtual GasStations GasStationTagNavigation { get; set; }
        public virtual ProductsSet ProductsTagNavigation { get; set; }
        public virtual Employees TagEmployeeNavigation { get; set; }
        public virtual ReplacementReasons TagReplacementReasonNavigation { get; set; }
        public virtual TagTypes TagTagTypeNavigation { get; set; }
        public virtual TankIdentifiers TagTankIdentifierNavigation { get; set; }
        public virtual TicketSet TagTicketNavigation { get; set; }
        public virtual TreatmentTypes TagTreatmentTypeNavigation { get; set; }
        public virtual Vehicles TagVehicleNavigation { get; set; }
        public virtual ICollection<ControlPrintTargetSet> ControlPrintTargetSet { get; set; }
        public virtual ICollection<CustomStickers> CustomStickers { get; set; }
        public virtual ICollection<CustomStickersTrakings> CustomStickersTrakings { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationTag1Navigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationTagNavigation { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetTagImageTag1Navigation { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetTagImageTagNavigation { get; set; }
        public virtual ICollection<NipsSet> NipsSet { get; set; }
    }
}
