using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class TankIdentifier
    {
        public TankIdentifier()
        {
            HistoryTags = new HashSet<HistoryTag>();
            HistoryTankVehicleSets = new HashSet<HistoryTankVehicleSet>();
            Tags = new HashSet<Tag>();
            TankVehiclesSets = new HashSet<TankVehiclesSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Identifier { get; set; }
        public int? OrderTank { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<HistoryTag> HistoryTags { get; set; }
        public virtual ICollection<HistoryTankVehicleSet> HistoryTankVehicleSets { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<TankVehiclesSet> TankVehiclesSets { get; set; }
    }
}
