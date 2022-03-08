using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    /// <summary>
    /// Clase para entidades de Gas Stations
    /// </summary>
    public class AuxStations
    {
        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string OficialName { get; set; }
        public string NickName { get; set; }
        public string StationNumber { get; set; }
        public string Comments { get; set; }
        public string CablesLocationDescription { get; set; }
        public string UserWa { get; set; }
        public string PassWa { get; set; }
        public string CgProvider { get; set; }
        public string AviVersion { get; set; }
        public string CgVersion { get; set; }
        public string SgpsVersion { get; set; }
        public string SgpmVersion { get; set; }
        public bool Diesel { get; set; }
        public bool Magna { get; set; }
        public bool Premium { get; set; }
        public bool? Verified { get; set; }
        public bool? Service { get; set; }
        public string HelpNameEmployee { get; set; }
        public string HelpCommentsTicket { get; set; }
        public double Iva { get; set; }
        public string IdTotvs { get; set; }
        public string IdSucursalTotvs { get; set; }
        public bool Status { get; set; }
        public bool? SendMailForContingency { get; set; }
        public string AccountNumber { get; set; }
        public bool ConfigCost { get; set; }
        public int Tardefault { get; set; }
        public int? CommerceNumber { get; set; }
        public bool LimitCost { get; set; }
        public bool Autoconsumo { get; set; }
        public bool NotShowInMaps { get; set; }
        public string ReadersNozzles { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int GasStationAddress { get; set; }
        public int? CatMetodoPagoGasStation { get; set; }
        public int? GasStationClientGroup { get; set; }
        public int? FormaDePagoGasStation { get; set; }
        public int GasStationGasStationGroup { get; set; }
        public int? ConfiguracionEdGasStation { get; set; }
        public int GasStationPcOsVersion { get; set; }
        public int GasStationPumpController { get; set; }
        public int PumpTypeGasStation { get; set; }
        public int GasStationTimeZoneC { get; set; }
        public int? GasStationVolumetric { get; set; }
        public int? PlaceId { get; set; }
        public string CreId { get; set; }
        public string Bandera { get; set; }

    }
}
