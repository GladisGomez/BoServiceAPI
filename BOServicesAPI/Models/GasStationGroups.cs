using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class GasStationGroups
    {
        public GasStationGroups()
        {
            GasStations = new HashSet<GasStations>();
            HistoryGasStationSet = new HashSet<HistoryGasStationSet>();
            ProfileInClientGroupSet = new HashSet<ProfileInClientGroupSet>();
            UsersInClientGroupSet = new HashSet<UsersInClientGroupSet>();
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

        public virtual ICollection<GasStations> GasStations { get; set; }
        public virtual ICollection<HistoryGasStationSet> HistoryGasStationSet { get; set; }
        public virtual ICollection<ProfileInClientGroupSet> ProfileInClientGroupSet { get; set; }
        public virtual ICollection<UsersInClientGroupSet> UsersInClientGroupSet { get; set; }
    }
}
