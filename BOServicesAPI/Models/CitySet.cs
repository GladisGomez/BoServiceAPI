using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class CitySet
    {
        public CitySet()
        {
            Addresses = new HashSet<Addresses>();
            AppointmentServiceSet = new HashSet<AppointmentServiceSet>();
            CodigoPostalSet = new HashSet<CodigoPostalSet>();
            DatosFiscalesSet = new HashSet<DatosFiscalesSet>();
            EmisorSet = new HashSet<EmisorSet>();
            ExpedidoEnSet = new HashSet<ExpedidoEnSet>();
            LocalidadSet = new HashSet<LocalidadSet>();
            MunicipioSet = new HashSet<MunicipioSet>();
            TechnicalEmployeeSet = new HashSet<TechnicalEmployeeSet>();
        }

        public int Id { get; set; }
        public string NameCity { get; set; }
        public string CveEst { get; set; }
        public bool Activo { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? CountryCity { get; set; }
        public int? CityReceptor { get; set; }

        public virtual ReceptorSet CityReceptorNavigation { get; set; }
        public virtual Countries CountryCityNavigation { get; set; }
        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<AppointmentServiceSet> AppointmentServiceSet { get; set; }
        public virtual ICollection<CodigoPostalSet> CodigoPostalSet { get; set; }
        public virtual ICollection<DatosFiscalesSet> DatosFiscalesSet { get; set; }
        public virtual ICollection<EmisorSet> EmisorSet { get; set; }
        public virtual ICollection<ExpedidoEnSet> ExpedidoEnSet { get; set; }
        public virtual ICollection<LocalidadSet> LocalidadSet { get; set; }
        public virtual ICollection<MunicipioSet> MunicipioSet { get; set; }
        public virtual ICollection<TechnicalEmployeeSet> TechnicalEmployeeSet { get; set; }
    }
}
