using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class SaldosLimitConfigSet
    {
        public SaldosLimitConfigSet()
        {
            ClientGroups = new HashSet<ClientGroups>();
            MailsEnvioSaldosSet = new HashSet<MailsEnvioSaldosSet>();
        }

        public int Id { get; set; }
        public decimal Limit { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<ClientGroups> ClientGroups { get; set; }
        public virtual ICollection<MailsEnvioSaldosSet> MailsEnvioSaldosSet { get; set; }
    }
}
