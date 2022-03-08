using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class DesignTemplateWebs
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Description { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public string ButtonHeaderColor { get; set; }
        public string FontColorByReports { get; set; }
        public string NavBarColor { get; set; }
        public string PathLogoLogin { get; set; }
        public string PathLogoHeader { get; set; }
        public string PathImagenIndex { get; set; }
        public string PathIconFacebook { get; set; }
        public string PathIconLinkedin { get; set; }
        public string PathImagenUserFace { get; set; }
        public string PathImagenLoading { get; set; }
        public string PathImagenTruck { get; set; }
        public string PathImagenReports { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? DesignTemplateWebControlCompany1 { get; set; }

        public virtual ControlCompanies DesignTemplateWebControlCompany1Navigation { get; set; }
    }
}
