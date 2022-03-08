using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionTags
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public bool? IsRingLooksOk { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int MalfunctionReportMalfunctionTag { get; set; }

        public virtual MalfunctionReports MalfunctionReportMalfunctionTagNavigation { get; set; }
    }
}
