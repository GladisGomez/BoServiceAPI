using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Employees
    {
        public Employees()
        {
            AppointmentServiceSet = new HashSet<AppointmentServiceSet>();
            CallRecordSet = new HashSet<CallRecordSet>();
            ChangeRequestPlateSet = new HashSet<ChangeRequestPlateSet>();
            ClientGroups = new HashSet<ClientGroups>();
            ConnectionByStationsSet = new HashSet<ConnectionByStationsSet>();
            ContingencySetContingencyEmployee1Navigation = new HashSet<ContingencySet>();
            ContingencySetContingencyEmployeeNavigation = new HashSet<ContingencySet>();
            ControlPrintTargetSet = new HashSet<ControlPrintTargetSet>();
            DepositosSet = new HashSet<DepositosSet>();
            EmployeesAppointmentSet = new HashSet<EmployeesAppointmentSet>();
            FsGetInfoSet = new HashSet<FsGetInfoSet>();
            GpsOdometerSet = new HashSet<GpsOdometerSet>();
            GpsSetGpsEmployee1Navigation = new HashSet<GpsSet>();
            GpsSetGpsEmployeeNavigation = new HashSet<GpsSet>();
            HistoryGpsSet = new HashSet<HistoryGpsSet>();
            HistoryMetersSet = new HashSet<HistoryMetersSet>();
            HistoryTags = new HashSet<HistoryTags>();
            InventaryTagSet = new HashSet<InventaryTagSet>();
            Meters = new HashSet<Meters>();
            OfflineAccessSet = new HashSet<OfflineAccessSet>();
            OrderOfServiceSetOrderOfServiceEmployee1Navigation = new HashSet<OrderOfServiceSet>();
            OrderOfServiceSetOrderOfServiceEmployeeNavigation = new HashSet<OrderOfServiceSet>();
            PagosEstacionSet = new HashSet<PagosEstacionSet>();
            RevisionMeterSet = new HashSet<RevisionMeterSet>();
            Tags = new HashSet<Tags>();
            TestingProductsSetTestingProductsEmployee1Navigation = new HashSet<TestingProductsSet>();
            TestingProductsSetTestingProductsEmployeeNavigation = new HashSet<TestingProductsSet>();
            TicketEventsSet = new HashSet<TicketEventsSet>();
            TicketSetTicketEmployee11Navigation = new HashSet<TicketSet>();
            TicketSetTicketEmployee3Navigation = new HashSet<TicketSet>();
            TicketSetTicketEmployeeNavigation = new HashSet<TicketSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cellular { get; set; }
        public string Comments { get; set; }
        public bool TechnicalEmployee { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int EmployeeDepartment { get; set; }
        public int? EmployeeTechnicalEmployee { get; set; }

        public virtual Departments EmployeeDepartmentNavigation { get; set; }
        public virtual TechnicalEmployeeSet EmployeeTechnicalEmployeeNavigation { get; set; }
        public virtual ICollection<AppointmentServiceSet> AppointmentServiceSet { get; set; }
        public virtual ICollection<CallRecordSet> CallRecordSet { get; set; }
        public virtual ICollection<ChangeRequestPlateSet> ChangeRequestPlateSet { get; set; }
        public virtual ICollection<ClientGroups> ClientGroups { get; set; }
        public virtual ICollection<ConnectionByStationsSet> ConnectionByStationsSet { get; set; }
        public virtual ICollection<ContingencySet> ContingencySetContingencyEmployee1Navigation { get; set; }
        public virtual ICollection<ContingencySet> ContingencySetContingencyEmployeeNavigation { get; set; }
        public virtual ICollection<ControlPrintTargetSet> ControlPrintTargetSet { get; set; }
        public virtual ICollection<DepositosSet> DepositosSet { get; set; }
        public virtual ICollection<EmployeesAppointmentSet> EmployeesAppointmentSet { get; set; }
        public virtual ICollection<FsGetInfoSet> FsGetInfoSet { get; set; }
        public virtual ICollection<GpsOdometerSet> GpsOdometerSet { get; set; }
        public virtual ICollection<GpsSet> GpsSetGpsEmployee1Navigation { get; set; }
        public virtual ICollection<GpsSet> GpsSetGpsEmployeeNavigation { get; set; }
        public virtual ICollection<HistoryGpsSet> HistoryGpsSet { get; set; }
        public virtual ICollection<HistoryMetersSet> HistoryMetersSet { get; set; }
        public virtual ICollection<HistoryTags> HistoryTags { get; set; }
        public virtual ICollection<InventaryTagSet> InventaryTagSet { get; set; }
        public virtual ICollection<Meters> Meters { get; set; }
        public virtual ICollection<OfflineAccessSet> OfflineAccessSet { get; set; }
        public virtual ICollection<OrderOfServiceSet> OrderOfServiceSetOrderOfServiceEmployee1Navigation { get; set; }
        public virtual ICollection<OrderOfServiceSet> OrderOfServiceSetOrderOfServiceEmployeeNavigation { get; set; }
        public virtual ICollection<PagosEstacionSet> PagosEstacionSet { get; set; }
        public virtual ICollection<RevisionMeterSet> RevisionMeterSet { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
        public virtual ICollection<TestingProductsSet> TestingProductsSetTestingProductsEmployee1Navigation { get; set; }
        public virtual ICollection<TestingProductsSet> TestingProductsSetTestingProductsEmployeeNavigation { get; set; }
        public virtual ICollection<TicketEventsSet> TicketEventsSet { get; set; }
        public virtual ICollection<TicketSet> TicketSetTicketEmployee11Navigation { get; set; }
        public virtual ICollection<TicketSet> TicketSetTicketEmployee3Navigation { get; set; }
        public virtual ICollection<TicketSet> TicketSetTicketEmployeeNavigation { get; set; }
    }
}
