using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryMetersSet
    {
        public int Id { get; set; }
        public int? IdMeter { get; set; }
        public string Serial { get; set; }
        public string FolioTheService { get; set; }
        public string Connector { get; set; }
        public DateTime? ServiceDataTime { get; set; }
        public bool? Active { get; set; }
        public DateTime? ActivationDateTime { get; set; }
        public string Comments { get; set; }
        public string RevisionMeterCollection { get; set; }
        public string ActionTransac { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int HistoryMetersEmployee { get; set; }
        public int HistoryMetersMeterType { get; set; }
        public int? HistoryMetersReplacementReason { get; set; }
        public int HistoryMetersTreatmentType { get; set; }
        public int? HistoryMetersVehicle { get; set; }

        public virtual Employees HistoryMetersEmployeeNavigation { get; set; }
        public virtual MeterTypes HistoryMetersMeterTypeNavigation { get; set; }
        public virtual ReplacementReasons HistoryMetersReplacementReasonNavigation { get; set; }
        public virtual TreatmentTypes HistoryMetersTreatmentTypeNavigation { get; set; }
        public virtual Vehicles HistoryMetersVehicleNavigation { get; set; }
    }
}
