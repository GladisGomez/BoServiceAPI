using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TicketSet
    {
        public TicketSet()
        {
            AttachFilesSet = new HashSet<AttachFilesSet>();
            Tags = new HashSet<Tags>();
            TicketDetailMovementsSet = new HashSet<TicketDetailMovementsSet>();
            TicketEventsSet = new HashSet<TicketEventsSet>();
        }

        public int Id { get; set; }
        public int? IdError { get; set; }
        public string Comments { get; set; }
        public DateTime DateReport { get; set; }
        public DateTime? DateFinish { get; set; }
        public bool? Finish { get; set; }
        public string ComentariosCierre { get; set; }
        public string Contacto { get; set; }
        public bool? Cancel { get; set; }
        public bool? Associated { get; set; }
        public string CommentsStatusTicket { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? AppointmentServiceTicket { get; set; }
        public int? TicketClosingReasonTicket { get; set; }
        public int TicketDepartment { get; set; }
        public int? TicketDiagnosticTicketSetItem { get; set; }
        public int TicketEmployee { get; set; }
        public int? TicketEmployee11 { get; set; }
        public int? TicketEmployee3 { get; set; }
        public int? TicketGasStation { get; set; }
        public int? TicketMalfunctionReport { get; set; }
        public int? OrderOfServiceTicket1 { get; set; }
        public int? StatusTicketTicket { get; set; }
        public int? TicketTaskPriority { get; set; }
        public int? TicketVehicle { get; set; }
        public int? BatteryTicket { get; set; }
        public int? TypeOfTicketTicket { get; set; }

        public virtual AppointmentServiceSet AppointmentServiceTicketNavigation { get; set; }
        public virtual BatterySet BatteryTicketNavigation { get; set; }
        public virtual OrderOfServiceSet OrderOfServiceTicket1Navigation { get; set; }
        public virtual StatusTicketSet StatusTicketTicketNavigation { get; set; }
        public virtual ClosingReasonTicketSet TicketClosingReasonTicketNavigation { get; set; }
        public virtual Departments TicketDepartmentNavigation { get; set; }
        public virtual DiagnosticTicketSet TicketDiagnosticTicketSetItemNavigation { get; set; }
        public virtual Employees TicketEmployee11Navigation { get; set; }
        public virtual Employees TicketEmployee3Navigation { get; set; }
        public virtual Employees TicketEmployeeNavigation { get; set; }
        public virtual GasStations TicketGasStationNavigation { get; set; }
        public virtual MalfunctionReports TicketMalfunctionReportNavigation { get; set; }
        public virtual TaskPrioritySet TicketTaskPriorityNavigation { get; set; }
        public virtual Vehicles TicketVehicleNavigation { get; set; }
        public virtual TypeOfTicketSet TypeOfTicketTicketNavigation { get; set; }
        public virtual ICollection<AttachFilesSet> AttachFilesSet { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
        public virtual ICollection<TicketDetailMovementsSet> TicketDetailMovementsSet { get; set; }
        public virtual ICollection<TicketEventsSet> TicketEventsSet { get; set; }
    }
}
