using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class NozzleTypes
    {
        public NozzleTypes()
        {
            HistoryReaders = new HashSet<HistoryReaders>();
            Readers = new HashSet<Readers>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<HistoryReaders> HistoryReaders { get; set; }
        public virtual ICollection<Readers> Readers { get; set; }
    }
}
