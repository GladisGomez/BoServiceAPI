using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ClientGroupInGpsSet
    {
        public int Id { get; set; }
        public int? AppId { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ClientGroupInGpsClientGroup { get; set; }
        public int ClientGroupInGpsGpsServer { get; set; }

        public virtual ClientGroups ClientGroupInGpsClientGroupNavigation { get; set; }
        public virtual GpsServerSet ClientGroupInGpsGpsServerNavigation { get; set; }
    }
}
