using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class RolesWebSet
    {
        public RolesWebSet()
        {
            PermissionsWebSet = new HashSet<PermissionsWebSet>();
            RoleClientGroupSet = new HashSet<RoleClientGroupSet>();
            RoleClientSet = new HashSet<RoleClientSet>();
            UsersInRolesWebSet = new HashSet<UsersInRolesWebSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int RolesWebUserWeb { get; set; }

        public virtual UserWebSet RolesWebUserWebNavigation { get; set; }
        public virtual ICollection<PermissionsWebSet> PermissionsWebSet { get; set; }
        public virtual ICollection<RoleClientGroupSet> RoleClientGroupSet { get; set; }
        public virtual ICollection<RoleClientSet> RoleClientSet { get; set; }
        public virtual ICollection<UsersInRolesWebSet> UsersInRolesWebSet { get; set; }
    }
}
