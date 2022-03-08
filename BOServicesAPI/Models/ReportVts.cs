using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ReportVts
    {
        public ReportVts()
        {
            ReportForClients = new HashSet<ReportForClients>();
            ReportVtfileDetailsSet = new HashSet<ReportVtfileDetailsSet>();
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

        public virtual ClientGroups ReportVtClientGroupNavigation { get; set; }
        public virtual ICollection<ReportForClients> ReportForClients { get; set; }
        public virtual ICollection<ReportVtfileDetailsSet> ReportVtfileDetailsSet { get; set; }
    }
}
