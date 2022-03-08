using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AccountGngSet
    {
        public AccountGngSet()
        {
            DepositosSet = new HashSet<DepositosSet>();
            PagosEstacionSet = new HashSet<PagosEstacionSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string Clabe { get; set; }
        public bool IsActive { get; set; }
        public int? IdAccountEpicor { get; set; }
        public int? IdBankEpicor { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? BankAccountGng { get; set; }

        public virtual BankSet BankAccountGngNavigation { get; set; }
        public virtual ICollection<DepositosSet> DepositosSet { get; set; }
        public virtual ICollection<PagosEstacionSet> PagosEstacionSet { get; set; }
    }
}
