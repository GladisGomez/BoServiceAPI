using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionFleet
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

        public virtual MalfunctionReport MalfunctionReportMalfunctionFleetNavigation { get; set; }
    }
}
