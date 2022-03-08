using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ViewsWebSet
    {
        public ViewsWebSet()
        {
            PermissionsWebSet = new HashSet<PermissionsWebSet>();
            ViewsCtrlsWebSet = new HashSet<ViewsCtrlsWebSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? Order { get; set; }
        public bool? Visible { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ControllerWebViewsWeb { get; set; }

        public virtual ControllerWebSet ControllerWebViewsWebNavigation { get; set; }
        public virtual ICollection<PermissionsWebSet> PermissionsWebSet { get; set; }
        public virtual ICollection<ViewsCtrlsWebSet> ViewsCtrlsWebSet { get; set; }
    }
}
