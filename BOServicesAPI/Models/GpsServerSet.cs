using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class GpsServerSet
    {
        public GpsServerSet()
        {
            ClientGroupInGpsSet = new HashSet<ClientGroupInGpsSet>();
            GpsSet = new HashSet<GpsSet>();
        }

        public int Id { get; set; }
        public string NickName { get; set; }
        public string Ip { get; set; }
        public string ServerName { get; set; }
        public string DataBaseName { get; set; }
        public int AviAppId { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? GpsServerGpsDbManager { get; set; }

        public virtual GpsDbManagerSet GpsServerGpsDbManagerNavigation { get; set; }
        public virtual ICollection<ClientGroupInGpsSet> ClientGroupInGpsSet { get; set; }
        public virtual ICollection<GpsSet> GpsSet { get; set; }
    }
}
