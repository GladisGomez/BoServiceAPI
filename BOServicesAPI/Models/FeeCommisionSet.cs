using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class FeeCommisionSet
    {
        public int Id { get; set; }
        public string Factura { get; set; }
        public DateTime DateTimeOperation { get; set; }
        public string Reference { get; set; }
        public decimal Amount { get; set; }
        public string Comments { get; set; }
        public bool IsCanceled { get; set; }
        public DateTime? DateTimeCanceled { get; set; }
        public string CommentsCanceled { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? FeeCommisionClientGroup { get; set; }
        public int? FeeCommisionBilling { get; set; }
        public int FeeCommisionTypeConceptBalance { get; set; }
        public int FeeCommisionTypeExpenses { get; set; }

        public virtual BillingSet FeeCommisionBillingNavigation { get; set; }
        public virtual ClientGroups FeeCommisionClientGroupNavigation { get; set; }
        public virtual TypeConceptBalanceSet FeeCommisionTypeConceptBalanceNavigation { get; set; }
        public virtual TypeExpensesSet FeeCommisionTypeExpensesNavigation { get; set; }
    }
}
