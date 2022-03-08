using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class EdoCtaCombustibleSet
    {
        public EdoCtaCombustibleSet()
        {
            ComplementoEdcset = new HashSet<ComplementoEdcset>();
        }

        public int Id { get; set; }
        public string TipoOperacion { get; set; }
        public string NumeroDeCuenta { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public string Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<ComplementoEdcset> ComplementoEdcset { get; set; }
    }
}
