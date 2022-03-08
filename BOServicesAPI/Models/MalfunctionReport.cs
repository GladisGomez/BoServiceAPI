using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionReport
    {
        public MalfunctionReport()
        {
            MalfunctionAntennas = new HashSet<MalfunctionAntenna>();
            MalfunctionCgs = new HashSet<MalfunctionCg>();
            MalfunctionConnections = new HashSet<MalfunctionConnection>();
            MalfunctionFleets = new HashSet<MalfunctionFleet>();
            MalfunctionReaders = new HashSet<MalfunctionReader>();
            MalfunctionStationProblems = new HashSet<MalfunctionStationProblem>();
            MalfunctionTags = new HashSet<MalfunctionTag>();
            MalfunctionTrainings = new HashSet<MalfunctionTraining>();
            TicketSets = new HashSet<TicketSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int MalfunctionReportDepartment { get; set; }
        public int? MalfunctionReportDriver { get; set; }
        public int? MalfunctionReportGasStation { get; set; }
        public int? MalfunctionReportVehicle { get; set; }

        public virtual Department MalfunctionReportDepartmentNavigation { get; set; }
        public virtual Driver MalfunctionReportDriverNavigation { get; set; }
        public virtual GasStation MalfunctionReportGasStationNavigation { get; set; }
        public virtual Vehicle MalfunctionReportVehicleNavigation { get; set; }
        public virtual ICollection<MalfunctionAntenna> MalfunctionAntennas { get; set; }
        public virtual ICollection<MalfunctionCg> MalfunctionCgs { get; set; }
        public virtual ICollection<MalfunctionConnection> MalfunctionConnections { get; set; }
        public virtual ICollection<MalfunctionFleet> MalfunctionFleets { get; set; }
        public virtual ICollection<MalfunctionReader> MalfunctionReaders { get; set; }
        public virtual ICollection<MalfunctionStationProblem> MalfunctionStationProblems { get; set; }
        public virtual ICollection<MalfunctionTag> MalfunctionTags { get; set; }
        public virtual ICollection<MalfunctionTraining> MalfunctionTrainings { get; set; }
        public virtual ICollection<TicketSet> TicketSets { get; set; }
    }
}
