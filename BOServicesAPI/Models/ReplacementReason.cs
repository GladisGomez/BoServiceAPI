using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class ReplacementReason
    {
        public ReplacementReason()
        {
            AccesoriesSets = new HashSet<AccesoriesSet>();
            Antennas = new HashSet<Antenna>();
            BatterySets = new HashSet<BatterySet>();
            HistoryAccesoriesSets = new HashSet<HistoryAccesoriesSet>();
            HistoryAntennas = new HashSet<HistoryAntenna>();
            HistoryBatterySets = new HashSet<HistoryBatterySet>();
            HistoryMetersSets = new HashSet<HistoryMetersSet>();
            HistoryReaders = new HashSet<HistoryReader>();
            HistoryTags = new HashSet<HistoryTag>();
            Meters = new HashSet<Meter>();
            Readers = new HashSet<Reader>();
            Tags = new HashSet<Tag>();
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
        public virtual ICollection<AccesoriesSet> AccesoriesSets { get; set; }
        public virtual ICollection<Antenna> Antennas { get; set; }
        public virtual ICollection<BatterySet> BatterySets { get; set; }
        public virtual ICollection<HistoryAccesoriesSet> HistoryAccesoriesSets { get; set; }
        public virtual ICollection<HistoryAntenna> HistoryAntennas { get; set; }
        public virtual ICollection<HistoryBatterySet> HistoryBatterySets { get; set; }
        public virtual ICollection<HistoryMetersSet> HistoryMetersSets { get; set; }
        public virtual ICollection<HistoryReader> HistoryReaders { get; set; }
        public virtual ICollection<HistoryTag> HistoryTags { get; set; }
        public virtual ICollection<Meter> Meters { get; set; }
        public virtual ICollection<Reader> Readers { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
