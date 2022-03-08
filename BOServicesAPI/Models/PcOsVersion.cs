using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class PcOsVersion
    {
        public PcOsVersion()
        {
            GasStations = new HashSet<GasStation>();
            HistoryGasStationSets = new HashSet<HistoryGasStationSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<GasStation> GasStations { get; set; }
        public virtual ICollection<HistoryGasStationSet> HistoryGasStationSets { get; set; }
    }
}
