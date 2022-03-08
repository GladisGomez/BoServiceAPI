using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Drivers
    {
        public Drivers()
        {
            ContingencySet = new HashSet<ContingencySet>();
            DriversVehiclesSet = new HashSet<DriversVehiclesSet>();
            MalfunctionReports = new HashSet<MalfunctionReports>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Name { get; set; }
        public string Cellular { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<ContingencySet> ContingencySet { get; set; }
        public virtual ICollection<DriversVehiclesSet> DriversVehiclesSet { get; set; }
        public virtual ICollection<MalfunctionReports> MalfunctionReports { get; set; }
    }
}
