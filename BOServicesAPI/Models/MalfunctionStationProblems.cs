using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionStationProblems
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public bool? IsProfecoOk { get; set; }
        public bool? IsNotNewServer { get; set; }
        public bool? IsElectricityOk { get; set; }
        public bool? IsPosOk { get; set; }
        public bool? StationHasRightFuel { get; set; }
        public bool? IsNotGilbarcoBlock { get; set; }
        public bool? IsNotTotalFailure { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int MalfunctionReportMalfunctionStationProblem { get; set; }

        public virtual MalfunctionReports MalfunctionReportMalfunctionStationProblemNavigation { get; set; }
    }
}
