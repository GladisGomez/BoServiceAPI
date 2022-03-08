using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionTrainings
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public bool? DidPressF1 { get; set; }
        public bool? DidInsertTheNozzleAllTheWay { get; set; }
        public bool? ForClosedModeDidLiftTheHouseHandle { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int MalfunctionReportMalfunctionTraining { get; set; }

        public virtual MalfunctionReports MalfunctionReportMalfunctionTrainingNavigation { get; set; }
    }
}
