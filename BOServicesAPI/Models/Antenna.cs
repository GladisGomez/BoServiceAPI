using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class Antenna
    {
        public Antenna()
        {
            HistoryImageInstallationSets = new HashSet<HistoryImageInstallationSet>();
            HistoryReaders = new HashSet<HistoryReader>();
            ImageInstallationSets = new HashSet<ImageInstallationSet>();
            MalfunctionAntennas = new HashSet<MalfunctionAntenna>();
            Readers = new HashSet<Reader>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Serial { get; set; }
        public string Location { get; set; }
        public DateTime InstallationDateTime { get; set; }
        public string FolioTheService { get; set; }
        public string Comments { get; set; }
        public string ActualIp { get; set; }
        public bool Active { get; set; }
        public string CablesLocationDescription { get; set; }
        public string PowerSupplyLocationDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int GasStationAntenna { get; set; }
        public int? ProductsAntenna1 { get; set; }
        public int? AntennaReplacementReason { get; set; }

        public virtual ReplacementReason AntennaReplacementReasonNavigation { get; set; }
        public virtual GasStation GasStationAntennaNavigation { get; set; }
        public virtual ProductsSet ProductsAntenna1Navigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSets { get; set; }
        public virtual ICollection<HistoryReader> HistoryReaders { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSets { get; set; }
        public virtual ICollection<MalfunctionAntenna> MalfunctionAntennas { get; set; }
        public virtual ICollection<Reader> Readers { get; set; }
    }
}
