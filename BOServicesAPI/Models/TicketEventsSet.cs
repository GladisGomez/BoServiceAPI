using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TicketEventsSet
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public DateTime? DateReporte { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int TicketEventsDepartment { get; set; }
        public int TicketEventsDiagnosticTicketSetItem { get; set; }
        public int TicketEventsEmployee { get; set; }
        public int TicketEventsTaskPriority { get; set; }
        public int? TicketEventsVehicle { get; set; }
        public int? TicketEventsGasStation { get; set; }
        public int? TicketTicketEvents { get; set; }

        public virtual Departments TicketEventsDepartmentNavigation { get; set; }
        public virtual DiagnosticTicketSet TicketEventsDiagnosticTicketSetItemNavigation { get; set; }
        public virtual Employees TicketEventsEmployeeNavigation { get; set; }
        public virtual GasStations TicketEventsGasStationNavigation { get; set; }
        public virtual TaskPrioritySet TicketEventsTaskPriorityNavigation { get; set; }
        public virtual Vehicles TicketEventsVehicleNavigation { get; set; }
        public virtual TicketSet TicketTicketEventsNavigation { get; set; }
    }
}
