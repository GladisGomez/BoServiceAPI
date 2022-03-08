using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DepositosSet
    {
        public DepositosSet()
        {
            CfdirelacionadosSet = new HashSet<CfdirelacionadosSet>();
        }

        public int Id { get; set; }
        public string BankReference { get; set; }
        public string TransferNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateTimeDeposit { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public bool IsCancel { get; set; }
        public string Comments { get; set; }
        public int Folio { get; set; }
        public decimal? MontoDisponible { get; set; }
        public bool DepositoCompleto { get; set; }
        public DateTime? CancelDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int BankingDepositAccountGng { get; set; }
        public int? BillingDepositos { get; set; }
        public int BankingDepositClientGroup { get; set; }
        public int? DepositosEdc { get; set; }
        public int? DepositosEmployee { get; set; }

        public virtual AccountGngSet BankingDepositAccountGngNavigation { get; set; }
        public virtual ClientGroups BankingDepositClientGroupNavigation { get; set; }
        public virtual BillingSet BillingDepositosNavigation { get; set; }
        public virtual Edcset DepositosEdcNavigation { get; set; }
        public virtual Employees DepositosEmployeeNavigation { get; set; }
        public virtual ICollection<CfdirelacionadosSet> CfdirelacionadosSet { get; set; }
    }
}
