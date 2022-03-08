using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class MunicipioSet
    {
        public MunicipioSet()
        {
            DatosFiscalesSet = new HashSet<DatosFiscalesSet>();
            EmisorSet = new HashSet<EmisorSet>();
            ExpedidoEnSet = new HashSet<ExpedidoEnSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string CveMun { get; set; }
        public bool Activo { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? CityMunicipio { get; set; }

        public virtual CitySet CityMunicipioNavigation { get; set; }
        public virtual ICollection<DatosFiscalesSet> DatosFiscalesSet { get; set; }
        public virtual ICollection<EmisorSet> EmisorSet { get; set; }
        public virtual ICollection<ExpedidoEnSet> ExpedidoEnSet { get; set; }
    }
}
