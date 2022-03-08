using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AspnetUsersInRoles
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        public virtual AspnetRoles Role { get; set; }
        public virtual AspnetUsers User { get; set; }
    }
}
