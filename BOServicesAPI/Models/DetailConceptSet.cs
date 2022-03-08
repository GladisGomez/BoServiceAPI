using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DetailConceptSet
    {
        public int Id { get; set; }
        public decimal FuelTotalAccountStatement { get; set; }
        public decimal Subtotal { get; set; }
        public string Accountnumber { get; set; }
        public string TypeOperation { get; set; }
        public DateTime DateTimeOperation { get; set; }
        public string Rfc { get; set; }
        public decimal Amount { get; set; }
        public decimal UnitValue { get; set; }
        public decimal Quantity { get; set; }
        public string FolioOperation { get; set; }
        public string FuelName { get; set; }
        public string StationNumber { get; set; }
        public string PublicId { get; set; }
        public decimal TransferAmount { get; set; }
        public decimal Valuation { get; set; }
        public string Tax { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
