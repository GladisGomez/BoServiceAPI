using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DataBillingSet
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Rfc { get; set; }
        public string Street { get; set; }
        public string Colony { get; set; }
        public string City { get; set; }
        public string Cp { get; set; }
        public string InsideNumber { get; set; }
        public string OutsideNumer { get; set; }
        public string Location { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
