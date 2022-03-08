using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class InventaryTagSet
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string Model { get; set; }
        public string Uuid { get; set; }
        public string Sid { get; set; }
        public bool IsInstaller { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int InventaryTagEmployee { get; set; }

        public virtual Employees InventaryTagEmployeeNavigation { get; set; }
    }
}
