using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class GasStation
    {
        public GasStation()
        {
            AccesoriesSets = new HashSet<AccesoriesSet>();
            AllowedStationSets = new HashSet<AllowedStationSet>();
            Antennas = new HashSet<Antenna>();
            BatterySets = new HashSet<BatterySet>();
            BillingSets = new HashSet<BillingSet>();
            CallRecordSets = new HashSet<CallRecordSet>();
            CatDeviceSets = new HashSet<CatDeviceSet>();
            ConnectionByStationsSets = new HashSet<ConnectionByStationsSet>();
            ContactPeople = new HashSet<ContactPerson>();
            ContingencySets = new HashSet<ContingencySet>();
            ContingencyWebSets = new HashSet<ContingencyWebSet>();
            ContingencyWithoutVehicleSets = new HashSet<ContingencyWithoutVehicleSet>();
            CreditConfigSets = new HashSet<CreditConfigSet>();
            DatosFiscalesSets = new HashSet<DatosFiscalesSet>();
            DispatchSets = new HashSet<DispatchSet>();
            FuelCodesByStationSets = new HashSet<FuelCodesByStationSet>();
            FuelSets = new HashSet<FuelSet>();
            GasStationExtraActivitiesSets = new HashSet<GasStationExtraActivitiesSet>();
            HistoryAntennas = new HashSet<HistoryAntenna>();
            HistoryBatterySets = new HashSet<HistoryBatterySet>();
            HistoryImageInstallationSets = new HashSet<HistoryImageInstallationSet>();
            HistoryReaders = new HashSet<HistoryReader>();
            HistoryTags = new HashSet<HistoryTag>();
            ImageInstallationSets = new HashSet<ImageInstallationSet>();
            MalfunctionReports = new HashSet<MalfunctionReport>();
            PagosEstacionSets = new HashSet<PagosEstacionSet>();
            ProfileInClientSets = new HashSet<ProfileInClientSet>();
            Readers = new HashSet<Reader>();
            Tags = new HashSet<Tag>();
            TicketEventsSets = new HashSet<TicketEventsSet>();
            TicketSets = new HashSet<TicketSet>();
            UsersInProfileSets = new HashSet<UsersInProfileSet>();
        }

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

        public virtual CatMetodoPagoSet CatMetodoPagoGasStationNavigation { get; set; }
        public virtual ConfiguracionEdset ConfiguracionEdGasStationNavigation { get; set; }
        public virtual FormaDePagoSet FormaDePagoGasStationNavigation { get; set; }
        public virtual Address GasStationAddressNavigation { get; set; }
        public virtual ClientGroup GasStationClientGroupNavigation { get; set; }
        public virtual GasStationGroup GasStationGasStationGroupNavigation { get; set; }
        public virtual PcOsVersion GasStationPcOsVersionNavigation { get; set; }
        public virtual PumpController GasStationPumpControllerNavigation { get; set; }
        public virtual TimeZoneCset GasStationTimeZoneCNavigation { get; set; }
        public virtual VolumetricSet GasStationVolumetricNavigation { get; set; }
        public virtual PumpTypeSet PumpTypeGasStationNavigation { get; set; }
        public virtual ICollection<AccesoriesSet> AccesoriesSets { get; set; }
        public virtual ICollection<AllowedStationSet> AllowedStationSets { get; set; }
        public virtual ICollection<Antenna> Antennas { get; set; }
        public virtual ICollection<BatterySet> BatterySets { get; set; }
        public virtual ICollection<BillingSet> BillingSets { get; set; }
        public virtual ICollection<CallRecordSet> CallRecordSets { get; set; }
        public virtual ICollection<CatDeviceSet> CatDeviceSets { get; set; }
        public virtual ICollection<ConnectionByStationsSet> ConnectionByStationsSets { get; set; }
        public virtual ICollection<ContactPerson> ContactPeople { get; set; }
        public virtual ICollection<ContingencySet> ContingencySets { get; set; }
        public virtual ICollection<ContingencyWebSet> ContingencyWebSets { get; set; }
        public virtual ICollection<ContingencyWithoutVehicleSet> ContingencyWithoutVehicleSets { get; set; }
        public virtual ICollection<CreditConfigSet> CreditConfigSets { get; set; }
        public virtual ICollection<DatosFiscalesSet> DatosFiscalesSets { get; set; }
        public virtual ICollection<DispatchSet> DispatchSets { get; set; }
        public virtual ICollection<FuelCodesByStationSet> FuelCodesByStationSets { get; set; }
        public virtual ICollection<FuelSet> FuelSets { get; set; }
        public virtual ICollection<GasStationExtraActivitiesSet> GasStationExtraActivitiesSets { get; set; }
        public virtual ICollection<HistoryAntenna> HistoryAntennas { get; set; }
        public virtual ICollection<HistoryBatterySet> HistoryBatterySets { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSets { get; set; }
        public virtual ICollection<HistoryReader> HistoryReaders { get; set; }
        public virtual ICollection<HistoryTag> HistoryTags { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSets { get; set; }
        public virtual ICollection<MalfunctionReport> MalfunctionReports { get; set; }
        public virtual ICollection<PagosEstacionSet> PagosEstacionSets { get; set; }
        public virtual ICollection<ProfileInClientSet> ProfileInClientSets { get; set; }
        public virtual ICollection<Reader> Readers { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<TicketEventsSet> TicketEventsSets { get; set; }
        public virtual ICollection<TicketSet> TicketSets { get; set; }
        public virtual ICollection<UsersInProfileSet> UsersInProfileSets { get; set; }
    }
}
