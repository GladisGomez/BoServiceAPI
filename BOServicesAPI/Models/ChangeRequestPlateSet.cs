using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ChangeRequestPlateSet
    {
        public ChangeRequestPlateSet()
        {
            HistoryImageInstallationSet = new HashSet<HistoryImageInstallationSet>();
            ImageInstallationSet = new HashSet<ImageInstallationSet>();
        }

        public int Id { get; set; }
        public string AutorizationKey { get; set; }
        public string PlateBefore { get; set; }
        public string EcoBefore { get; set; }
        public string VinBefore { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ChangeRequestPlateEmployee { get; set; }
        public int? ChangeRequestPlateClient1 { get; set; }
        public int? ChangeRequestPlateVehicle1 { get; set; }

        public virtual Clients ChangeRequestPlateClient1Navigation { get; set; }
        public virtual Employees ChangeRequestPlateEmployeeNavigation { get; set; }
        public virtual Vehicles ChangeRequestPlateVehicle1Navigation { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSet { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSet { get; set; }
    }
}
