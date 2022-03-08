using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ProfileSet
    {
        public ProfileSet()
        {
            ProfileInClientGroupSet = new HashSet<ProfileInClientGroupSet>();
            ProfileInClientSet = new HashSet<ProfileInClientSet>();
            UsersInProfileSet = new HashSet<UsersInProfileSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsFleet { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int ProfileUserWeb { get; set; }

        public virtual UserWebSet ProfileUserWebNavigation { get; set; }
        public virtual ICollection<ProfileInClientGroupSet> ProfileInClientGroupSet { get; set; }
        public virtual ICollection<ProfileInClientSet> ProfileInClientSet { get; set; }
        public virtual ICollection<UsersInProfileSet> UsersInProfileSet { get; set; }
    }
}
