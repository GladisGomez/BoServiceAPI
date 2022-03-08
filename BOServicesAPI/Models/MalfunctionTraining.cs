using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionTraining
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

        public virtual MalfunctionReport MalfunctionReportMalfunctionTrainingNavigation { get; set; }
    }
}
