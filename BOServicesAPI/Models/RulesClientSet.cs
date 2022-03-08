using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class RulesClientSet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int RulesClientClientGroup { get; set; }
        public int RulesClientRules { get; set; }
        public int? RulesClientUserWeb { get; set; }

        public virtual ClientGroups RulesClientClientGroupNavigation { get; set; }
        public virtual RulesSet RulesClientRulesNavigation { get; set; }
        public virtual UserWebSet RulesClientUserWebNavigation { get; set; }
    }
}
