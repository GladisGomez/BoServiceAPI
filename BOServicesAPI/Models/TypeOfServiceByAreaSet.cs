using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TypeOfServiceByAreaSet
    {
        public TypeOfServiceByAreaSet()
        {
            OrderOfServiceSet = new HashSet<OrderOfServiceSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ShowInSite { get; set; }
        public bool GenerateAppointment { get; set; }
        public decimal? EstimatedTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? TypeOfServiceByAreaDepartment { get; set; }

        public virtual Departments TypeOfServiceByAreaDepartmentNavigation { get; set; }
        public virtual ICollection<OrderOfServiceSet> OrderOfServiceSet { get; set; }
    }
}
