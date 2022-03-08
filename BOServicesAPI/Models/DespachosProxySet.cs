using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DespachosProxySet
    {
        public int Id { get; set; }
        public string Numref { get; set; }
        public string TransactionNumber { get; set; }
        public string StationNumber { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public DateTime DateTimeStart { get; set; }
        public string TagId { get; set; }
        public DateTime? DateTimeEnd { get; set; }
        public double? Cost { get; set; }
        public double? Volume { get; set; }
        public string PlateNumber { get; set; }
        public bool? UpdatedOffline { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
