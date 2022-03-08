using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class NozzleType
    {
        public NozzleType()
        {
            HistoryReaders = new HashSet<HistoryReader>();
            Readers = new HashSet<Reader>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<HistoryReader> HistoryReaders { get; set; }
        public virtual ICollection<Reader> Readers { get; set; }
    }
}
