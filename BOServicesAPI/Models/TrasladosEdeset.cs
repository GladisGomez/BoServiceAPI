using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TrasladosEdeset
    {
        public int Id { get; set; }
        public string Impuesto { get; set; }
        public decimal TasaOcuota { get; set; }
        public decimal Importe { get; set; }
        public decimal BaseVer33 { get; set; }
        public string TipoFactorVer33 { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int ImpuetosTrasladadosEdeTrasladosEde { get; set; }

        public virtual ImpuetosTrasladadosEdeset ImpuetosTrasladadosEdeTrasladosEdeNavigation { get; set; }
    }
}
