using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    public class AuxVehicles
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public string EcoNumber { get; set; }
        public string StickerAsociado { get; set; }
        public string WithSticker { get; set; }

        public string SID { get; set; }
        public string TagOrStickerActive { get; set; }
    }

    public class VehicleData
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public string Vin { get; set; }
        public string EcoNumber { get; set; }
        public int PublicId { get; set; }
        public int YearModel { get; set; }
        public bool? Verified { get; set; }
        public string Comments { get; set; }
        public bool? Service { get; set; }
        public string HelpNameEmployee { get; set; }
        public string HelpComentsTicket { get; set; }
        public bool? ReportOdometer { get; set; }
        public bool? WithTempValues { get; set; }
        public DateTime? WithTempValuesDate { get; set; }
        public DateTime? ExtraordinaryDatetime { get; set; }
        public bool TotvsUpdated { get; set; }
        public bool ChangeTotvs { get; set; }
        public string SearchProperty1 { get; set; }
        public string SearchProperty2 { get; set; }
        public DateTime? SingleEventDatetimeStart { get; set; }
        public DateTime? SingleEventDatetimeEnd { get; set; }
        public int? SingleEventMaxCost { get; set; }
        public int? SingleEventMaxVolume { get; set; }
        public int? SingleEventFuelType { get; set; }
        public string NumTransactionExternal { get; set; }
        public int? IdClientGate { get; set; }
        public decimal? EstimatedFuelCons { get; set; }
        public int? IsParent { get; set; }
        public bool IsCloned { get; set; }
        public bool CancelEvent { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int? AppointmentServiceVehicle { get; set; }
        public int VehicleBrandModel { get; set; }
        public int VehicleClient { get; set; }
        public int? CostCenterVehicle { get; set; }
        public int? VehicleFuelType { get; set; }
        public int? RulesVehicle { get; set; }
        public int VehicleStatus { get; set; }
        public int VehicleVehicleBrand { get; set; }
    }
}
