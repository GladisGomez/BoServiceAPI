using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TimeZoneCset
    {
        public TimeZoneCset()
        {
            Clients = new HashSet<Clients>();
            GasStations = new HashSet<GasStations>();
            HistoryGasStationSet = new HashSet<HistoryGasStationSet>();
        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string IdTimeZone { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? CountryTimeZone { get; set; }

        public virtual Countries CountryTimeZoneNavigation { get; set; }
        public virtual ICollection<Clients> Clients { get; set; }
        public virtual ICollection<GasStations> GasStations { get; set; }
        public virtual ICollection<HistoryGasStationSet> HistoryGasStationSet { get; set; }
    }
}
