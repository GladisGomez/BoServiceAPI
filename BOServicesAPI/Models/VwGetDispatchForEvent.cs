using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwGetDispatchForEvent
    {
        public string Plate { get; set; }
        public string EcoNumber { get; set; }
        public string NickName { get; set; }
        public string OficialName { get; set; }
        public int YearModel { get; set; }
        public string Descripcion { get; set; }
        public int? NumTransaction { get; set; }
        public string StationNumber { get; set; }
        public string OficialNameStation { get; set; }
        public decimal? RealVolume { get; set; }
        public decimal? RealCost { get; set; }
        public DateTime? DatetimeEnd { get; set; }
        public int IdDispatch { get; set; }
        public int IdVehicle { get; set; }
        public int IdClient { get; set; }
        public int IdClientGroup { get; set; }
        public int IdStation { get; set; }
    }
}
