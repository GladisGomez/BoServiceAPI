using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ControlsWebSet
    {
        public ControlsWebSet()
        {
            ControlPermissionsWebSet = new HashSet<ControlPermissionsWebSet>();
            ViewsCtrlsWebSet = new HashSet<ViewsCtrlsWebSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<ControlPermissionsWebSet> ControlPermissionsWebSet { get; set; }
        public virtual ICollection<ViewsCtrlsWebSet> ViewsCtrlsWebSet { get; set; }
    }
}
