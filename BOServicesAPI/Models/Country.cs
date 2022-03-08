using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class Country
    {
        public Country()
        {
            Addresses = new HashSet<Address>();
            CitySets = new HashSet<CitySet>();
            DatosFiscalesSets = new HashSet<DatosFiscalesSet>();
            EmisorSets = new HashSet<EmisorSet>();
            ExpedidoEnSets = new HashSet<ExpedidoEnSet>();
            TimeZoneCsets = new HashSet<TimeZoneCset>();
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

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CitySet> CitySets { get; set; }
        public virtual ICollection<DatosFiscalesSet> DatosFiscalesSets { get; set; }
        public virtual ICollection<EmisorSet> EmisorSets { get; set; }
        public virtual ICollection<ExpedidoEnSet> ExpedidoEnSets { get; set; }
        public virtual ICollection<TimeZoneCset> TimeZoneCsets { get; set; }
    }
}
