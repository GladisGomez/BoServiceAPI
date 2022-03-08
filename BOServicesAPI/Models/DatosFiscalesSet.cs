using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DatosFiscalesSet
    {
        public DatosFiscalesSet()
        {
            ArchivosDatosFiscalesSet = new HashSet<ArchivosDatosFiscalesSet>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public int NumeroDeCuenta { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string NoInterior { get; set; }
        public string NoExterior { get; set; }
        public string Localidad { get; set; }
        public string Municipio { get; set; }
        public string CuentaBancaria { get; set; }
        public string ObservationsBilling { get; set; }
        public string Rfcperson { get; set; }
        public string NamePerson { get; set; }
        public bool Pm { get; set; }
        public bool Pf { get; set; }
        public string Curp { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int DataBillingCity1 { get; set; }
        public int? DataBillingClientGroup1 { get; set; }
        public int DatosFiscalesCodigoPostal { get; set; }
        public int DataBillingCountry { get; set; }
        public int? DataBillingGasStation1 { get; set; }
        public int? DatosFiscalesLocalidad { get; set; }
        public int? DatosFiscalesMunicipio { get; set; }

        public virtual CitySet DataBillingCity1Navigation { get; set; }
        public virtual ClientGroups DataBillingClientGroup1Navigation { get; set; }
        public virtual Countries DataBillingCountryNavigation { get; set; }
        public virtual GasStations DataBillingGasStation1Navigation { get; set; }
        public virtual CodigoPostalSet DatosFiscalesCodigoPostalNavigation { get; set; }
        public virtual LocalidadSet DatosFiscalesLocalidadNavigation { get; set; }
        public virtual MunicipioSet DatosFiscalesMunicipioNavigation { get; set; }
        public virtual ICollection<ArchivosDatosFiscalesSet> ArchivosDatosFiscalesSet { get; set; }
    }
}
