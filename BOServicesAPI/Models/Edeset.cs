using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Edeset
    {
        public Edeset()
        {
            AllCfdiSet = new HashSet<AllCfdiSet>();
            BillingSet = new HashSet<BillingSet>();
            ConsumoDeCombustiblesSet = new HashSet<ConsumoDeCombustiblesSet>();
        }

        public int Id { get; set; }
        public int Folio { get; set; }
        public bool ConnectedToCfdi { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? EdcomplementoEde { get; set; }
        public int? EdeEmisor { get; set; }
        public int? EdeEncabezadoEstadoCuenta { get; set; }
        public int? EdeImpuetosTrasladadosEde { get; set; }
        public int? EdeReceptor { get; set; }
        public int? EdeTimbreFiscal { get; set; }

        public virtual EdcomplementoSet EdcomplementoEdeNavigation { get; set; }
        public virtual EmisorSet EdeEmisorNavigation { get; set; }
        public virtual EncabezadoEstadoCuentaSet EdeEncabezadoEstadoCuentaNavigation { get; set; }
        public virtual ImpuetosTrasladadosEdeset EdeImpuetosTrasladadosEdeNavigation { get; set; }
        public virtual ReceptorSet EdeReceptorNavigation { get; set; }
        public virtual TimbreFiscalSet EdeTimbreFiscalNavigation { get; set; }
        public virtual ICollection<AllCfdiSet> AllCfdiSet { get; set; }
        public virtual ICollection<BillingSet> BillingSet { get; set; }
        public virtual ICollection<ConsumoDeCombustiblesSet> ConsumoDeCombustiblesSet { get; set; }
    }
}
