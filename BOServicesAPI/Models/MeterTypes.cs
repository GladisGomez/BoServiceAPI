﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class MeterTypes
    {
        public MeterTypes()
        {
            CatDeviceSet = new HashSet<CatDeviceSet>();
            HistoryMetersSet = new HashSet<HistoryMetersSet>();
            Meters = new HashSet<Meters>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<CatDeviceSet> CatDeviceSet { get; set; }
        public virtual ICollection<HistoryMetersSet> HistoryMetersSet { get; set; }
        public virtual ICollection<Meters> Meters { get; set; }
    }
}
