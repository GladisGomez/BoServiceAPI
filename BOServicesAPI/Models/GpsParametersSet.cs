using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class GpsParametersSet
    {
        public GpsParametersSet()
        {
            GpsConfiguracionParametrosSet = new HashSet<GpsConfiguracionParametrosSet>();
            GpsSet = new HashSet<GpsSet>();
            HistoryGpsSet = new HashSet<HistoryGpsSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<GpsConfiguracionParametrosSet> GpsConfiguracionParametrosSet { get; set; }
        public virtual ICollection<GpsSet> GpsSet { get; set; }
        public virtual ICollection<HistoryGpsSet> HistoryGpsSet { get; set; }
    }
}
