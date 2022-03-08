using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AspnetUsers
    {
        public AspnetUsers()
        {
            AspnetPersonalizationPerUser = new HashSet<AspnetPersonalizationPerUser>();
            AspnetUsersInRoles = new HashSet<AspnetUsersInRoles>();
        }

        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }

        public virtual AspnetApplications Application { get; set; }
        public virtual AspnetMembership AspnetMembership { get; set; }
        public virtual AspnetProfile AspnetProfile { get; set; }
        public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public virtual ICollection<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
    }
}
