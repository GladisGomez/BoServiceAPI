using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TypeOfTicketSet
    {
        public TypeOfTicketSet()
        {
            TicketCloseRolSet = new HashSet<TicketCloseRolSet>();
            TicketSet = new HashSet<TicketSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripción { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int TypeOfTicketDepartment { get; set; }

        public virtual Departments TypeOfTicketDepartmentNavigation { get; set; }
        public virtual ICollection<TicketCloseRolSet> TicketCloseRolSet { get; set; }
        public virtual ICollection<TicketSet> TicketSet { get; set; }
    }
}
