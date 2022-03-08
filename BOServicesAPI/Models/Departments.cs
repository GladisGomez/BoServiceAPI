using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Departments
    {
        public Departments()
        {
            CallRecordSet = new HashSet<CallRecordSet>();
            Employees = new HashSet<Employees>();
            MalfunctionReports = new HashSet<MalfunctionReports>();
            TicketEventsSet = new HashSet<TicketEventsSet>();
            TicketSet = new HashSet<TicketSet>();
            TypeOfServiceByAreaSet = new HashSet<TypeOfServiceByAreaSet>();
            TypeOfTicketSet = new HashSet<TypeOfTicketSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string DepartmentName { get; set; }
        public string Area { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<CallRecordSet> CallRecordSet { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<MalfunctionReports> MalfunctionReports { get; set; }
        public virtual ICollection<TicketEventsSet> TicketEventsSet { get; set; }
        public virtual ICollection<TicketSet> TicketSet { get; set; }
        public virtual ICollection<TypeOfServiceByAreaSet> TypeOfServiceByAreaSet { get; set; }
        public virtual ICollection<TypeOfTicketSet> TypeOfTicketSet { get; set; }
    }
}
