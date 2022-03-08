using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DispatchOdometerHigherMessageSet
    {
        public int Id { get; set; }
        public int Despacho { get; set; }
        public string ClientCode { get; set; }
        public string NumberClientCg { get; set; }
        public int NrovehCg { get; set; }
        public int VehicleId { get; set; }
        public string Plate { get; set; }
        public int CodgasCg { get; set; }
        public string StationNumber { get; set; }
        public int GasStationId { get; set; }
        public DateTime DespDateTime { get; set; }
        public DateTime DateTimeSearched { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
