using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ProfileInClientGroupSet
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ProfileInClientGroupGasStationGroup { get; set; }
        public int? ProfileInClientGroupClientGroup { get; set; }
        public int ProfileInClientGroupProfile { get; set; }

        public virtual ClientGroups ProfileInClientGroupClientGroupNavigation { get; set; }
        public virtual GasStationGroups ProfileInClientGroupGasStationGroupNavigation { get; set; }
        public virtual ProfileSet ProfileInClientGroupProfileNavigation { get; set; }
    }
}
