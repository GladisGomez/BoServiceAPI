using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Antennas
    {
        public Antennas()
        {
            HistoryImageInstallationSet = new HashSet<HistoryImageInstallationSet>();
            HistoryReaders = new HashSet<HistoryReaders>();
            ImageInstallationSet = new HashSet<ImageInstallationSet>();
            MalfunctionAntennas = new HashSet<MalfunctionAntennas>();
            Readers = new HashSet<Readers>();
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

        public virtual ReplacementReasons AntennaReplacementReasonNavigation { get; set; }
        public virtual GasStations GasStationAntennaNavigation { get; set; }
        public virtual ProductsSet ProductsAntenna1Navigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSet { get; set; }
        public virtual ICollection<HistoryReaders> HistoryReaders { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSet { get; set; }
        public virtual ICollection<MalfunctionAntennas> MalfunctionAntennas { get; set; }
        public virtual ICollection<Readers> Readers { get; set; }
    }
}
