using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class BatterySet
    {
        public BatterySet()
        {
            DiagnosticBatterySet = new HashSet<DiagnosticBatterySet>();
            HistoryImageInstallationSetHistoryImageInstallationBattery1Navigation = new HashSet<HistoryImageInstallationSet>();
            HistoryImageInstallationSetHistoryImageInstallationBatteryNavigation = new HashSet<HistoryImageInstallationSet>();
            ImageInstallationSetBatteryImageInstallationNavigation = new HashSet<ImageInstallationSet>();
            ImageInstallationSetImageInstallationBatteryNavigation = new HashSet<ImageInstallationSet>();
            TicketSet = new HashSet<TicketSet>();
        }

        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string Voltage { get; set; }
        public DateTime? DateInstallation { get; set; }
        public string Comments { get; set; }
        public string LaboratoryNumber { get; set; }
        public DateTime? DateSendLaboratory { get; set; }
        public string FolioTheService { get; set; }
        public string FuelType { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? BatteryBatteryFailure { get; set; }
        public int? BatteryTypeBattery { get; set; }
        public int? GasStationBattery { get; set; }
        public int? ProductsBattery1 { get; set; }
        public int? BatteryReplacementReason { get; set; }

        public virtual BatteryFailureSet BatteryBatteryFailureNavigation { get; set; }
        public virtual ReplacementReasons BatteryReplacementReasonNavigation { get; set; }
        public virtual BatteryTypeSet BatteryTypeBatteryNavigation { get; set; }
        public virtual GasStations GasStationBatteryNavigation { get; set; }
        public virtual ProductsSet ProductsBattery1Navigation { get; set; }
        public virtual ICollection<DiagnosticBatterySet> DiagnosticBatterySet { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationBattery1Navigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSetHistoryImageInstallationBatteryNavigation { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetBatteryImageInstallationNavigation { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSetImageInstallationBatteryNavigation { get; set; }
        public virtual ICollection<TicketSet> TicketSet { get; set; }
    }
}
