using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class PumpControllers
    {
        public PumpControllers()
        {
            GasStations = new HashSet<GasStations>();
            HistoryGasStationSet = new HashSet<HistoryGasStationSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Product { get; set; }
        public string Manufacturer { get; set; }
        public string Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<GasStations> GasStations { get; set; }
        public virtual ICollection<HistoryGasStationSet> HistoryGasStationSet { get; set; }
    }
}
