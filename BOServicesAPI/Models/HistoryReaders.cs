using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryReaders
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public int? IdReader { get; set; }
        public string Serial { get; set; }
        public bool? IsMasterSatellite { get; set; }
        public int? PumpNumber { get; set; }
        public bool? Active { get; set; }
        public DateTime? ActivationDateTime { get; set; }
        public int? MalfunctionReader { get; set; }
        public string Comments { get; set; }
        public int? DiagnosticReaderCollection { get; set; }
        public string FolioTheService { get; set; }
        public string ActionTransac { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int? HistoryReaderAntenna { get; set; }
        public int HistoryReaderFuelType { get; set; }
        public int? HistoryReaderGasStation { get; set; }
        public int HistoryReaderNozzleType { get; set; }
        public int? HistoryReaderReaderType { get; set; }
        public int? HistoryReaderReplacementReason { get; set; }

        public virtual Antennas HistoryReaderAntennaNavigation { get; set; }
        public virtual FuelTypes HistoryReaderFuelTypeNavigation { get; set; }
        public virtual GasStations HistoryReaderGasStationNavigation { get; set; }
        public virtual NozzleTypes HistoryReaderNozzleTypeNavigation { get; set; }
        public virtual ReaderTypeSet HistoryReaderReaderTypeNavigation { get; set; }
        public virtual ReplacementReasons HistoryReaderReplacementReasonNavigation { get; set; }
    }
}
