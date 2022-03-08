using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class MeterType
    {
        public MeterType()
        {
            CatDeviceSets = new HashSet<CatDeviceSet>();
            HistoryMetersSets = new HashSet<HistoryMetersSet>();
            Meters = new HashSet<Meter>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<CatDeviceSet> CatDeviceSets { get; set; }
        public virtual ICollection<HistoryMetersSet> HistoryMetersSets { get; set; }
        public virtual ICollection<Meter> Meters { get; set; }
    }
}
