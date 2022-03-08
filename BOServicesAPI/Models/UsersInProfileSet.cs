using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class UsersInProfileSet
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? UsersInProfileClient { get; set; }
        public int? UsersInProfileGasStation { get; set; }
        public int? UsersInProfileProfile { get; set; }
        public int UsersInProfileUserWeb { get; set; }

        public virtual Clients UsersInProfileClientNavigation { get; set; }
        public virtual GasStations UsersInProfileGasStationNavigation { get; set; }
        public virtual ProfileSet UsersInProfileProfileNavigation { get; set; }
        public virtual UserWebSet UsersInProfileUserWebNavigation { get; set; }
    }
}
