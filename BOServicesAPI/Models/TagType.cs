using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class TagType
    {
        public TagType()
        {
            CatDeviceSets = new HashSet<CatDeviceSet>();
            HistoryTags = new HashSet<HistoryTag>();
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<CatDeviceSet> CatDeviceSets { get; set; }
        public virtual ICollection<HistoryTag> HistoryTags { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
