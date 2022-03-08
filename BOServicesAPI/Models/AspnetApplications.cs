using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AspnetApplications
    {
        public AspnetApplications()
        {
            AspnetMembership = new HashSet<AspnetMembership>();
            AspnetPaths = new HashSet<AspnetPaths>();
            AspnetRoles = new HashSet<AspnetRoles>();
            AspnetUsers = new HashSet<AspnetUsers>();
        }

        public string ApplicationName { get; set; }
        public string LoweredApplicationName { get; set; }
        public Guid ApplicationId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<AspnetMembership> AspnetMembership { get; set; }
        public virtual ICollection<AspnetPaths> AspnetPaths { get; set; }
        public virtual ICollection<AspnetRoles> AspnetRoles { get; set; }
        public virtual ICollection<AspnetUsers> AspnetUsers { get; set; }
    }
}
