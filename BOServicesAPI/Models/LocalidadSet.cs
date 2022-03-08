using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class LocalidadSet
    {
        public LocalidadSet()
        {
            DatosFiscalesSet = new HashSet<DatosFiscalesSet>();
        }

        public int Id { get; set; }
        public string CveLoc { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? LocalidadCity { get; set; }

        public virtual CitySet LocalidadCityNavigation { get; set; }
        public virtual ICollection<DatosFiscalesSet> DatosFiscalesSet { get; set; }
    }
}
