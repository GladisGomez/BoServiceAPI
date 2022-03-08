using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryBatterySet
    {
        public int Id { get; set; }
        public int? IdBattery { get; set; }
        public string SerialNumber { get; set; }
        public string Voltage { get; set; }
        public DateTime? DateInstallation { get; set; }
        public string Comments { get; set; }
        public string LaboratoryNumber { get; set; }
        public DateTime? DateSendLaboratory { get; set; }
        public string DiagnosticBattery { get; set; }
        public string FolioTheService { get; set; }
        public string FuelType { get; set; }
        public bool? Active { get; set; }
        public string ActionTransac { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? HistoryBatteryBatteryFailure { get; set; }
        public int? HistoryBatteryBatteryType { get; set; }
        public int? HistoryBatteryGasStation { get; set; }
        public int? HistoryBatteryReplacementReason { get; set; }

        public virtual BatteryFailureSet HistoryBatteryBatteryFailureNavigation { get; set; }
        public virtual BatteryTypeSet HistoryBatteryBatteryTypeNavigation { get; set; }
        public virtual GasStations HistoryBatteryGasStationNavigation { get; set; }
        public virtual ReplacementReasons HistoryBatteryReplacementReasonNavigation { get; set; }
    }
}
