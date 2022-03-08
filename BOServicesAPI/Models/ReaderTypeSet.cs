using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ReaderTypeSet
    {
        public ReaderTypeSet()
        {
            CatDeviceSet = new HashSet<CatDeviceSet>();
            HistoryReaders = new HashSet<HistoryReaders>();
            Readers = new HashSet<Readers>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<CatDeviceSet> CatDeviceSet { get; set; }
        public virtual ICollection<HistoryReaders> HistoryReaders { get; set; }
        public virtual ICollection<Readers> Readers { get; set; }
    }
}
