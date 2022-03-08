using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class Reader
    {
        public Reader()
        {
            DiagnosticReaderSets = new HashSet<DiagnosticReaderSet>();
            HistoryImageInstallationSets = new HashSet<HistoryImageInstallationSet>();
            ImageInstallationSets = new HashSet<ImageInstallationSet>();
            MalfunctionReaders = new HashSet<MalfunctionReader>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Serial { get; set; }
        public bool IsMasterSatellite { get; set; }
        public int PumpNumber { get; set; }
        public bool Active { get; set; }
        public DateTime ActivationDateTime { get; set; }
        public string Comments { get; set; }
        public string FolioTheService { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int? AntennaReader { get; set; }
        public int ReaderFuelType { get; set; }
        public int GasStationReader { get; set; }
        public int ReaderNozzle { get; set; }
        public int? ProductsReader1 { get; set; }
        public int? ReaderTypeReader { get; set; }
        public int? ReaderReplacementReason { get; set; }

        public virtual Antenna AntennaReaderNavigation { get; set; }
        public virtual GasStation GasStationReaderNavigation { get; set; }
        public virtual ProductsSet ProductsReader1Navigation { get; set; }
        public virtual FuelType ReaderFuelTypeNavigation { get; set; }
        public virtual NozzleType ReaderNozzleNavigation { get; set; }
        public virtual ReplacementReason ReaderReplacementReasonNavigation { get; set; }
        public virtual ReaderTypeSet ReaderTypeReaderNavigation { get; set; }
        public virtual ICollection<DiagnosticReaderSet> DiagnosticReaderSets { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSets { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSets { get; set; }
        public virtual ICollection<MalfunctionReader> MalfunctionReaders { get; set; }
    }
}
