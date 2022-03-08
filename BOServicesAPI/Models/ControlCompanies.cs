using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ControlCompanies
    {
        public ControlCompanies()
        {
            ClientGroups = new HashSet<ClientGroups>();
            DesignTemplateWeb = new HashSet<DesignTemplateWeb>();
            DesignTemplateWebs = new HashSet<DesignTemplateWebs>();
            UserWebSet = new HashSet<UserWebSet>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ControlCompanyClientGroup1 { get; set; }

        public virtual ClientGroups ControlCompanyClientGroup1Navigation { get; set; }
        public virtual ICollection<ClientGroups> ClientGroups { get; set; }
        public virtual ICollection<DesignTemplateWeb> DesignTemplateWeb { get; set; }
        public virtual ICollection<DesignTemplateWebs> DesignTemplateWebs { get; set; }
        public virtual ICollection<UserWebSet> UserWebSet { get; set; }
    }
}
