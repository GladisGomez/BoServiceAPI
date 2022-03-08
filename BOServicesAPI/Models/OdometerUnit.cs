using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class OdometerUnit
    {
        public OdometerUnit()
        {
            BrandModels = new HashSet<BrandModel>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Unit { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<BrandModel> BrandModels { get; set; }
    }
}
