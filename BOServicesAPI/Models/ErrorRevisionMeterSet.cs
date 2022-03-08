using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ErrorRevisionMeterSet
    {
        public ErrorRevisionMeterSet()
        {
            RevisionMeterSet = new HashSet<RevisionMeterSet>();
        }

        public int Id { get; set; }
        public string DescriptionError { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<RevisionMeterSet> RevisionMeterSet { get; set; }
    }
}
