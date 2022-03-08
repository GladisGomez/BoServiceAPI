using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryTag
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public int? IdTag { get; set; }
        public string Sid { get; set; }
        public string Uid { get; set; }
        public string FolioTheService { get; set; }
        public bool? WithNth { get; set; }
        public bool? Active { get; set; }
        public DateTime? ServiceDataTime { get; set; }
        public string Comments { get; set; }
        public DateTime? ActivationDateTime { get; set; }
        public int? CapacidadTanque { get; set; }
        public string SerialMeter { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string ActionTransac { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int HistoryTagEmployee { get; set; }
        public int? HistoryTagGasStation { get; set; }
        public int? HistoryTagReplacementReason { get; set; }
        public int HistoryTagTagType { get; set; }
        public int? HistoryTagTankIdentifier { get; set; }
        public int HistoryTagTreatmentType { get; set; }
        public int? HistoryTagVehicle { get; set; }

        public virtual Employee HistoryTagEmployeeNavigation { get; set; }
        public virtual GasStation HistoryTagGasStationNavigation { get; set; }
        public virtual ReplacementReason HistoryTagReplacementReasonNavigation { get; set; }
        public virtual TagType HistoryTagTagTypeNavigation { get; set; }
        public virtual TankIdentifier HistoryTagTankIdentifierNavigation { get; set; }
        public virtual TreatmentType HistoryTagTreatmentTypeNavigation { get; set; }
        public virtual Vehicle HistoryTagVehicleNavigation { get; set; }
    }
}
