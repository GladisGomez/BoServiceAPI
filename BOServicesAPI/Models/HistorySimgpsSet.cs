using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistorySimgpsSet
    {
        public int Id { get; set; }
        public int IdSimgps { get; set; }
        public string Simcard { get; set; }
        public string PhoneNumberInter { get; set; }
        public string ActionTransac { get; set; }
        public int? HistorySimgpsGpsBefore { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? HistorySimgpsGps { get; set; }

        public virtual GpsSet HistorySimgpsGpsNavigation { get; set; }
    }
}
