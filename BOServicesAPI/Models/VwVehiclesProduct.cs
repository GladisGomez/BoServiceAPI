using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class VwVehiclesProduct
    {
        public int IdClientGroup { get; set; }
        public string OficialNameGroup { get; set; }
        public string NicknameGroup { get; set; }
        public int IdCliente { get; set; }
        public string NickNameCliente { get; set; }
        public int IdVehicle { get; set; }
        public string Plate { get; set; }
        public string Vin { get; set; }
        public string EcoNumber { get; set; }
        public int? IdTag { get; set; }
        public string Sid { get; set; }
        public string Uid { get; set; }
        public bool? TagActivo { get; set; }
        public DateTime? TagServiceDataTime { get; set; }
        public string RazonReemplazo { get; set; }
        public string TipoTag { get; set; }
        public int? IdGps { get; set; }
        public string UnitId { get; set; }
        public string UnitIdhex { get; set; }
        public string Fw { get; set; }
        public string ParamVersion { get; set; }
        public DateTime? DateInstallation { get; set; }
        public decimal? ValorOdometer { get; set; }
        public DateTime? OdometerDate { get; set; }
        public bool? GpsActivo { get; set; }
        public string UnitType { get; set; }
        public string Box { get; set; }
        public string Imei { get; set; }
        public DateTime? DateGpsSim { get; set; }
        public int? IdMeter { get; set; }
        public string Serial { get; set; }
        public DateTime? ServiceDataTime { get; set; }
        public bool? Active { get; set; }
        public DateTime? ActivationDateTime { get; set; }
        public string TipoMeter { get; set; }
        public string EstatusVehiculo { get; set; }
        public string ComentariosGps { get; set; }
        public int PublicId { get; set; }
    }
}
