using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class StatusSet
    {
        public StatusSet()
        {
            GpsSet = new HashSet<GpsSet>();
            HistoryGpsSet = new HashSet<HistoryGpsSet>();
            HistoryVehiclesSet = new HashSet<HistoryVehiclesSet>();
            Vehicles = new HashSet<Vehicles>();
        }

        public int Id { get; set; }
        public string NameStatus { get; set; }
        public bool Enable { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<GpsSet> GpsSet { get; set; }
        public virtual ICollection<HistoryGpsSet> HistoryGpsSet { get; set; }
        public virtual ICollection<HistoryVehiclesSet> HistoryVehiclesSet { get; set; }
        public virtual ICollection<Vehicles> Vehicles { get; set; }
    }
}
