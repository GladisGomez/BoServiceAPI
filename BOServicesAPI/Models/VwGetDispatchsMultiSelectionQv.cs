using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwGetDispatchsMultiSelectionQv
    {
        public int IdClientGroup { get; set; }
        public string OficialName { get; set; }
        public string NickName { get; set; }
        public int PublicClientNumber { get; set; }
        public int Status { get; set; }
        public int IdClient { get; set; }
        public string NickNameGroup { get; set; }
        public int PublicId { get; set; }
        public string Plate { get; set; }
        public string EcoNumber { get; set; }
        public string NameStatus { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public int YearModel { get; set; }
        public int IdVehicle { get; set; }
        public int IdDispatch { get; set; }
        public DateTime? DatetimeEnd { get; set; }
        public DateTime DatetimeStart { get; set; }
        public DateTime? DatetimeInvoicing { get; set; }
        public int IdFuel { get; set; }
        public string TypeFuel { get; set; }
        public int? NumTransaction { get; set; }
        public int? PumpNumber { get; set; }
        public decimal? RealVolume { get; set; }
        public decimal? RealCost { get; set; }
        public decimal? Odometer { get; set; }
        public int? DispatchType { get; set; }
        public DateTime? DateTimeDispatch { get; set; }
        public int IdConti { get; set; }
        public string IdContingency { get; set; }
        public decimal? AllocateVolume { get; set; }
        public decimal? AllocateCost { get; set; }
        public string StatusContigency { get; set; }
        public int? IdStatusContingency { get; set; }
        public string MessageError { get; set; }
        public int IdStation { get; set; }
        public string StationNumber { get; set; }
        public string NicknameStation { get; set; }
        public string OficialNameStation { get; set; }
        public decimal? OdoOld { get; set; }
        public decimal? VolumeOld { get; set; }
        public bool Canceled { get; set; }
        public string CommentsDispatch { get; set; }
        public string DriverName { get; set; }
        public int? FolioEdc { get; set; }
        public DateTime? FechaEdc { get; set; }
        public int? FolioEde { get; set; }
        public DateTime? FechaEde { get; set; }
        public string NameCenter { get; set; }
        public decimal? EstimatedFuelCons { get; set; }
        public DateTimeOffset? ModifiedDispatch { get; set; }
        public decimal? RendimObjetivo { get; set; }
        public int Code { get; set; }
        public decimal? Ieps { get; set; }
        public int? Tar { get; set; }
        public decimal? PriceUnit { get; set; }
        public double Iva { get; set; }
        public string Rfc { get; set; }
        public string Vin { get; set; }
        public string AddressCity { get; set; }
        public int IdVehBrand { get; set; }
        public int IdVehModel { get; set; }
        public int IdVehType { get; set; }
        public DateTime? DatetimeCanceled { get; set; }
        public string NameCity { get; set; }
        public decimal DeltaValue { get; set; }
        public string IdTimeZone { get; set; }
        public string CediAnterior { get; set; }
        public decimal? OdometerNoTratado { get; set; }
    }
}
