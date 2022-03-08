using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class CatCustomStickersStatusSet
    {
        public CatCustomStickersStatusSet()
        {
            CustomStickers = new HashSet<CustomStickers>();
            CustomStickers59Produccion = new HashSet<CustomStickers59Produccion>();
            CustomStickersProd2300 = new HashSet<CustomStickersProd2300>();
            CustomStickersTrakings = new HashSet<CustomStickersTrakings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<CustomStickers> CustomStickers { get; set; }
        public virtual ICollection<CustomStickers59Produccion> CustomStickers59Produccion { get; set; }
        public virtual ICollection<CustomStickersProd2300> CustomStickersProd2300 { get; set; }
        public virtual ICollection<CustomStickersTrakings> CustomStickersTrakings { get; set; }
    }
}
