using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class BatteryTypeSet
    {
        public BatteryTypeSet()
        {
            BatterySet = new HashSet<BatterySet>();
            CatDeviceSet = new HashSet<CatDeviceSet>();
            HistoryBatterySet = new HashSet<HistoryBatterySet>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<BatterySet> BatterySet { get; set; }
        public virtual ICollection<CatDeviceSet> CatDeviceSet { get; set; }
        public virtual ICollection<HistoryBatterySet> HistoryBatterySet { get; set; }
    }
}
