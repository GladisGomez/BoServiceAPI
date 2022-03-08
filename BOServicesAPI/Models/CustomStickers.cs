using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class CustomStickers
    {
        public CustomStickers()
        {
            CustomStickersTrakings = new HashSet<CustomStickersTrakings>();
        }

        public int Id { get; set; }
        public string Sid { get; set; }
        public string Sidpers { get; set; }
        public string Uid { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? CustomStickerCatCustomStickersModel { get; set; }
        public int? CustomStickerCatCustomStickersStatus { get; set; }
        public int? CustomStickerTag { get; set; }
        public int CustomStickerUserWeb { get; set; }
        public string Po { get; set; }
        public string CatalogNumber { get; set; }
        public string Lot { get; set; }

        public virtual CatCustomStickersModels CustomStickerCatCustomStickersModelNavigation { get; set; }
        public virtual CatCustomStickersStatusSet CustomStickerCatCustomStickersStatusNavigation { get; set; }
        public virtual Tags CustomStickerTagNavigation { get; set; }
        public virtual ICollection<CustomStickersTrakings> CustomStickersTrakings { get; set; }
    }
}
