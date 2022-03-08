using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Addresses = new HashSet<Addresses>();
            CitySet = new HashSet<CitySet>();
            DatosFiscalesSet = new HashSet<DatosFiscalesSet>();
            EmisorSet = new HashSet<EmisorSet>();
            ExpedidoEnSet = new HashSet<ExpedidoEnSet>();
            TimeZoneCset = new HashSet<TimeZoneCset>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Name { get; set; }
        public string CodCountry { get; set; }
        public string CvePais { get; set; }
        public bool Activo { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<CitySet> CitySet { get; set; }
        public virtual ICollection<DatosFiscalesSet> DatosFiscalesSet { get; set; }
        public virtual ICollection<EmisorSet> EmisorSet { get; set; }
        public virtual ICollection<ExpedidoEnSet> ExpedidoEnSet { get; set; }
        public virtual ICollection<TimeZoneCset> TimeZoneCset { get; set; }
    }
}
