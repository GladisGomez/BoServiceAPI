using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class CustomStickersTraking
    {
        public long Id { get; set; }
        public long IdCustomStickers { get; set; }
        public string Sid { get; set; }
        public string Sidpers { get; set; }
        public string Uid { get; set; }
        public int IdStatus { get; set; }
        public int? IdTag { get; set; }
        public int? IdModels { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }

        public virtual CustomStickers IdCustomStickersNavigation { get; set; }
    }
}
