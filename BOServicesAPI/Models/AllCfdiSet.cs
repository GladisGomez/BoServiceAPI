using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class AllCfdiSet
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public decimal MontoDeposito { get; set; }
        public int? CfdirelacionadosAllCfdi { get; set; }
        public int? AllCfdiEdc { get; set; }
        public int? AllCfdiEde { get; set; }

        public virtual Edcset AllCfdiEdcNavigation { get; set; }
        public virtual Edeset AllCfdiEdeNavigation { get; set; }
        public virtual CfdirelacionadosSet CfdirelacionadosAllCfdiNavigation { get; set; }
    }
}
