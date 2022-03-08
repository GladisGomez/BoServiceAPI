using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class Driver
    {
        public Driver()
        {
            ContingencySets = new HashSet<ContingencySet>();
            DriversVehiclesSets = new HashSet<DriversVehiclesSet>();
            MalfunctionReports = new HashSet<MalfunctionReport>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Name { get; set; }
        public string Cellular { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<ContingencySet> ContingencySets { get; set; }
        public virtual ICollection<DriversVehiclesSet> DriversVehiclesSets { get; set; }
        public virtual ICollection<MalfunctionReport> MalfunctionReports { get; set; }
    }
}
