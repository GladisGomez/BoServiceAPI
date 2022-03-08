using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwContingencys
    {
        public string Code { get; set; }
        public string Plate { get; set; }
        public string EcoNumber { get; set; }
        public double Quantity { get; set; }
        public double Amount { get; set; }
        public double QuantityReal { get; set; }
        public double AmountReal { get; set; }
        public int IdStation { get; set; }
        public string NameGasStation { get; set; }
        public DateTime DateTimeContingency { get; set; }
        public string Type { get; set; }
        public string Client { get; set; }
        public int IdClientGroup { get; set; }
        public int IdClient { get; set; }
        public string NumControlGas { get; set; }
        public string NameCedi { get; set; }
        public int PublicClientNumber { get; set; }
        public string OficialName { get; set; }
        public int Clasificacion { get; set; }
        public string NumberClientCg { get; set; }
    }
}
