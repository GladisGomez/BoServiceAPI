using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class BankingDepositSet
    {
        public int Id { get; set; }
        public string BankReference { get; set; }
        public string TranferNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateTimeDeposit { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
