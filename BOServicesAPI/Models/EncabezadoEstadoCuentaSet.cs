using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class EncabezadoEstadoCuentaSet
    {
        public EncabezadoEstadoCuentaSet()
        {
            Edcset = new HashSet<Edcset>();
            Edeset = new HashSet<Edeset>();
        }

        public int Id { get; set; }
        public string Version { get; set; }
        public string Serie { get; set; }
        public DateTime Fecha { get; set; }
        public string NoCertificado { get; set; }
        public string Certificado { get; set; }
        public decimal Subtotal { get; set; }
        public string TipoCambio { get; set; }
        public decimal Total { get; set; }
        public string Sello { get; set; }
        public string LugarExpedicion { get; set; }
        public string FormaDePago { get; set; }
        public string MetodoPago { get; set; }
        public string Moneda { get; set; }
        public string TipoDeComprobante { get; set; }
        public string NumCtaPago { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<Edcset> Edcset { get; set; }
        public virtual ICollection<Edeset> Edeset { get; set; }
    }
}
