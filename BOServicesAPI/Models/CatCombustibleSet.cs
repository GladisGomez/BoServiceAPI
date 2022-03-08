using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class CatCombustibleSet
    {
        public CatCombustibleSet()
        {
            ProductCodeSet = new HashSet<ProductCodeSet>();
        }

        public int Id { get; set; }
        public string TipoCombustible { get; set; }
        public string CClaveTipoCombustible { get; set; }
        public bool Estatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<ProductCodeSet> ProductCodeSet { get; set; }
    }
}
