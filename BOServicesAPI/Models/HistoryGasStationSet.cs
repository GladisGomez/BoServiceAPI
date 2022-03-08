using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class HistoryGasStationSet
    {
        public int Id { get; set; }
        public int? IdGasStation { get; set; }
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
        public bool? Diesel { get; set; }
        public bool? Magna { get; set; }
        public bool? Premium { get; set; }
        public bool? Verified { get; set; }
        public bool? Service { get; set; }
        public string HelpNameEmployee { get; set; }
        public string HelpCommentsTicket { get; set; }
        public double? Iva { get; set; }
        public string IdTotvs { get; set; }
        public string IdSucursalTotvs { get; set; }
        public bool? Status { get; set; }
        public bool? SendMailForContingency { get; set; }
        public string AccountNumber { get; set; }
        public bool? ConfigCost { get; set; }
        public int? Tardefault { get; set; }
        public int? CommerceNumber { get; set; }
        public bool? LimitCost { get; set; }
        public string ActionTransac { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? HistoryGasStationAddress { get; set; }
        public int? HistoryGasStationCatMetodoPago { get; set; }
        public int? HistoryGasStationConfiguracionEd { get; set; }
        public int? HistoryGasStationFormaDePago { get; set; }
        public int? HistoryGasStationGasStationGroup { get; set; }
        public int? HistoryGasStationPcOsVersion { get; set; }
        public int? HistoryGasStationPumpController { get; set; }
        public int? HistoryGasStationPumpType { get; set; }
        public int? HistoryGasStationTimeZoneC { get; set; }
        public int? HistoryGasStationVolumetric { get; set; }

        public virtual Addresses HistoryGasStationAddressNavigation { get; set; }
        public virtual CatMetodoPagoSet HistoryGasStationCatMetodoPagoNavigation { get; set; }
        public virtual ConfiguracionEdset HistoryGasStationConfiguracionEdNavigation { get; set; }
        public virtual FormaDePagoSet HistoryGasStationFormaDePagoNavigation { get; set; }
        public virtual GasStationGroups HistoryGasStationGasStationGroupNavigation { get; set; }
        public virtual PcOsVersions HistoryGasStationPcOsVersionNavigation { get; set; }
        public virtual PumpControllers HistoryGasStationPumpControllerNavigation { get; set; }
        public virtual PumpTypeSet HistoryGasStationPumpTypeNavigation { get; set; }
        public virtual TimeZoneCset HistoryGasStationTimeZoneCNavigation { get; set; }
        public virtual VolumetricSet HistoryGasStationVolumetricNavigation { get; set; }
    }
}
