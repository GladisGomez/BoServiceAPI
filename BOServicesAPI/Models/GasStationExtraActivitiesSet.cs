using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class GasStationExtraActivitiesSet
    {
        public GasStationExtraActivitiesSet()
        {
            HistoryImageInstallationSet = new HashSet<HistoryImageInstallationSet>();
            ImageInstallationSet = new HashSet<ImageInstallationSet>();
        }

        public int Id { get; set; }
        public DateTime ActivityDate { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int GasStationExtraActivitiesTaskStatus { get; set; }
        public int GasStationGasStationExtraActivities { get; set; }

        public virtual TaskStatusSet GasStationExtraActivitiesTaskStatusNavigation { get; set; }
        public virtual GasStations GasStationGasStationExtraActivitiesNavigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSet { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSet { get; set; }
    }
}
