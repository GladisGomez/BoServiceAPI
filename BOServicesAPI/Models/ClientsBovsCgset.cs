using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ClientsBovsCgset
    {
        public int Id { get; set; }
        public int IdClientGroupBo { get; set; }
        public string ClientGroupBo { get; set; }
        public string ClientCg { get; set; }
        public int IdGroupBo { get; set; }
        public string GroupBo { get; set; }
        public string GroupCg { get; set; }
        public int? PublicClientNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
