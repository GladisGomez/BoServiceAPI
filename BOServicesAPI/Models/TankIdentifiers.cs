using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TankIdentifiers
    {
        public TankIdentifiers()
        {
            HistoryTags = new HashSet<HistoryTags>();
            HistoryTankVehicleSet = new HashSet<HistoryTankVehicleSet>();
            Tags = new HashSet<Tags>();
            TankVehiclesSet = new HashSet<TankVehiclesSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Identifier { get; set; }
        public int? OrderTank { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<HistoryTags> HistoryTags { get; set; }
        public virtual ICollection<HistoryTankVehicleSet> HistoryTankVehicleSet { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
        public virtual ICollection<TankVehiclesSet> TankVehiclesSet { get; set; }
    }
}
