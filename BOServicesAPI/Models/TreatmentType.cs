using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class TreatmentType
    {
        public TreatmentType()
        {
            AccesoriesSets = new HashSet<AccesoriesSet>();
            HistoryAccesoriesSets = new HashSet<HistoryAccesoriesSet>();
            HistoryMetersSets = new HashSet<HistoryMetersSet>();
            HistoryTags = new HashSet<HistoryTag>();
            Meters = new HashSet<Meter>();
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<AccesoriesSet> AccesoriesSets { get; set; }
        public virtual ICollection<HistoryAccesoriesSet> HistoryAccesoriesSets { get; set; }
        public virtual ICollection<HistoryMetersSet> HistoryMetersSets { get; set; }
        public virtual ICollection<HistoryTag> HistoryTags { get; set; }
        public virtual ICollection<Meter> Meters { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
