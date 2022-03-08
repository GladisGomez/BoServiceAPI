using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class MalfunctionReports
    {
        public MalfunctionReports()
        {
            MalfunctionAntennas = new HashSet<MalfunctionAntennas>();
            MalfunctionCgs = new HashSet<MalfunctionCgs>();
            MalfunctionConnections = new HashSet<MalfunctionConnections>();
            MalfunctionFleets = new HashSet<MalfunctionFleets>();
            MalfunctionReaders = new HashSet<MalfunctionReaders>();
            MalfunctionStationProblems = new HashSet<MalfunctionStationProblems>();
            MalfunctionTags = new HashSet<MalfunctionTags>();
            MalfunctionTrainings = new HashSet<MalfunctionTrainings>();
            TicketSet = new HashSet<TicketSet>();
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

        public virtual Departments MalfunctionReportDepartmentNavigation { get; set; }
        public virtual Drivers MalfunctionReportDriverNavigation { get; set; }
        public virtual GasStations MalfunctionReportGasStationNavigation { get; set; }
        public virtual Vehicles MalfunctionReportVehicleNavigation { get; set; }
        public virtual ICollection<MalfunctionAntennas> MalfunctionAntennas { get; set; }
        public virtual ICollection<MalfunctionCgs> MalfunctionCgs { get; set; }
        public virtual ICollection<MalfunctionConnections> MalfunctionConnections { get; set; }
        public virtual ICollection<MalfunctionFleets> MalfunctionFleets { get; set; }
        public virtual ICollection<MalfunctionReaders> MalfunctionReaders { get; set; }
        public virtual ICollection<MalfunctionStationProblems> MalfunctionStationProblems { get; set; }
        public virtual ICollection<MalfunctionTags> MalfunctionTags { get; set; }
        public virtual ICollection<MalfunctionTrainings> MalfunctionTrainings { get; set; }
        public virtual ICollection<TicketSet> TicketSet { get; set; }
    }
}
