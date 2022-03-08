using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class BadPositionsWhileChargingSet
    {
        public int Id { get; set; }
        public int VehId { get; set; }
        public string Plate { get; set; }
        public string EcoNumber { get; set; }
        public int ClientId { get; set; }
        public int ClientGroupId { get; set; }
        public DateTimeOffset? RequestedDate { get; set; }
        public DateTimeOffset? ResponseDate { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int DispatchId { get; set; }
        public DateTimeOffset? DateDispatch { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
