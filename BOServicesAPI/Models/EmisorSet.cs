using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class EmisorSet
    {
        public EmisorSet()
        {
            Edcset = new HashSet<Edcset>();
            Edeset = new HashSet<Edeset>();
        }

        public int Id { get; set; }
        public string Rfc { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int CodigoPostal { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? EmisorCity { get; set; }
        public int? EmisorCodigoPostal { get; set; }
        public int? CountryEmisor { get; set; }
        public int EmisorExpedidoEn { get; set; }
        public int? EmisorMunicipio { get; set; }
        public int? EmisorRegimenFiscal1 { get; set; }

        public virtual Countries CountryEmisorNavigation { get; set; }
        public virtual CitySet EmisorCityNavigation { get; set; }
        public virtual CodigoPostalSet EmisorCodigoPostalNavigation { get; set; }
        public virtual ExpedidoEnSet EmisorExpedidoEnNavigation { get; set; }
        public virtual MunicipioSet EmisorMunicipioNavigation { get; set; }
        public virtual RegimenFiscalSet EmisorRegimenFiscal1Navigation { get; set; }
        public virtual ICollection<Edcset> Edcset { get; set; }
        public virtual ICollection<Edeset> Edeset { get; set; }
    }
}
