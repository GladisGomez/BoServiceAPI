using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class ReportForClient
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ReportForClientClient { get; set; }
        public int? ReportInClientReportVt { get; set; }

        public virtual Client ReportForClientClientNavigation { get; set; }
        public virtual ReportVt ReportInClientReportVtNavigation { get; set; }
    }
}
