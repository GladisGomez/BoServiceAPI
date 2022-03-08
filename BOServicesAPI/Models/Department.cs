using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class Department
    {
        public Department()
        {
            CallRecordSets = new HashSet<CallRecordSet>();
            Employees = new HashSet<Employee>();
            MalfunctionReports = new HashSet<MalfunctionReport>();
            TicketEventsSets = new HashSet<TicketEventsSet>();
            TicketSets = new HashSet<TicketSet>();
            TypeOfServiceByAreaSets = new HashSet<TypeOfServiceByAreaSet>();
            TypeOfTicketSets = new HashSet<TypeOfTicketSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string DepartmentName { get; set; }
        public string Area { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<CallRecordSet> CallRecordSets { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<MalfunctionReport> MalfunctionReports { get; set; }
        public virtual ICollection<TicketEventsSet> TicketEventsSets { get; set; }
        public virtual ICollection<TicketSet> TicketSets { get; set; }
        public virtual ICollection<TypeOfServiceByAreaSet> TypeOfServiceByAreaSets { get; set; }
        public virtual ICollection<TypeOfTicketSet> TypeOfTicketSets { get; set; }
    }
}
