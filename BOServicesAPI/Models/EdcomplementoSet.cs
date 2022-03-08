using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class EdcomplementoSet
    {
        public EdcomplementoSet()
        {
            ConceptoCmoDeCombustiblesSet = new HashSet<ConceptoCmoDeCombustiblesSet>();
            ConceptoEdoCtaCombustibleSet = new HashSet<ConceptoEdoCtaCombustibleSet>();
            ConceptosEdset = new HashSet<ConceptosEdset>();
            Edcset = new HashSet<Edcset>();
            Edeset = new HashSet<Edeset>();
        }

        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<ConceptoCmoDeCombustiblesSet> ConceptoCmoDeCombustiblesSet { get; set; }
        public virtual ICollection<ConceptoEdoCtaCombustibleSet> ConceptoEdoCtaCombustibleSet { get; set; }
        public virtual ICollection<ConceptosEdset> ConceptosEdset { get; set; }
        public virtual ICollection<Edcset> Edcset { get; set; }
        public virtual ICollection<Edeset> Edeset { get; set; }
    }
}
