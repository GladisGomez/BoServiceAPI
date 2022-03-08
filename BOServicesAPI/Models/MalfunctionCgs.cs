using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionCgs
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string CgVersion { get; set; }
        public string SgpsVersion { get; set; }
        public DateTime? SgpsLastUpdateDate { get; set; }
        public string SgpmVersion { get; set; }
        public DateTime? SgpmLastUpdateDate { get; set; }
        public bool? IsNotTotalFailure { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int MalfunctionReportMalfunctionCg { get; set; }

        public virtual MalfunctionReports MalfunctionReportMalfunctionCgNavigation { get; set; }
    }
}
