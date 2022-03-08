using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class GasStations
    {
        public GasStations()
        {
            AccesoriesSet = new HashSet<AccesoriesSet>();
            AllowedStationSet = new HashSet<AllowedStationSet>();
            Antennas = new HashSet<Antennas>();
            BatterySet = new HashSet<BatterySet>();
            BillingSet = new HashSet<BillingSet>();
            CallRecordSet = new HashSet<CallRecordSet>();
            CatDeviceSet = new HashSet<CatDeviceSet>();
            ConnectionByStationsSet = new HashSet<ConnectionByStationsSet>();
            ContactPersons = new HashSet<ContactPersons>();
            ContingencySet = new HashSet<ContingencySet>();
            ContingencyWebSet = new HashSet<ContingencyWebSet>();
            ContingencyWithoutVehicleSet = new HashSet<ContingencyWithoutVehicleSet>();
            CreditConfigSet = new HashSet<CreditConfigSet>();
            DatosFiscalesSet = new HashSet<DatosFiscalesSet>();
            DispatchSet = new HashSet<DispatchSet>();
            FuelCodesByStationSet = new HashSet<FuelCodesByStationSet>();
            FuelSet = new HashSet<FuelSet>();
            GasStationExtraActivitiesSet = new HashSet<GasStationExtraActivitiesSet>();
            HistoryAntennas = new HashSet<HistoryAntennas>();
            HistoryBatterySet = new HashSet<HistoryBatterySet>();
            HistoryImageInstallationSet = new HashSet<HistoryImageInstallationSet>();
            HistoryReaders = new HashSet<HistoryReaders>();
            HistoryTags = new HashSet<HistoryTags>();
            ImageInstallationSet = new HashSet<ImageInstallationSet>();
            MalfunctionReports = new HashSet<MalfunctionReports>();
            PagosEstacionSet = new HashSet<PagosEstacionSet>();
            ProfileInClientSet = new HashSet<ProfileInClientSet>();
            Readers = new HashSet<Readers>();
            Tags = new HashSet<Tags>();
            TicketEventsSet = new HashSet<TicketEventsSet>();
            TicketSet = new HashSet<TicketSet>();
            UsersInProfileSet = new HashSet<UsersInProfileSet>();
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
        public int? StationTypeGasStation { get; set; }

        public virtual CatMetodoPagoSet CatMetodoPagoGasStationNavigation { get; set; }
        public virtual ConfiguracionEdset ConfiguracionEdGasStationNavigation { get; set; }
        public virtual FormaDePagoSet FormaDePagoGasStationNavigation { get; set; }
        public virtual Addresses GasStationAddressNavigation { get; set; }
        public virtual ClientGroups GasStationClientGroupNavigation { get; set; }
        public virtual GasStationGroups GasStationGasStationGroupNavigation { get; set; }
        public virtual PcOsVersions GasStationPcOsVersionNavigation { get; set; }
        public virtual PumpControllers GasStationPumpControllerNavigation { get; set; }
        public virtual TimeZoneCset GasStationTimeZoneCNavigation { get; set; }
        public virtual VolumetricSet GasStationVolumetricNavigation { get; set; }
        public virtual PumpTypeSet PumpTypeGasStationNavigation { get; set; }
        public virtual StationTypes StationTypeGasStationNavigation { get; set; }
        public virtual ICollection<AccesoriesSet> AccesoriesSet { get; set; }
        public virtual ICollection<AllowedStationSet> AllowedStationSet { get; set; }
        public virtual ICollection<Antennas> Antennas { get; set; }
        public virtual ICollection<BatterySet> BatterySet { get; set; }
        public virtual ICollection<BillingSet> BillingSet { get; set; }
        public virtual ICollection<CallRecordSet> CallRecordSet { get; set; }
        public virtual ICollection<CatDeviceSet> CatDeviceSet { get; set; }
        public virtual ICollection<ConnectionByStationsSet> ConnectionByStationsSet { get; set; }
        public virtual ICollection<ContactPersons> ContactPersons { get; set; }
        public virtual ICollection<ContingencySet> ContingencySet { get; set; }
        public virtual ICollection<ContingencyWebSet> ContingencyWebSet { get; set; }
        public virtual ICollection<ContingencyWithoutVehicleSet> ContingencyWithoutVehicleSet { get; set; }
        public virtual ICollection<CreditConfigSet> CreditConfigSet { get; set; }
        public virtual ICollection<DatosFiscalesSet> DatosFiscalesSet { get; set; }
        public virtual ICollection<DispatchSet> DispatchSet { get; set; }
        public virtual ICollection<FuelCodesByStationSet> FuelCodesByStationSet { get; set; }
        public virtual ICollection<FuelSet> FuelSet { get; set; }
        public virtual ICollection<GasStationExtraActivitiesSet> GasStationExtraActivitiesSet { get; set; }
        public virtual ICollection<HistoryAntennas> HistoryAntennas { get; set; }
        public virtual ICollection<HistoryBatterySet> HistoryBatterySet { get; set; }
        public virtual ICollection<HistoryImageInstallationSet> HistoryImageInstallationSet { get; set; }
        public virtual ICollection<HistoryReaders> HistoryReaders { get; set; }
        public virtual ICollection<HistoryTags> HistoryTags { get; set; }
        public virtual ICollection<ImageInstallationSet> ImageInstallationSet { get; set; }
        public virtual ICollection<MalfunctionReports> MalfunctionReports { get; set; }
        public virtual ICollection<PagosEstacionSet> PagosEstacionSet { get; set; }
        public virtual ICollection<ProfileInClientSet> ProfileInClientSet { get; set; }
        public virtual ICollection<Readers> Readers { get; set; }
        public virtual ICollection<Tags> Tags { get; set; }
        public virtual ICollection<TicketEventsSet> TicketEventsSet { get; set; }
        public virtual ICollection<TicketSet> TicketSet { get; set; }
        public virtual ICollection<UsersInProfileSet> UsersInProfileSet { get; set; }
    }
}
