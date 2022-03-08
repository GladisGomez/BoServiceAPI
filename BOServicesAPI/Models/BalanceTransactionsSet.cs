using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class BalanceTransactionsSet
    {
        public int Id { get; set; }
        public DateTime DateTimeOperation { get; set; }
        public string Reference { get; set; }
        public int? NumTransaction { get; set; }
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? BalanceTransactionsClientGroup { get; set; }
        public int BalanceTransactionsTypeConceptBalance { get; set; }

        public virtual ClientGroups BalanceTransactionsClientGroupNavigation { get; set; }
        public virtual TypeConceptBalanceSet BalanceTransactionsTypeConceptBalanceNavigation { get; set; }
    }
}
