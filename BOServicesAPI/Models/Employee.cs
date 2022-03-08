using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class Employee
    {
        public Employee()
        {
            AppointmentServiceSets = new HashSet<AppointmentServiceSet>();
            CallRecordSets = new HashSet<CallRecordSet>();
            ChangeRequestPlateSets = new HashSet<ChangeRequestPlateSet>();
            ClientGroups = new HashSet<ClientGroup>();
            ConnectionByStationsSets = new HashSet<ConnectionByStationsSet>();
            ContingencySetContingencyEmployee1Navigations = new HashSet<ContingencySet>();
            ContingencySetContingencyEmployeeNavigations = new HashSet<ContingencySet>();
            ControlPrintTargetSets = new HashSet<ControlPrintTargetSet>();
            DepositosSets = new HashSet<DepositosSet>();
            EmployeesAppointmentSets = new HashSet<EmployeesAppointmentSet>();
            FsGetInfoSets = new HashSet<FsGetInfoSet>();
            GpsOdometerSets = new HashSet<GpsOdometerSet>();
            GpsSetGpsEmployee1Navigations = new HashSet<GpsSet>();
            GpsSetGpsEmployeeNavigations = new HashSet<GpsSet>();
            HistoryGpsSets = new HashSet<HistoryGpsSet>();
            HistoryMetersSets = new HashSet<HistoryMetersSet>();
            HistoryTags = new HashSet<HistoryTag>();
            InventaryTagSets = new HashSet<InventaryTagSet>();
            Meters = new HashSet<Meter>();
            OfflineAccessSets = new HashSet<OfflineAccessSet>();
            OrderOfServiceSetOrderOfServiceEmployee1Navigations = new HashSet<OrderOfServiceSet>();
            OrderOfServiceSetOrderOfServiceEmployeeNavigations = new HashSet<OrderOfServiceSet>();
            PagosEstacionSets = new HashSet<PagosEstacionSet>();
            RevisionMeterSets = new HashSet<RevisionMeterSet>();
            Tags = new HashSet<Tag>();
            TestingProductsSetTestingProductsEmployee1Navigations = new HashSet<TestingProductsSet>();
            TestingProductsSetTestingProductsEmployeeNavigations = new HashSet<TestingProductsSet>();
            TicketEventsSets = new HashSet<TicketEventsSet>();
            TicketSetTicketEmployee11Navigations = new HashSet<TicketSet>();
            TicketSetTicketEmployee3Navigations = new HashSet<TicketSet>();
            TicketSetTicketEmployeeNavigations = new HashSet<TicketSet>();
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

        public virtual Department EmployeeDepartmentNavigation { get; set; }
        public virtual TechnicalEmployeeSet EmployeeTechnicalEmployeeNavigation { get; set; }
        public virtual ICollection<AppointmentServiceSet> AppointmentServiceSets { get; set; }
        public virtual ICollection<CallRecordSet> CallRecordSets { get; set; }
        public virtual ICollection<ChangeRequestPlateSet> ChangeRequestPlateSets { get; set; }
        public virtual ICollection<ClientGroup> ClientGroups { get; set; }
        public virtual ICollection<ConnectionByStationsSet> ConnectionByStationsSets { get; set; }
        public virtual ICollection<ContingencySet> ContingencySetContingencyEmployee1Navigations { get; set; }
        public virtual ICollection<ContingencySet> ContingencySetContingencyEmployeeNavigations { get; set; }
        public virtual ICollection<ControlPrintTargetSet> ControlPrintTargetSets { get; set; }
        public virtual ICollection<DepositosSet> DepositosSets { get; set; }
        public virtual ICollection<EmployeesAppointmentSet> EmployeesAppointmentSets { get; set; }
        public virtual ICollection<FsGetInfoSet> FsGetInfoSets { get; set; }
        public virtual ICollection<GpsOdometerSet> GpsOdometerSets { get; set; }
        public virtual ICollection<GpsSet> GpsSetGpsEmployee1Navigations { get; set; }
        public virtual ICollection<GpsSet> GpsSetGpsEmployeeNavigations { get; set; }
        public virtual ICollection<HistoryGpsSet> HistoryGpsSets { get; set; }
        public virtual ICollection<HistoryMetersSet> HistoryMetersSets { get; set; }
        public virtual ICollection<HistoryTag> HistoryTags { get; set; }
        public virtual ICollection<InventaryTagSet> InventaryTagSets { get; set; }
        public virtual ICollection<Meter> Meters { get; set; }
        public virtual ICollection<OfflineAccessSet> OfflineAccessSets { get; set; }
        public virtual ICollection<OrderOfServiceSet> OrderOfServiceSetOrderOfServiceEmployee1Navigations { get; set; }
        public virtual ICollection<OrderOfServiceSet> OrderOfServiceSetOrderOfServiceEmployeeNavigations { get; set; }
        public virtual ICollection<PagosEstacionSet> PagosEstacionSets { get; set; }
        public virtual ICollection<RevisionMeterSet> RevisionMeterSets { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<TestingProductsSet> TestingProductsSetTestingProductsEmployee1Navigations { get; set; }
        public virtual ICollection<TestingProductsSet> TestingProductsSetTestingProductsEmployeeNavigations { get; set; }
        public virtual ICollection<TicketEventsSet> TicketEventsSets { get; set; }
        public virtual ICollection<TicketSet> TicketSetTicketEmployee11Navigations { get; set; }
        public virtual ICollection<TicketSet> TicketSetTicketEmployee3Navigations { get; set; }
        public virtual ICollection<TicketSet> TicketSetTicketEmployeeNavigations { get; set; }
    }
}
