using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class CustomStickersTrakings
    {
        public int Id { get; set; }
        public string Sid { get; set; }
        public string Sidpers { get; set; }
        public string Uid { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public byte[] RowVersion { get; set; }
        public int? CustomStickersTrakingCustomSticker { get; set; }
        public int? CustomStickersTrakingCatCustomStickersStatus { get; set; }
        public int? CustomStickersTrakingCatCustomStickersModel { get; set; }
        public int? CustomStickersTrakingTag { get; set; }
        public int CustomStickersTrakingUserWeb { get; set; }
        public string Po { get; set; }
        public string CatalogNumber { get; set; }
        public string Operation { get; set; }
        public string Lot { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual CatCustomStickersModels CustomStickersTrakingCatCustomStickersModelNavigation { get; set; }
        public virtual CatCustomStickersStatusSet CustomStickersTrakingCatCustomStickersStatusNavigation { get; set; }
        public virtual CustomStickers CustomStickersTrakingCustomStickerNavigation { get; set; }
        public virtual Tags CustomStickersTrakingTagNavigation { get; set; }
        public virtual UserWebSet CustomStickersTrakingUserWebNavigation { get; set; }
    }
}
