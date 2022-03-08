using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ExpedidoEnSet
    {
        public ExpedidoEnSet()
        {
            EmisorSet = new HashSet<EmisorSet>();
        }

        public int Id { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public int CodigoPostal { get; set; }
        public string Pais { get; set; }
        public string Referencia { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ExpedidoEnCity { get; set; }
        public int? ExpedidoEnCodigoPostal { get; set; }
        public int? CountryExpedidoEn { get; set; }
        public int? MunicipioExpedidoEn { get; set; }

        public virtual Countries CountryExpedidoEnNavigation { get; set; }
        public virtual CitySet ExpedidoEnCityNavigation { get; set; }
        public virtual CodigoPostalSet ExpedidoEnCodigoPostalNavigation { get; set; }
        public virtual MunicipioSet MunicipioExpedidoEnNavigation { get; set; }
        public virtual ICollection<EmisorSet> EmisorSet { get; set; }
    }
}
