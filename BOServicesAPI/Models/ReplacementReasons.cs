using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ReplacementReasons
    {
        public ReplacementReasons()
        {
            AccesoriesSet = new HashSet<AccesoriesSet>();
            Antennas = new HashSet<Antennas>();
            BatterySet = new HashSet<BatterySet>();
            HistoryAccesoriesSet = new HashSet<HistoryAccesoriesSet>();
            HistoryAntennas = new HashSet<HistoryAntennas>();
            HistoryBatterySet = new HashSet<HistoryBatterySet>();
            HistoryMetersSet = new HashSet<HistoryMetersSet>();
            HistoryReaders = new HashSet<HistoryReaders>();
            HistoryTags = new HashSet<HistoryTags>();
            Meters = new HashSet<Meters>();
            Readers = new HashSet<Readers>();
            Tags = new HashSet<Tags>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Reason { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int SectionReasonsReplacementReason { get; set; }

        public virtual SectionReasonsSet SectionReasonsReplacementReasonNavigation { get; set; }
        public virtual ICollection<AccesoriesSet> AccesoriesSet { get; set; }
        public virtual ICollection<Antennas> Antennas { get; set; }
        public virtual ICollection<BatterySet> BatterySet { get; set; }
        public virtual ICollection<HistoryAccesoriesSet> HistoryAccesoriesSet { get; set; }
        public virtual ICollection<HistoryAntennas> HistoryAntennas { get; set; }
        public virtual ICollection<HistoryBatterySet> HistoryBatterySet { get; set; }
        public virtual ICollection<HistoryMetersSet> HistoryMetersSet { get; set; }
        public virtual ICollection<HistoryReaders> HistoryReaders { get; set; }
        public virtual ICollection<HistoryTags> HistoryTags { get; set; }
        public virtual ICollection<Meters> Meters { get; set; }
        public virtual ICollection<Readers> Readers { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
    }
}
