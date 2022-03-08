using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryReader
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

        public virtual Antenna HistoryReaderAntennaNavigation { get; set; }
        public virtual FuelType HistoryReaderFuelTypeNavigation { get; set; }
        public virtual GasStation HistoryReaderGasStationNavigation { get; set; }
        public virtual NozzleType HistoryReaderNozzleTypeNavigation { get; set; }
        public virtual ReaderTypeSet HistoryReaderReaderTypeNavigation { get; set; }
        public virtual ReplacementReason HistoryReaderReplacementReasonNavigation { get; set; }
    }
}
