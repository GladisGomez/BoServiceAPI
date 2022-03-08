using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwContingencyReport
    {
        public string Code { get; set; }
        public string StationNumber { get; set; }
        public string NickName { get; set; }
        public DateTime DateTimeContingency { get; set; }
        public string NumberTransaction { get; set; }
        public string NumberPump { get; set; }
        public string Type { get; set; }
        public double QuantityReal { get; set; }
        public double AmountReal { get; set; }
        public string OficialName { get; set; }
        public string Plate { get; set; }
        public string MessageError { get; set; }
        public DateTime? Created { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public int? ContingencyStatusContingency { get; set; }
    }
}
