using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class CustomStickersProd2300
    {
        public long Id { get; set; }
        public string Sid { get; set; }
        public string Sidpers { get; set; }
        public string Uid { get; set; }
        public int IdStatus { get; set; }
        public int? IdTag { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual CatCustomStickersStatusSet IdStatusNavigation { get; set; }
    }
}
