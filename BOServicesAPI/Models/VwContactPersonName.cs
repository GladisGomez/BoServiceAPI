using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwContactPersonName
    {
        public int IdContactPerson { get; set; }
        public string Name { get; set; }
        public int? IdClient { get; set; }
        public int? IdEstation { get; set; }
        public int? IdClientGroup { get; set; }
    }
}
