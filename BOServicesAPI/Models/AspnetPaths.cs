using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AspnetPaths
    {
        public AspnetPaths()
        {
            AspnetPersonalizationPerUser = new HashSet<AspnetPersonalizationPerUser>();
        }

        public Guid ApplicationId { get; set; }
        public Guid PathId { get; set; }
        public string Path { get; set; }
        public string LoweredPath { get; set; }

        public virtual AspnetApplications Application { get; set; }
        public virtual AspnetPersonalizationAllUsers AspnetPersonalizationAllUsers { get; set; }
        public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
    }
}
