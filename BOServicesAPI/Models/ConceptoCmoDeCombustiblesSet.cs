using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ConceptoCmoDeCombustiblesSet
    {
        public int Id { get; set; }
        public string Identificador { get; set; }
        public DateTime Fecha { get; set; }
        public string Rfc { get; set; }
        public string ClaveEstacion { get; set; }
        public decimal Cantidad { get; set; }
        public string NombreCombustible { get; set; }
        public string FolioOperacion { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Importe { get; set; }
        public string ImpuestoIva { get; set; }
        public decimal TasaIva { get; set; }
        public decimal ImporteIva { get; set; }
        public string ImpuestoIeps { get; set; }
        public decimal CuotaIeps { get; set; }
        public decimal ImporteIeps { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? EdcomplementoConceptoCmoDeCombustibles { get; set; }

        public virtual EdcomplementoSet EdcomplementoConceptoCmoDeCombustiblesNavigation { get; set; }
    }
}
