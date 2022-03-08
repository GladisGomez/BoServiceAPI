using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Readers
    {
        public Readers()
        {
            DiagnosticReaderSet = new HashSet<DiagnosticReaderSet>();
            HistoryImageInstallationSet = new HashSet<HistoryImageInstallationSet>();
            ImageInstallationSet = new HashSet<ImageInstallationSet>();
            MalfunctionReaders = new HashSet<MalfunctionReaders>();
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

        public virtual Antennas AntennaReaderNavigation { get; set; }
        public virtual GasStations GasStationReaderNavigation { get; set; }
        public virtual ProductsSet ProductsReader1Navigation { get; set; }
        public virtual FuelTypes ReaderFuelTypeNavigation { get; set; }
        public virtual NozzleTypes ReaderNozzleNavigation { get; set; }
        public virtual ReplacementReasons ReaderReplacementReasonNavigation { get; set; }
        public virtual ReaderTypeSet ReaderTypeReaderNavigation { get; set; }
        public virtual ICollection<DiagnosticReaderSet> DiagnosticReaderSet { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSet { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSet { get; set; }
        public virtual ICollection<MalfunctionReaders> MalfunctionReaders { get; set; }
    }
}
