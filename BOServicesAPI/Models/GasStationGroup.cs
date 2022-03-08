using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class GasStationGroup
    {
        public GasStationGroup()
        {
            GasStations = new HashSet<GasStation>();
            HistoryGasStationSets = new HashSet<HistoryGasStationSet>();
            ProfileInClientGroupSets = new HashSet<ProfileInClientGroupSet>();
            UsersInClientGroupSets = new HashSet<UsersInClientGroupSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string OficialName { get; set; }
        public string Nickname { get; set; }
        public string Comments { get; set; }
        public string IdTotvs { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<GasStation> GasStations { get; set; }
        public virtual ICollection<HistoryGasStationSet> HistoryGasStationSets { get; set; }
        public virtual ICollection<ProfileInClientGroupSet> ProfileInClientGroupSets { get; set; }
        public virtual ICollection<UsersInClientGroupSet> UsersInClientGroupSets { get; set; }
    }
}
