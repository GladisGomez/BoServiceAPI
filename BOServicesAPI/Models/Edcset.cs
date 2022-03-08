using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Edcset
    {
        public Edcset()
        {
            AllCfdiSet = new HashSet<AllCfdiSet>();
            BillingSet = new HashSet<BillingSet>();
            DepositosSet = new HashSet<DepositosSet>();
            EstadoDeCuentaCombustibleSet = new HashSet<EstadoDeCuentaCombustibleSet>();
            SaldosSet = new HashSet<SaldosSet>();
        }

        public int Id { get; set; }
        public int Folio { get; set; }
        public bool ConnectedToCfdi { get; set; }
        public bool Edccomplete { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? EdcomplementoEdc { get; set; }
        public int? EdcImpuestoTrasladadoEdc { get; set; }
        public int? EdcEmisor { get; set; }
        public int? EdcEncabezadoEstadoCuenta { get; set; }
        public int? EdcReceptor { get; set; }
        public int? EdcTimbreFiscal { get; set; }

        public virtual EmisorSet EdcEmisorNavigation { get; set; }
        public virtual EncabezadoEstadoCuentaSet EdcEncabezadoEstadoCuentaNavigation { get; set; }
        public virtual ImpuestoTrasladadoEdcset EdcImpuestoTrasladadoEdcNavigation { get; set; }
        public virtual ReceptorSet EdcReceptorNavigation { get; set; }
        public virtual TimbreFiscalSet EdcTimbreFiscalNavigation { get; set; }
        public virtual EdcomplementoSet EdcomplementoEdcNavigation { get; set; }
        public virtual ICollection<AllCfdiSet> AllCfdiSet { get; set; }
        public virtual ICollection<BillingSet> BillingSet { get; set; }
        public virtual ICollection<DepositosSet> DepositosSet { get; set; }
        public virtual ICollection<EstadoDeCuentaCombustibleSet> EstadoDeCuentaCombustibleSet { get; set; }
        public virtual ICollection<SaldosSet> SaldosSet { get; set; }
    }
}
