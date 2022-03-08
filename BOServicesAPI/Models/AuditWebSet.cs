using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AuditWebSet
    {
        public int Id { get; set; }
        public string ChangeType { get; set; }
        public string ChangedBy { get; set; }
        public string OriginalValues { get; set; }
        public string NewValues { get; set; }
        public DateTime Updated { get; set; }
        public string KeySegment { get; set; }
        public string ReferenceType { get; set; }
        public string DataSource { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? AuditWebUserWeb { get; set; }

        public virtual UserWebSet AuditWebUserWebNavigation { get; set; }
    }
}
