using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionFleets
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public bool? IsBalanceOk { get; set; }
        public bool? AreRulesOk { get; set; }
        public bool? IsRingActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int MalfunctionReportMalfunctionFleet { get; set; }

        public virtual MalfunctionReports MalfunctionReportMalfunctionFleetNavigation { get; set; }
    }
}
