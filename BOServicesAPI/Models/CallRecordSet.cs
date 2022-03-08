using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class CallRecordSet
    {
        public int Id { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public string NameOfPeople { get; set; }
        public string Comments { get; set; }
        public string PhoneSource { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int CallRecordEmployee { get; set; }
        public int CallRecordStatusCall { get; set; }
        public int? CallRecordClientGroup { get; set; }
        public int? CallRecordClient { get; set; }
        public int? CallRecordContingency { get; set; }
        public int CallRecordDepartment { get; set; }
        public int? CallRecordGasStation { get; set; }
        public int CallRecordTypeCall { get; set; }
        public int CallRecordTypeIdentifier { get; set; }
        public int? CallRecordVehicle { get; set; }

        public virtual ClientGroups CallRecordClientGroupNavigation { get; set; }
        public virtual Clients CallRecordClientNavigation { get; set; }
        public virtual ContingencySet CallRecordContingencyNavigation { get; set; }
        public virtual Departments CallRecordDepartmentNavigation { get; set; }
        public virtual Employees CallRecordEmployeeNavigation { get; set; }
        public virtual GasStations CallRecordGasStationNavigation { get; set; }
        public virtual StatusCallSet CallRecordStatusCallNavigation { get; set; }
        public virtual TypeCallSet CallRecordTypeCallNavigation { get; set; }
        public virtual TypeIdentifierSet CallRecordTypeIdentifierNavigation { get; set; }
        public virtual Vehicles CallRecordVehicleNavigation { get; set; }
    }
}
