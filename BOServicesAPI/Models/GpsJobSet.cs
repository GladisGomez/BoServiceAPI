using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class GpsJobSet
    {
        public int Id { get; set; }
        public int IdJob { get; set; }
        public string SessionId { get; set; }
        public int ApplicationId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Canceled { get; set; }
        public string ServiceIp { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
