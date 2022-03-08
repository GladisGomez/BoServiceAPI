using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwDispatchedWithoutMessage
    {
        public int Id { get; set; }
        public int IdDespacho { get; set; }
        public string ClientCode { get; set; }
        public int VehicleId { get; set; }
        public int CodGasstation { get; set; }
        public DateTime DespDateTime { get; set; }
        public DateTime TranDateTime { get; set; }
        public string Client { get; set; }
        public string Status { get; set; }
        public string Plate { get; set; }
        public string NumbwerEco { get; set; }
        public string NickNameGasStation { get; set; }
        public string GasStation { get; set; }
    }
}
