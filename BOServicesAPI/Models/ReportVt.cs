using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class ReportVt
    {
        public ReportVt()
        {
            ReportForClients = new HashSet<ReportForClient>();
            ReportVtfileDetailsSets = new HashSet<ReportVtfileDetailsSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Emails { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ReportVtClientGroup { get; set; }

        public virtual ClientGroup ReportVtClientGroupNavigation { get; set; }
        public virtual ICollection<ReportForClient> ReportForClients { get; set; }
        public virtual ICollection<ReportVtfileDetailsSet> ReportVtfileDetailsSets { get; set; }
    }
}
