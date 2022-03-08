using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ApplicationHistorySet
    {
        public int Id { get; set; }
        public string ChangeType { get; set; }
        public string OriginalValues { get; set; }
        public string NewValues { get; set; }
        public DateTime DateTimeOperation { get; set; }
        public DateTime Inserted { get; set; }
        public string AppOrigen { get; set; }
        public string ReferenceType { get; set; }
        public string Modulo { get; set; }
        public int? ClientGroupId { get; set; }
        public int? ClientId { get; set; }
        public int? VehicleId { get; set; }
        public int? IsParentId { get; set; }
        public int? TankId { get; set; }
        public int? TagId { get; set; }
        public int? MeterId { get; set; }
        public int? GpsId { get; set; }
        public int? SimId { get; set; }
        public int? GasStationGroupId { get; set; }
        public int? GasStationId { get; set; }
        public int? FuelSetId { get; set; }
        public int? AntennaId { get; set; }
        public int? ReaderId { get; set; }
        public int? BatteryId { get; set; }
        public int? ExtraActivityId { get; set; }
        public int? EmployeeId { get; set; }
        public int? UserId { get; set; }
        public int? ProfileId { get; set; }
        public int? PermissionsWebId { get; set; }
        public int? RuleId { get; set; }
        public int? DispatchId { get; set; }
        public int? ContingencyId { get; set; }
        public int? FuelTypeId { get; set; }
        public int? BillingId { get; set; }
        public int? DepositosId { get; set; }
        public int? CentroCostosId { get; set; }
        public int? PagoEstacionesId { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
