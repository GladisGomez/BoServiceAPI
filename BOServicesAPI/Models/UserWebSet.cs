using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class UserWebSet
    {
        public UserWebSet()
        {
            AuditWebSet = new HashSet<AuditWebSet>();
            CustomStickersTrakings = new HashSet<CustomStickersTrakings>();
            ProfileSet = new HashSet<ProfileSet>();
            RolesWebSet = new HashSet<RolesWebSet>();
            RulesClientSet = new HashSet<RulesClientSet>();
            UsersInClientGroupSet = new HashSet<UsersInClientGroupSet>();
            UsersInProfileSet = new HashSet<UsersInProfileSet>();
            UsersInRolesWebSet = new HashSet<UsersInRolesWebSet>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public bool? SubUser { get; set; }
        public int? ParentId { get; set; }
        public bool IsGps { get; set; }
        public bool ChangePsw { get; set; }
        public bool? IsEditQv { get; set; }
        public string CodigoVerificacion { get; set; }
        public DateTime? EnvioCodigoVerificacion { get; set; }
        public DateTime? AltaAccesoQv { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? UserWebControlCompany { get; set; }

        public virtual ControlCompanies UserWebControlCompanyNavigation { get; set; }
        public virtual ICollection<AuditWebSet> AuditWebSet { get; set; }
        public virtual ICollection<CustomStickersTrakings> CustomStickersTrakings { get; set; }
        public virtual ICollection<ProfileSet> ProfileSet { get; set; }
        public virtual ICollection<RolesWebSet> RolesWebSet { get; set; }
        public virtual ICollection<RulesClientSet> RulesClientSet { get; set; }
        public virtual ICollection<UsersInClientGroupSet> UsersInClientGroupSet { get; set; }
        public virtual ICollection<UsersInProfileSet> UsersInProfileSet { get; set; }
        public virtual ICollection<UsersInRolesWebSet> UsersInRolesWebSet { get; set; }
    }
}
