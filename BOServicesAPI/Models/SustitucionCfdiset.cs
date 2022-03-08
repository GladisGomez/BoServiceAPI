using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class SustitucionCfdiset
    {
        public int Id { get; set; }
        public string Serie { get; set; }
        public int IdBillingSustitucion { get; set; }
        public string IdBillingNuevo { get; set; }
        public string FolioSustitucion { get; set; }
        public string FolioNuevo { get; set; }
        public string Uuidsustitucion { get; set; }
        public string Uuidnuevo { get; set; }
        public DateTime FechaSustitucion { get; set; }
        public string TipoOperacion { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
