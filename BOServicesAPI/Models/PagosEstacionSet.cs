using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class PagosEstacionSet
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public decimal Amount { get; set; }
        public string NumeroTransferencia { get; set; }
        public bool IsCancel { get; set; }
        public string Comentarios { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int PagosEstacionAccountGng { get; set; }
        public int? PagosEstacionBilling { get; set; }
        public int? PagosEstacionEmployee { get; set; }
        public int? PagosEstacionGasStation { get; set; }

        public virtual AccountGngSet PagosEstacionAccountGngNavigation { get; set; }
        public virtual BillingSet PagosEstacionBillingNavigation { get; set; }
        public virtual Employees PagosEstacionEmployeeNavigation { get; set; }
        public virtual GasStations PagosEstacionGasStationNavigation { get; set; }
    }
}
