using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class BillingSet
    {
        public BillingSet()
        {
            DepositosSet = new HashSet<DepositosSet>();
            DispatchSetBillingDispatchNavigation = new HashSet<DispatchSet>();
            DispatchSetDispatchBillingNavigation = new HashSet<DispatchSet>();
            FeeCommisionSet = new HashSet<FeeCommisionSet>();
            PagosEstacionSet = new HashSet<PagosEstacionSet>();
        }

        public int Id { get; set; }
        public DateTime FechaEjecucion { get; set; }
        public DateTime FechaTimbrado { get; set; }
        public DateTime FechaPeriodoInicio { get; set; }
        public DateTime FechaPeriodaFin { get; set; }
        public int TimbroCorrecto { get; set; }
        public bool Cancelada { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public string Comentarios { get; set; }
        public string Errores { get; set; }
        public decimal? TotalComisionEde { get; set; }
        public decimal? TotalIvacomisionEde { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? BillingClientGroup { get; set; }
        public int? BillingEdc { get; set; }
        public int? BillingEde { get; set; }
        public int? BillingGasStation { get; set; }
        public int? BillingRelacionEdccliente { get; set; }

        public virtual ClientGroups BillingClientGroupNavigation { get; set; }
        public virtual Edcset BillingEdcNavigation { get; set; }
        public virtual Edeset BillingEdeNavigation { get; set; }
        public virtual GasStations BillingGasStationNavigation { get; set; }
        public virtual RelacionEdcclienteSet BillingRelacionEdcclienteNavigation { get; set; }
        public virtual ICollection<DepositosSet> DepositosSet { get; set; }
        public virtual ICollection<DispatchSet> DispatchSetBillingDispatchNavigation { get; set; }
        public virtual ICollection<DispatchSet> DispatchSetDispatchBillingNavigation { get; set; }
        public virtual ICollection<FeeCommisionSet> FeeCommisionSet { get; set; }
        public virtual ICollection<PagosEstacionSet> PagosEstacionSet { get; set; }
    }
}
