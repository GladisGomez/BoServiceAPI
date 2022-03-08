using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwAspnetWebPartStateUser
    {
        public Guid? PathId { get; set; }
        public Guid? UserId { get; set; }
        public int? DataSize { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
