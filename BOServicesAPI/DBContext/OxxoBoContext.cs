using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BOServicesAPI.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.DBContext
{
    public partial class OxxoBoContext : DbContext
    {
        public OxxoBoContext()
        {
        }

        public OxxoBoContext(DbContextOptions<OxxoBoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccesoriesSet> AccesoriesSet { get; set; }
        public virtual DbSet<AccountGngSet> AccountGngSet { get; set; }
        public virtual DbSet<ActivityInStationSet> ActivityInStationSet { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<AlertAuthContingencySet> AlertAuthContingencySet { get; set; }
        public virtual DbSet<AlertasSet> AlertasSet { get; set; }
        public virtual DbSet<AllCfdiSet> AllCfdiSet { get; set; }
        public virtual DbSet<AllTablesSet> AllTablesSet { get; set; }
        public virtual DbSet<AllowedStationSet> AllowedStationSet { get; set; }
        public virtual DbSet<AltoTrackSet> AltoTrackSet { get; set; }
        public virtual DbSet<AltoTrackVehiclesSet> AltoTrackVehiclesSet { get; set; }
        public virtual DbSet<Antennas> Antennas { get; set; }
        public virtual DbSet<ApplicationHistorySet> ApplicationHistorySet { get; set; }
        public virtual DbSet<AppointmentServiceSet> AppointmentServiceSet { get; set; }
        public virtual DbSet<ArchivosDatosFiscalesSet> ArchivosDatosFiscalesSet { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }
        public virtual DbSet<AspnetPaths> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfile { get; set; }
        public virtual DbSet<AspnetRoles> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; }
        public virtual DbSet<AttachFilesSet> AttachFilesSet { get; set; }
        public virtual DbSet<AuditTrailSet> AuditTrailSet { get; set; }
        public virtual DbSet<AuditWebSet> AuditWebSet { get; set; }
        public virtual DbSet<BadPositionsWhileChargingSet> BadPositionsWhileChargingSet { get; set; }
        public virtual DbSet<BalanceTransactionsSet> BalanceTransactionsSet { get; set; }
        public virtual DbSet<BankSet> BankSet { get; set; }
        public virtual DbSet<BankingDepositSet> BankingDepositSet { get; set; }
        public virtual DbSet<BatteryFailureSet> BatteryFailureSet { get; set; }
        public virtual DbSet<BatterySet> BatterySet { get; set; }
        public virtual DbSet<BatteryTypeSet> BatteryTypeSet { get; set; }
        public virtual DbSet<BillingSet> BillingSet { get; set; }
        public virtual DbSet<BrandModels> BrandModels { get; set; }
        public virtual DbSet<CallRecordSet> CallRecordSet { get; set; }
        public virtual DbSet<CatAvlcustomfieldsSet> CatAvlcustomfieldsSet { get; set; }
        public virtual DbSet<CatCombustibleSet> CatCombustibleSet { get; set; }
        public virtual DbSet<CatCustomStickersModels> CatCustomStickersModels { get; set; }
        public virtual DbSet<CatCustomStickersStatusSet> CatCustomStickersStatusSet { get; set; }
        public virtual DbSet<CatDeviceSet> CatDeviceSet { get; set; }
        public virtual DbSet<CatExpertiseSet> CatExpertiseSet { get; set; }
        public virtual DbSet<CatMetodoPagoSet> CatMetodoPagoSet { get; set; }
        public virtual DbSet<CatalogParametersSet> CatalogParametersSet { get; set; }
        public virtual DbSet<CatalogScreensSet> CatalogScreensSet { get; set; }
        public virtual DbSet<CatalogTypeSet> CatalogTypeSet { get; set; }
        public virtual DbSet<CatalogTypeSetAttributteSet> CatalogTypeSetAttributteSet { get; set; }
        public virtual DbSet<CfdirelacionadosSet> CfdirelacionadosSet { get; set; }
        public virtual DbSet<ChangeRequestPlateSet> ChangeRequestPlateSet { get; set; }
        public virtual DbSet<CitySet> CitySet { get; set; }
        public virtual DbSet<ClaveProdServSet> ClaveProdServSet { get; set; }
        public virtual DbSet<ClientGroupInGpsSet> ClientGroupInGpsSet { get; set; }
        public virtual DbSet<ClientGroups> ClientGroups { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<ClientsBovsCgset> ClientsBovsCgset { get; set; }
        public virtual DbSet<ClientsMonitor> ClientsMonitor { get; set; }
        public virtual DbSet<ClosingReasonTicketSet> ClosingReasonTicketSet { get; set; }
        public virtual DbSet<CodigoPostalSet> CodigoPostalSet { get; set; }
        public virtual DbSet<ComplementoConceptosEdcset> ComplementoConceptosEdcset { get; set; }
        public virtual DbSet<ComplementoEdcset> ComplementoEdcset { get; set; }
        public virtual DbSet<ComplementoEdeset> ComplementoEdeset { get; set; }
        public virtual DbSet<ConceptoCmoDeCombustiblesSet> ConceptoCmoDeCombustiblesSet { get; set; }
        public virtual DbSet<ConceptoEdoCtaCombustibleSet> ConceptoEdoCtaCombustibleSet { get; set; }
        public virtual DbSet<ConceptosEdcset> ConceptosEdcset { get; set; }
        public virtual DbSet<ConceptosEdeset> ConceptosEdeset { get; set; }
        public virtual DbSet<ConceptosEdset> ConceptosEdset { get; set; }
        public virtual DbSet<ConceptsSet> ConceptsSet { get; set; }
        public virtual DbSet<ConciliateDispatchSet> ConciliateDispatchSet { get; set; }
        public virtual DbSet<ConciliationVinset> ConciliationVinset { get; set; }
        public virtual DbSet<ConfiguracionDescuentoEdset> ConfiguracionDescuentoEdset { get; set; }
        public virtual DbSet<ConfiguracionEdset> ConfiguracionEdset { get; set; }
        public virtual DbSet<ConnectionByStationsSet> ConnectionByStationsSet { get; set; }
        public virtual DbSet<ConsumoDeCombustiblesSet> ConsumoDeCombustiblesSet { get; set; }
        public virtual DbSet<ContactPersons> ContactPersons { get; set; }
        public virtual DbSet<ContingencyByPosSet> ContingencyByPosSet { get; set; }
        public virtual DbSet<ContingencyFileSet> ContingencyFileSet { get; set; }
        public virtual DbSet<ContingencySet> ContingencySet { get; set; }
        public virtual DbSet<ContingencyWebSet> ContingencyWebSet { get; set; }
        public virtual DbSet<ContingencyWithoutVehicleSet> ContingencyWithoutVehicleSet { get; set; }
        public virtual DbSet<ContractFacSet> ContractFacSet { get; set; }
        public virtual DbSet<ControlCompanies> ControlCompanies { get; set; }
        public virtual DbSet<ControlPermissionsWebSet> ControlPermissionsWebSet { get; set; }
        public virtual DbSet<ControlPrintTargetSet> ControlPrintTargetSet { get; set; }
        public virtual DbSet<ControllerWebSet> ControllerWebSet { get; set; }
        public virtual DbSet<ControlsWebSet> ControlsWebSet { get; set; }
        public virtual DbSet<CostCenterSet> CostCenterSet { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<CreditConfigSet> CreditConfigSet { get; set; }
        public virtual DbSet<CuotasEdset> CuotasEdset { get; set; }
        public virtual DbSet<CustomFieldsToVehiclesSet> CustomFieldsToVehiclesSet { get; set; }
        public virtual DbSet<CustomStickers> CustomStickers { get; set; }
        public virtual DbSet<CustomStickers59Produccion> CustomStickers59Produccion { get; set; }
        public virtual DbSet<CustomStickersProd2300> CustomStickersProd2300 { get; set; }
        public virtual DbSet<CustomStickersTrakings> CustomStickersTrakings { get; set; }
        public virtual DbSet<DailyDataSet> DailyDataSet { get; set; }
        public virtual DbSet<DataBillingSet> DataBillingSet { get; set; }
        public virtual DbSet<DateTimeEndCorrect> DateTimeEndCorrect { get; set; }
        public virtual DbSet<DatosFiscalesSet> DatosFiscalesSet { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<DepositosSet> DepositosSet { get; set; }
        public virtual DbSet<DesignTemplateWeb> DesignTemplateWeb { get; set; }
        public virtual DbSet<DesignTemplateWebs> DesignTemplateWebs { get; set; }
        public virtual DbSet<DespachosProxySet> DespachosProxySet { get; set; }
        public virtual DbSet<DetailAppointmentSet> DetailAppointmentSet { get; set; }
        public virtual DbSet<DetailConceptSet> DetailConceptSet { get; set; }
        public virtual DbSet<DetalleEdcset> DetalleEdcset { get; set; }
        public virtual DbSet<DeteilAppointmentSet> DeteilAppointmentSet { get; set; }
        public virtual DbSet<DeterminadosEdeset> DeterminadosEdeset { get; set; }
        public virtual DbSet<DiagnosticBatterySet> DiagnosticBatterySet { get; set; }
        public virtual DbSet<DiagnosticReaderSet> DiagnosticReaderSet { get; set; }
        public virtual DbSet<DiagnosticTicketSet> DiagnosticTicketSet { get; set; }
        public virtual DbSet<DispatchCg> DispatchCg { get; set; }
        public virtual DbSet<DispatchExSet> DispatchExSet { get; set; }
        public virtual DbSet<DispatchExternSet> DispatchExternSet { get; set; }
        public virtual DbSet<DispatchExternSet2222> DispatchExternSet2222 { get; set; }
        public virtual DbSet<DispatchHistorySet> DispatchHistorySet { get; set; }
        public virtual DbSet<DispatchOdometerHigherMessageSet> DispatchOdometerHigherMessageSet { get; set; }
        public virtual DbSet<DispatchSet> DispatchSet { get; set; }
        public virtual DbSet<DispatchedWithoutMessageSet> DispatchedWithoutMessageSet { get; set; }
        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<DriversVehiclesSet> DriversVehiclesSet { get; set; }
        public virtual DbSet<EdcomplementoSet> EdcomplementoSet { get; set; }
        public virtual DbSet<Edcset> Edcset { get; set; }
        public virtual DbSet<Edeset> Edeset { get; set; }
        public virtual DbSet<EdoCtaCombustibleSet> EdoCtaCombustibleSet { get; set; }
        public virtual DbSet<EmisorDetalleSet> EmisorDetalleSet { get; set; }
        public virtual DbSet<EmisorSet> EmisorSet { get; set; }
        public virtual DbSet<EmployeeRolesSet> EmployeeRolesSet { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EmployeesAppointmentSet> EmployeesAppointmentSet { get; set; }
        public virtual DbSet<EncabezadoEstadoCuentaSet> EncabezadoEstadoCuentaSet { get; set; }
        public virtual DbSet<ErrorRevisionMeterSet> ErrorRevisionMeterSet { get; set; }
        public virtual DbSet<EstadoDeCuentaCombustibleSet> EstadoDeCuentaCombustibleSet { get; set; }
        public virtual DbSet<ExpedidoEnSet> ExpedidoEnSet { get; set; }
        public virtual DbSet<ExpertiseSet> ExpertiseSet { get; set; }
        public virtual DbSet<FeeCommisionSet> FeeCommisionSet { get; set; }
        public virtual DbSet<FormaDePagoSet> FormaDePagoSet { get; set; }
        public virtual DbSet<FsGetInfoSet> FsGetInfoSet { get; set; }
        public virtual DbSet<FuelCodesByStationSet> FuelCodesByStationSet { get; set; }
        public virtual DbSet<FuelSet> FuelSet { get; set; }
        public virtual DbSet<FuelTypes> FuelTypes { get; set; }
        public virtual DbSet<GasStationExtraActivitiesSet> GasStationExtraActivitiesSet { get; set; }
        public virtual DbSet<GasStationGroups> GasStationGroups { get; set; }
        public virtual DbSet<GasStations> GasStations { get; set; }
        public virtual DbSet<GlobalParametersSet> GlobalParametersSet { get; set; }
        public virtual DbSet<GpsConfiguracionParametrosSet> GpsConfiguracionParametrosSet { get; set; }
        public virtual DbSet<GpsDbManagerSet> GpsDbManagerSet { get; set; }
        public virtual DbSet<GpsJobSet> GpsJobSet { get; set; }
        public virtual DbSet<GpsOdometerSet> GpsOdometerSet { get; set; }
        public virtual DbSet<GpsParametersSet> GpsParametersSet { get; set; }
        public virtual DbSet<GpsServerSet> GpsServerSet { get; set; }
        public virtual DbSet<GpsSet> GpsSet { get; set; }
        public virtual DbSet<GpsVersionSet> GpsVersionSet { get; set; }
        public virtual DbSet<GrtfailureSet> GrtfailureSet { get; set; }
        public virtual DbSet<Grtset> Grtset { get; set; }
        public virtual DbSet<GrttypeSet> GrttypeSet { get; set; }
        public virtual DbSet<HeaderBillingSet> HeaderBillingSet { get; set; }
        public virtual DbSet<HistorialDeFacturacionSet> HistorialDeFacturacionSet { get; set; }
        public virtual DbSet<HistoryAccesoriesSet> HistoryAccesoriesSet { get; set; }
        public virtual DbSet<HistoryAntennas> HistoryAntennas { get; set; }
        public virtual DbSet<HistoryBatterySet> HistoryBatterySet { get; set; }
        public virtual DbSet<HistoryContractFacSet> HistoryContractFacSet { get; set; }
        public virtual DbSet<HistoryGasStationSet> HistoryGasStationSet { get; set; }
        public virtual DbSet<HistoryGpsSet> HistoryGpsSet { get; set; }
        public virtual DbSet<HistoryImageInstallationSet> HistoryImageInstallationSet { get; set; }
        public virtual DbSet<HistoryMetersSet> HistoryMetersSet { get; set; }
        public virtual DbSet<HistoryProductMovementsSet> HistoryProductMovementsSet { get; set; }
        public virtual DbSet<HistoryReaders> HistoryReaders { get; set; }
        public virtual DbSet<HistorySimgpsSet> HistorySimgpsSet { get; set; }
        public virtual DbSet<HistoryTags> HistoryTags { get; set; }
        public virtual DbSet<HistoryTankVehicleSet> HistoryTankVehicleSet { get; set; }
        public virtual DbSet<HistoryVehiclesSet> HistoryVehiclesSet { get; set; }
        public virtual DbSet<HorarySet> HorarySet { get; set; }
        public virtual DbSet<Iepsset> Iepsset { get; set; }
        public virtual DbSet<ImageInstallationSet> ImageInstallationSet { get; set; }
        public virtual DbSet<ImpuestoSet> ImpuestoSet { get; set; }
        public virtual DbSet<ImpuestoTrasladadoEdcset> ImpuestoTrasladadoEdcset { get; set; }
        public virtual DbSet<ImpuetosTrasladadosEdeset> ImpuetosTrasladadosEdeset { get; set; }
        public virtual DbSet<InventaryTagSet> InventaryTagSet { get; set; }
        public virtual DbSet<LaboratoryDiagnosticBatterySet> LaboratoryDiagnosticBatterySet { get; set; }
        public virtual DbSet<LaboratoryDiagnosticGrtset> LaboratoryDiagnosticGrtset { get; set; }
        public virtual DbSet<LaboratoryDiagnosticPowerSupplySet> LaboratoryDiagnosticPowerSupplySet { get; set; }
        public virtual DbSet<LaboratoryDiagnosticReaderSet> LaboratoryDiagnosticReaderSet { get; set; }
        public virtual DbSet<LocalidadSet> LocalidadSet { get; set; }
        public virtual DbSet<MailsEnvioEdset> MailsEnvioEdset { get; set; }
        public virtual DbSet<MailsEnvioSaldosSet> MailsEnvioSaldosSet { get; set; }
        public virtual DbSet<MalfunctionAntennas> MalfunctionAntennas { get; set; }
        public virtual DbSet<MalfunctionCgs> MalfunctionCgs { get; set; }
        public virtual DbSet<MalfunctionConnections> MalfunctionConnections { get; set; }
        public virtual DbSet<MalfunctionFleets> MalfunctionFleets { get; set; }
        public virtual DbSet<MalfunctionReaders> MalfunctionReaders { get; set; }
        public virtual DbSet<MalfunctionReports> MalfunctionReports { get; set; }
        public virtual DbSet<MalfunctionStationProblems> MalfunctionStationProblems { get; set; }
        public virtual DbSet<MalfunctionTags> MalfunctionTags { get; set; }
        public virtual DbSet<MalfunctionTrainings> MalfunctionTrainings { get; set; }
        public virtual DbSet<MessageErrorSet> MessageErrorSet { get; set; }
        public virtual DbSet<MeterTypes> MeterTypes { get; set; }
        public virtual DbSet<Meters> Meters { get; set; }
        public virtual DbSet<MetodoDePagoSet> MetodoDePagoSet { get; set; }
        public virtual DbSet<MunicipioSet> MunicipioSet { get; set; }
        public virtual DbSet<NipsSet> NipsSet { get; set; }
        public virtual DbSet<NozzleTypes> NozzleTypes { get; set; }
        public virtual DbSet<OdometerTypes> OdometerTypes { get; set; }
        public virtual DbSet<OdometerUnits> OdometerUnits { get; set; }
        public virtual DbSet<OfflineAccessSet> OfflineAccessSet { get; set; }
        public virtual DbSet<OfflineSyncStatusSet> OfflineSyncStatusSet { get; set; }
        public virtual DbSet<OrderOfServiceSet> OrderOfServiceSet { get; set; }
        public virtual DbSet<PagosEstacionSet> PagosEstacionSet { get; set; }
        public virtual DbSet<PcOsVersions> PcOsVersions { get; set; }
        public virtual DbSet<PermissionsWebSet> PermissionsWebSet { get; set; }
        public virtual DbSet<PowerSupplyFailureSet> PowerSupplyFailureSet { get; set; }
        public virtual DbSet<PriceFuelSet> PriceFuelSet { get; set; }
        public virtual DbSet<ProductCodeSet> ProductCodeSet { get; set; }
        public virtual DbSet<ProductSectionSet> ProductSectionSet { get; set; }
        public virtual DbSet<ProductsSet> ProductsSet { get; set; }
        public virtual DbSet<ProfileInClientGroupSet> ProfileInClientGroupSet { get; set; }
        public virtual DbSet<ProfileInClientSet> ProfileInClientSet { get; set; }
        public virtual DbSet<ProfileSet> ProfileSet { get; set; }
        public virtual DbSet<PumpControllers> PumpControllers { get; set; }
        public virtual DbSet<PumpTypeSet> PumpTypeSet { get; set; }
        public virtual DbSet<QlikViewReportsSet> QlikViewReportsSet { get; set; }
        public virtual DbSet<RePrintTargetReasonSet> RePrintTargetReasonSet { get; set; }
        public virtual DbSet<ReaderFailureSet> ReaderFailureSet { get; set; }
        public virtual DbSet<ReaderStatuses> ReaderStatuses { get; set; }
        public virtual DbSet<ReaderTypeSet> ReaderTypeSet { get; set; }
        public virtual DbSet<Readers> Readers { get; set; }
        public virtual DbSet<ReceptorSet> ReceptorSet { get; set; }
        public virtual DbSet<RegimenFiscalSet> RegimenFiscalSet { get; set; }
        public virtual DbSet<RelacionEdcclienteSet> RelacionEdcclienteSet { get; set; }
        public virtual DbSet<RelationProductsSet> RelationProductsSet { get; set; }
        public virtual DbSet<ReplacementReasons> ReplacementReasons { get; set; }
        public virtual DbSet<ReportForClients> ReportForClients { get; set; }
        public virtual DbSet<ReportVtfileDetailsSet> ReportVtfileDetailsSet { get; set; }
        public virtual DbSet<ReportVts> ReportVts { get; set; }
        public virtual DbSet<RevisionMeterSet> RevisionMeterSet { get; set; }
        public virtual DbSet<RoleClientGroupSet> RoleClientGroupSet { get; set; }
        public virtual DbSet<RoleClientSet> RoleClientSet { get; set; }
        public virtual DbSet<RolePermissions> RolePermissions { get; set; }
        public virtual DbSet<RolesWebSet> RolesWebSet { get; set; }
        public virtual DbSet<RulesClientSet> RulesClientSet { get; set; }
        public virtual DbSet<RulesSet> RulesSet { get; set; }
        public virtual DbSet<SaldosLimitConfigSet> SaldosLimitConfigSet { get; set; }
        public virtual DbSet<SaldosSet> SaldosSet { get; set; }
        public virtual DbSet<SamcommandsSet> SamcommandsSet { get; set; }
        public virtual DbSet<SamrolComandoSet> SamrolComandoSet { get; set; }
        public virtual DbSet<SectionReasonsSet> SectionReasonsSet { get; set; }
        public virtual DbSet<SerieBillingSet> SerieBillingSet { get; set; }
        public virtual DbSet<SimgpsSet> SimgpsSet { get; set; }
        public virtual DbSet<StationTypes> StationTypes { get; set; }
        public virtual DbSet<StatusAppointmentSet> StatusAppointmentSet { get; set; }
        public virtual DbSet<StatusCallSet> StatusCallSet { get; set; }
        public virtual DbSet<StatusContingencySet> StatusContingencySet { get; set; }
        public virtual DbSet<StatusOrderSet> StatusOrderSet { get; set; }
        public virtual DbSet<StatusRevisionMeterSet> StatusRevisionMeterSet { get; set; }
        public virtual DbSet<StatusSet> StatusSet { get; set; }
        public virtual DbSet<StatusTicketSet> StatusTicketSet { get; set; }
        public virtual DbSet<SustitucionCfdiset> SustitucionCfdiset { get; set; }
        public virtual DbSet<SyncDisable> SyncDisable { get; set; }
        public virtual DbSet<SynchronizerFilesVersionSet> SynchronizerFilesVersionSet { get; set; }
        public virtual DbSet<TablePropertiesSet> TablePropertiesSet { get; set; }
        public virtual DbSet<TagTypes> TagTypes { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<TagsCopy> TagsCopy { get; set; }
        public virtual DbSet<TankIdentifiers> TankIdentifiers { get; set; }
        public virtual DbSet<TankVehiclesSet> TankVehiclesSet { get; set; }
        public virtual DbSet<TaskPrioritySet> TaskPrioritySet { get; set; }
        public virtual DbSet<TaskStatusSet> TaskStatusSet { get; set; }
        public virtual DbSet<TaxDataSet> TaxDataSet { get; set; }
        public virtual DbSet<TaxationSet> TaxationSet { get; set; }
        public virtual DbSet<TechnicalEmployeeSet> TechnicalEmployeeSet { get; set; }
        public virtual DbSet<TempDispatch> TempDispatch { get; set; }
        public virtual DbSet<TestContingencyCode> TestContingencyCode { get; set; }
        public virtual DbSet<TestingProductsSet> TestingProductsSet { get; set; }
        public virtual DbSet<TicketCloseRolSet> TicketCloseRolSet { get; set; }
        public virtual DbSet<TicketDetailMovementsSet> TicketDetailMovementsSet { get; set; }
        public virtual DbSet<TicketEventsSet> TicketEventsSet { get; set; }
        public virtual DbSet<TicketSet> TicketSet { get; set; }
        public virtual DbSet<TimbreFiscalSet> TimbreFiscalSet { get; set; }
        public virtual DbSet<TimeZoneCset> TimeZoneCset { get; set; }
        public virtual DbSet<TipoDeComprobanteSet> TipoDeComprobanteSet { get; set; }
        public virtual DbSet<TipoDeFactorSet> TipoDeFactorSet { get; set; }
        public virtual DbSet<TipoDeMonedaSet> TipoDeMonedaSet { get; set; }
        public virtual DbSet<TipoGpsSet> TipoGpsSet { get; set; }
        public virtual DbSet<TmpVehiclesCg> TmpVehiclesCg { get; set; }
        public virtual DbSet<TrasladosEdcset> TrasladosEdcset { get; set; }
        public virtual DbSet<TrasladosEdeset> TrasladosEdeset { get; set; }
        public virtual DbSet<TreatmentTypes> TreatmentTypes { get; set; }
        public virtual DbSet<TypeAccountSet> TypeAccountSet { get; set; }
        public virtual DbSet<TypeCallSet> TypeCallSet { get; set; }
        public virtual DbSet<TypeConceptBalanceSet> TypeConceptBalanceSet { get; set; }
        public virtual DbSet<TypeContigencySet> TypeContigencySet { get; set; }
        public virtual DbSet<TypeExpensesSet> TypeExpensesSet { get; set; }
        public virtual DbSet<TypeIdentifierSet> TypeIdentifierSet { get; set; }
        public virtual DbSet<TypeOfServiceByAreaSet> TypeOfServiceByAreaSet { get; set; }
        public virtual DbSet<TypeOfServiceSet> TypeOfServiceSet { get; set; }
        public virtual DbSet<TypeOfTicketSet> TypeOfTicketSet { get; set; }
        public virtual DbSet<UnattendedUnitCatalogSet> UnattendedUnitCatalogSet { get; set; }
        public virtual DbSet<UserWebSet> UserWebSet { get; set; }
        public virtual DbSet<UsersInClientGroupSet> UsersInClientGroupSet { get; set; }
        public virtual DbSet<UsersInProfileSet> UsersInProfileSet { get; set; }
        public virtual DbSet<UsersInRolesWebSet> UsersInRolesWebSet { get; set; }
        public virtual DbSet<UsoDeCfdiset> UsoDeCfdiset { get; set; }
        public virtual DbSet<VehicleBrands> VehicleBrands { get; set; }
        public virtual DbSet<VehicleLastOdometers> VehicleLastOdometers { get; set; }
        public virtual DbSet<VehiclePhoneCouplingSet> VehiclePhoneCouplingSet { get; set; }
        public virtual DbSet<VehicleTypes> VehicleTypes { get; set; }
        public virtual DbSet<Vehicles> Vehicles { get; set; }
        public virtual DbSet<ViewsCtrlsWebSet> ViewsCtrlsWebSet { get; set; }
        public virtual DbSet<ViewsWebSet> ViewsWebSet { get; set; }
        public virtual DbSet<VolumetricSet> VolumetricSet { get; set; }
        public virtual DbSet<VwAllEmployeesFromAppointment> VwAllEmployeesFromAppointment { get; set; }
        public virtual DbSet<VwAspnetApplications> VwAspnetApplications { get; set; }
        public virtual DbSet<VwAspnetMembershipUsers> VwAspnetMembershipUsers { get; set; }
        public virtual DbSet<VwAspnetProfiles> VwAspnetProfiles { get; set; }
        public virtual DbSet<VwAspnetRoles> VwAspnetRoles { get; set; }
        public virtual DbSet<VwAspnetUsers> VwAspnetUsers { get; set; }
        public virtual DbSet<VwAspnetUsersInRoles> VwAspnetUsersInRoles { get; set; }
        public virtual DbSet<VwAspnetWebPartStatePaths> VwAspnetWebPartStatePaths { get; set; }
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShared { get; set; }
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUser { get; set; }
        public virtual DbSet<VwCallRecordReport> VwCallRecordReport { get; set; }
        public virtual DbSet<VwConnectionByStation> VwConnectionByStation { get; set; }
        public virtual DbSet<VwConsumoDeDespachos> VwConsumoDeDespachos { get; set; }
        public virtual DbSet<VwContactPersonName> VwContactPersonName { get; set; }
        public virtual DbSet<VwContingenciasArreglar> VwContingenciasArreglar { get; set; }
        public virtual DbSet<VwContingencyReport> VwContingencyReport { get; set; }
        public virtual DbSet<VwContingencys> VwContingencys { get; set; }
        public virtual DbSet<VwDespachos> VwDespachos { get; set; }
        public virtual DbSet<VwDespachosC> VwDespachosC { get; set; }
        public virtual DbSet<VwDespachosNoFacturados> VwDespachosNoFacturados { get; set; }
        public virtual DbSet<VwDispatchedWithoutMessage> VwDispatchedWithoutMessage { get; set; }
        public virtual DbSet<VwEdcTimbrado> VwEdcTimbrado { get; set; }
        public virtual DbSet<VwEstadosDeCuenta> VwEstadosDeCuenta { get; set; }
        public virtual DbSet<VwGetDispatchForEvent> VwGetDispatchForEvent { get; set; }
        public virtual DbSet<VwGetDispatchInner> VwGetDispatchInner { get; set; }
        public virtual DbSet<VwGetDispatchs> VwGetDispatchs { get; set; }
        public virtual DbSet<VwGetDispatchsContigency> VwGetDispatchsContigency { get; set; }
        public virtual DbSet<VwGetDispatchsMultiSelection> VwGetDispatchsMultiSelection { get; set; }
        public virtual DbSet<VwGetDispatchsMultiSelectionQv> VwGetDispatchsMultiSelectionQv { get; set; }
        public virtual DbSet<VwGetGpsInstalled> VwGetGpsInstalled { get; set; }
        public virtual DbSet<VwGetSiteAccessQv> VwGetSiteAccessQv { get; set; }
        public virtual DbSet<VwGetVehicles> VwGetVehicles { get; set; }
        public virtual DbSet<VwGetVehiclesCg> VwGetVehiclesCg { get; set; }
        public virtual DbSet<VwGpsReport> VwGpsReport { get; set; }
        public virtual DbSet<VwPaymentsToStations> VwPaymentsToStations { get; set; }
        public virtual DbSet<VwPerfilParametroPorCliente> VwPerfilParametroPorCliente { get; set; }
        public virtual DbSet<VwPhoneCouplingReport> VwPhoneCouplingReport { get; set; }
        public virtual DbSet<VwPlanTrabajoTecnicos> VwPlanTrabajoTecnicos { get; set; }
        public virtual DbSet<VwPossibleFailuresAuthorizing> VwPossibleFailuresAuthorizing { get; set; }
        public virtual DbSet<VwPreciosEstacion> VwPreciosEstacion { get; set; }
        public virtual DbSet<VwPriceGas> VwPriceGas { get; set; }
        public virtual DbSet<VwQvallUsers> VwQvallUsers { get; set; }
        public virtual DbSet<VwReporteEstaciones> VwReporteEstaciones { get; set; }
        public virtual DbSet<VwReporteOpFinanzas> VwReporteOpFinanzas { get; set; }
        public virtual DbSet<VwReportePagoEdc> VwReportePagoEdc { get; set; }
        public virtual DbSet<VwSubrerporte> VwSubrerporte { get; set; }
        public virtual DbSet<VwUsersInClientGroupSet> VwUsersInClientGroupSet { get; set; }
        public virtual DbSet<VwVehiclesProducts> VwVehiclesProducts { get; set; }
        public virtual DbSet<WeeklyReportSet> WeeklyReportSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=192.168.2.110;Initial Catalog=OxxoBo;Persist Security Info=True;User ID=desarrollogng;Password=#eu$w@~ogd;Connection Timeout=1800000");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccesoriesSet>(entity =>
            {
                entity.Property(e => e.AccesoriesGasStation).HasColumnName("Accesories_GasStation");

                entity.Property(e => e.AccesoriesGps).HasColumnName("Accesories_Gps");

                entity.Property(e => e.AccesoriesReplacementReason).HasColumnName("Accesories_ReplacementReason");

                entity.Property(e => e.AccesoriesTankVehicles).HasColumnName("Accesories_TankVehicles");

                entity.Property(e => e.AccesoriesTreatmentType).HasColumnName("Accesories_TreatmentType");

                entity.Property(e => e.AccesoriesVehicle).HasColumnName("Accesories_Vehicle");

                entity.Property(e => e.ActivationDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FisicalLocation).HasMaxLength(255);

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProductsAccesories).HasColumnName("Products_Accesories");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SerialNumber).HasMaxLength(255);

                entity.Property(e => e.ServiceDataTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TestingProductsAccesories).HasColumnName("TestingProducts_Accesories");

                entity.HasOne(d => d.AccesoriesGasStationNavigation)
                    .WithMany(p => p.AccesoriesSet)
                    .HasForeignKey(d => d.AccesoriesGasStation)
                    .HasConstraintName("Accesories_GasStation");

                entity.HasOne(d => d.AccesoriesGpsNavigation)
                    .WithMany(p => p.AccesoriesSet)
                    .HasForeignKey(d => d.AccesoriesGps)
                    .HasConstraintName("Accesories_Gps");

                entity.HasOne(d => d.AccesoriesReplacementReasonNavigation)
                    .WithMany(p => p.AccesoriesSet)
                    .HasForeignKey(d => d.AccesoriesReplacementReason)
                    .HasConstraintName("Accesories_ReplacementReason");

                entity.HasOne(d => d.AccesoriesTankVehiclesNavigation)
                    .WithMany(p => p.AccesoriesSet)
                    .HasForeignKey(d => d.AccesoriesTankVehicles)
                    .HasConstraintName("Accesories_TankVehicles");

                entity.HasOne(d => d.AccesoriesTreatmentTypeNavigation)
                    .WithMany(p => p.AccesoriesSet)
                    .HasForeignKey(d => d.AccesoriesTreatmentType)
                    .HasConstraintName("Accesories_TreatmentType");

                entity.HasOne(d => d.AccesoriesVehicleNavigation)
                    .WithMany(p => p.AccesoriesSet)
                    .HasForeignKey(d => d.AccesoriesVehicle)
                    .HasConstraintName("Accesories_Vehicle");

                entity.HasOne(d => d.ProductsAccesoriesNavigation)
                    .WithMany(p => p.AccesoriesSet)
                    .HasForeignKey(d => d.ProductsAccesories)
                    .HasConstraintName("Products_Accesories");

                entity.HasOne(d => d.TestingProductsAccesoriesNavigation)
                    .WithMany(p => p.AccesoriesSet)
                    .HasForeignKey(d => d.TestingProductsAccesories)
                    .HasConstraintName("TestingProducts_Accesories");
            });

            modelBuilder.Entity<AccountGngSet>(entity =>
            {
                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankAccountGng).HasColumnName("Bank_AccountGng");

                entity.Property(e => e.Clabe)
                    .IsRequired()
                    .HasColumnName("CLABE")
                    .HasMaxLength(18)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(35)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BankAccountGngNavigation)
                    .WithMany(p => p.AccountGngSet)
                    .HasForeignKey(d => d.BankAccountGng)
                    .HasConstraintName("Bank_AccountGng");
            });

            modelBuilder.Entity<ActivityInStationSet>(entity =>
            {
                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.Property(e => e.AddressCity).HasColumnName("Address_City");

                entity.Property(e => e.AddressCountry).HasColumnName("Address_Country");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Colony).HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Latitud).HasMaxLength(255);

                entity.Property(e => e.Longitud).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Phone2).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Street1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Street2).HasMaxLength(255);

                entity.HasOne(d => d.AddressCityNavigation)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressCity)
                    .HasConstraintName("Address_City");

                entity.HasOne(d => d.AddressCountryNavigation)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Address_Country");
            });

            modelBuilder.Entity<AlertAuthContingencySet>(entity =>
            {
                entity.Property(e => e.AlertAuthContingencyContactPerson).HasColumnName("AlertAuthContingency_ContactPerson");

                entity.Property(e => e.AlertAuthContingencyContactPerson1).HasColumnName("AlertAuthContingency_ContactPerson1");

                entity.Property(e => e.ComentariosCarga).HasMaxLength(255);

                entity.Property(e => e.ComentariosCobro).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IdAlerta).HasColumnName("id_alerta");

                entity.Property(e => e.IdContingency)
                    .HasColumnName("id_contingency")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TimeCarga).HasColumnType("datetime");

                entity.Property(e => e.TimeCobro).HasColumnType("datetime");

                entity.HasOne(d => d.AlertAuthContingencyContactPersonNavigation)
                    .WithMany(p => p.AlertAuthContingencySetAlertAuthContingencyContactPersonNavigation)
                    .HasForeignKey(d => d.AlertAuthContingencyContactPerson)
                    .HasConstraintName("AlertAuthContingency_ContactPerson");

                entity.HasOne(d => d.AlertAuthContingencyContactPerson1Navigation)
                    .WithMany(p => p.AlertAuthContingencySetAlertAuthContingencyContactPerson1Navigation)
                    .HasForeignKey(d => d.AlertAuthContingencyContactPerson1)
                    .HasConstraintName("AlertAuthContingency_ContactPerson1");
            });

            modelBuilder.Entity<AlertasSet>(entity =>
            {
                entity.Property(e => e.ActionAlarm).HasMaxLength(255);

                entity.Property(e => e.BodyMail).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IdScreen).HasMaxLength(255);

                entity.Property(e => e.IdSet).HasColumnName("idSet");

                entity.Property(e => e.MessageAlarm).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameAlarm).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Screen).HasMaxLength(255);

                entity.Property(e => e.SetAttribute).HasMaxLength(255);

                entity.Property(e => e.SubjectMail).HasMaxLength(255);

                entity.Property(e => e.ToMail).HasMaxLength(255);

                entity.Property(e => e.TypeSet).HasMaxLength(255);

                entity.Property(e => e.ValueSet).HasMaxLength(255);
            });

            modelBuilder.Entity<AllCfdiSet>(entity =>
            {
                entity.Property(e => e.AllCfdiEdc).HasColumnName("AllCfdi_EDC");

                entity.Property(e => e.AllCfdiEde).HasColumnName("AllCfdi_EDE");

                entity.Property(e => e.CfdirelacionadosAllCfdi).HasColumnName("CFDIRelacionados_AllCfdi");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.MontoDeposito).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AllCfdiEdcNavigation)
                    .WithMany(p => p.AllCfdiSet)
                    .HasForeignKey(d => d.AllCfdiEdc)
                    .HasConstraintName("AllCfdi_EDC");

                entity.HasOne(d => d.AllCfdiEdeNavigation)
                    .WithMany(p => p.AllCfdiSet)
                    .HasForeignKey(d => d.AllCfdiEde)
                    .HasConstraintName("AllCfdi_EDE");

                entity.HasOne(d => d.CfdirelacionadosAllCfdiNavigation)
                    .WithMany(p => p.AllCfdiSet)
                    .HasForeignKey(d => d.CfdirelacionadosAllCfdi)
                    .HasConstraintName("CFDIRelacionados_AllCfdi");
            });

            modelBuilder.Entity<AllTablesSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ShowName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AllowedStationSet>(entity =>
            {
                entity.Property(e => e.AllowedStationGasStation).HasColumnName("AllowedStation_GasStation");

                entity.Property(e => e.AllowedStationRules).HasColumnName("AllowedStation_Rules");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AllowedStationGasStationNavigation)
                    .WithMany(p => p.AllowedStationSet)
                    .HasForeignKey(d => d.AllowedStationGasStation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AllowedStation_GasStation");

                entity.HasOne(d => d.AllowedStationRulesNavigation)
                    .WithMany(p => p.AllowedStationSet)
                    .HasForeignKey(d => d.AllowedStationRules)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AllowedStation_Rules");
            });

            modelBuilder.Entity<AltoTrackSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.From)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UntilT)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AltoTrackVehiclesSet>(entity =>
            {
                entity.Property(e => e.Cedi)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Antennas>(entity =>
            {
                entity.HasIndex(e => e.Serial)
                    .HasName("UQ__tmp_ms_x__1A00E09355D319D1")
                    .IsUnique();

                entity.Property(e => e.ActualIp)
                    .HasColumnName("Actual_Ip")
                    .HasMaxLength(15);

                entity.Property(e => e.AntennaReplacementReason).HasColumnName("Antenna_ReplacementReason");

                entity.Property(e => e.CablesLocationDescription).HasMaxLength(255);

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.GasStationAntenna).HasColumnName("GasStation_Antenna");

                entity.Property(e => e.InstallationDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PowerSupplyLocationDescription).HasMaxLength(255);

                entity.Property(e => e.ProductsAntenna1).HasColumnName("Products_Antenna1");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.AntennaReplacementReasonNavigation)
                    .WithMany(p => p.Antennas)
                    .HasForeignKey(d => d.AntennaReplacementReason)
                    .HasConstraintName("Antenna_ReplacementReason");

                entity.HasOne(d => d.GasStationAntennaNavigation)
                    .WithMany(p => p.Antennas)
                    .HasForeignKey(d => d.GasStationAntenna)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GasStation_Antenna");

                entity.HasOne(d => d.ProductsAntenna1Navigation)
                    .WithMany(p => p.Antennas)
                    .HasForeignKey(d => d.ProductsAntenna1)
                    .HasConstraintName("Products_Antenna");
            });

            modelBuilder.Entity<ApplicationHistorySet>(entity =>
            {
                entity.Property(e => e.AppOrigen)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChangeType)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeOperation)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Inserted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Modulo)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewValues)
                    .IsRequired()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OriginalValues)
                    .IsRequired()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferenceType)
                    .IsRequired()
                    .HasMaxLength(400)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<AppointmentServiceSet>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AppointmentServiceCity).HasColumnName("AppointmentService_City");

                entity.Property(e => e.AppointmentServiceEmployee).HasColumnName("AppointmentService_Employee");

                entity.Property(e => e.AppointmentServiceStatusAppointment).HasColumnName("AppointmentService_StatusAppointment");

                entity.Property(e => e.AppointmentServiceTaskPriority).HasColumnName("AppointmentService_TaskPriority");

                entity.Property(e => e.AppointmentServiceTypeOfService).HasColumnName("AppointmentService_TypeOfService");

                entity.Property(e => e.Contact).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateAppointment)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateFinish)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateRealFinish).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AppointmentServiceCityNavigation)
                    .WithMany(p => p.AppointmentServiceSet)
                    .HasForeignKey(d => d.AppointmentServiceCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppointmentService_City");

                entity.HasOne(d => d.AppointmentServiceEmployeeNavigation)
                    .WithMany(p => p.AppointmentServiceSet)
                    .HasForeignKey(d => d.AppointmentServiceEmployee)
                    .HasConstraintName("AppointmentService_Employee");

                entity.HasOne(d => d.AppointmentServiceStatusAppointmentNavigation)
                    .WithMany(p => p.AppointmentServiceSet)
                    .HasForeignKey(d => d.AppointmentServiceStatusAppointment)
                    .HasConstraintName("AppointmentService_StatusAppointment");

                entity.HasOne(d => d.AppointmentServiceTaskPriorityNavigation)
                    .WithMany(p => p.AppointmentServiceSet)
                    .HasForeignKey(d => d.AppointmentServiceTaskPriority)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppointmentService_TaskPriority");

                entity.HasOne(d => d.AppointmentServiceTypeOfServiceNavigation)
                    .WithMany(p => p.AppointmentServiceSet)
                    .HasForeignKey(d => d.AppointmentServiceTypeOfService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AppointmentService_TypeOfService");
            });

            modelBuilder.Entity<ArchivosDatosFiscalesSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DatosFiscalesArchivosDatosFiscales).HasColumnName("DatosFiscales_ArchivosDatosFiscales");

                entity.Property(e => e.FileExtension).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DatosFiscalesArchivosDatosFiscalesNavigation)
                    .WithMany(p => p.ArchivosDatosFiscalesSet)
                    .HasForeignKey(d => d.DatosFiscalesArchivosDatosFiscales)
                    .HasConstraintName("DatosFiscales_ArchivosDatosFiscales");
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("FK_aspnet_Applications_ApplicationId")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_A__30910331F407F1DA")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_aspnet_Membership_UserId")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail })
                    .HasName("aspnet_Membership_index")
                    .IsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMembership)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_Membership_ApplicationId_aspnet_Applications_ApplicationId");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_Membership_UserId_aspnet_Users_UserId");
            });

            modelBuilder.Entity<AspnetPaths>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("FK_aspnet_Paths_PathId")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath })
                    .HasName("aspnet_Paths_index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_Paths_ApplicationId_Applications_ApplicationId");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUsers>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK_aspnet_PersonalizationAllUsers_PathId");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUsers)
                    .HasForeignKey<AspnetPersonalizationAllUsers>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_PersonalizationAllUsers_PathId_aspnet_Paths_PathId");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_aspnet_PersonalizationPerUser_Id")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.HasIndex(e => new { e.PathId, e.UserId })
                    .HasName("aspnet_PersonalizationPerUser_index1")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => new { e.UserId, e.PathId })
                    .HasName("aspnet_PersonalizationPerUser_ncindex2")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK_aspnet_PersonalizationPerUser_PathId_aspnet_Paths_PathId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_aspnet_PersonalizationPerUser_UserId_aspnet_Users_UserId");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_aspnet_Profile_UserId");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_Profile_UserId_aspnet_Users_UserId");
            });

            modelBuilder.Entity<AspnetRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_aspnet_Roles_RoleId")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName })
                    .HasName("aspnet_Roles_index1")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_Roles_ApplicationId_aspnet_Applications_ApplicationId");
            });

            modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK_aspnet_SchemaVersions_Feature_CompatibleSchemaVersion");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_aspnet_Users_UserId")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
                    .HasName("aspnet_Users_Index2");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
                    .HasName("aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_Users_ApplicationId_aspnet_Applications_ApplicationId");
            });

            modelBuilder.Entity<AspnetUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_aspnet_UsersInRoles_UserId");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("aspnet_UsersInRoles_index");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_UsersInRoles_RoleId_aspnet_Roles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_aspnet_UsersInRoles_UserId_aspnet_Users_UserId");
            });

            modelBuilder.Entity<AspnetWebEventEvents>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_aspnet_WebEvent_Events_EventId");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<AttachFilesSet>(entity =>
            {
                entity.Property(e => e.AttachFilesTicket).HasColumnName("AttachFiles_Ticket");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AttachFilesTicketNavigation)
                    .WithMany(p => p.AttachFilesSet)
                    .HasForeignKey(d => d.AttachFilesTicket)
                    .HasConstraintName("AttachFiles_Ticket");
            });

            modelBuilder.Entity<AuditTrailSet>(entity =>
            {
                entity.Property(e => e.ChangeType)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChangedBy)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DataSource)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeySegment)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReferenceType)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AuditWebSet>(entity =>
            {
                entity.Property(e => e.AuditWebUserWeb).HasColumnName("AuditWeb_UserWeb");

                entity.Property(e => e.ChangeType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChangedBy)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DataSource)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeySegment)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ReferenceType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AuditWebUserWebNavigation)
                    .WithMany(p => p.AuditWebSet)
                    .HasForeignKey(d => d.AuditWebUserWeb)
                    .HasConstraintName("AuditWeb_UserWeb");
            });

            modelBuilder.Entity<BadPositionsWhileChargingSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EcoNumber).HasMaxLength(255);

                entity.Property(e => e.Latitude).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Plate).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<BalanceTransactionsSet>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceTransactionsClientGroup).HasColumnName("BalanceTransactions_ClientGroup");

                entity.Property(e => e.BalanceTransactionsTypeConceptBalance).HasColumnName("BalanceTransactions_TypeConceptBalance");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeOperation)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BalanceTransactionsClientGroupNavigation)
                    .WithMany(p => p.BalanceTransactionsSet)
                    .HasForeignKey(d => d.BalanceTransactionsClientGroup)
                    .HasConstraintName("BalanceTransactions_ClientGroup");

                entity.HasOne(d => d.BalanceTransactionsTypeConceptBalanceNavigation)
                    .WithMany(p => p.BalanceTransactionsSet)
                    .HasForeignKey(d => d.BalanceTransactionsTypeConceptBalance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BalanceTransactions_TypeConceptBalance");
            });

            modelBuilder.Entity<BankSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<BankingDepositSet>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankReference)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeDeposit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TranferNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<BatteryFailureSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DescriptionFailure)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<BatterySet>(entity =>
            {
                entity.HasIndex(e => e.SerialNumber)
                    .HasName("UQ__tmp_ms_x__048A00081B4982C2")
                    .IsUnique();

                entity.Property(e => e.BatteryBatteryFailure).HasColumnName("Battery_BatteryFailure");

                entity.Property(e => e.BatteryReplacementReason).HasColumnName("Battery_ReplacementReason");

                entity.Property(e => e.BatteryTypeBattery).HasColumnName("BatteryType_Battery");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateInstallation).HasColumnType("datetime");

                entity.Property(e => e.DateSendLaboratory).HasColumnType("datetime");

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.FuelType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GasStationBattery).HasColumnName("GasStation_Battery");

                entity.Property(e => e.LaboratoryNumber).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProductsBattery1).HasColumnName("Products_Battery1");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Voltage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.BatteryBatteryFailureNavigation)
                    .WithMany(p => p.BatterySet)
                    .HasForeignKey(d => d.BatteryBatteryFailure)
                    .HasConstraintName("Battery_BatteryFailure");

                entity.HasOne(d => d.BatteryReplacementReasonNavigation)
                    .WithMany(p => p.BatterySet)
                    .HasForeignKey(d => d.BatteryReplacementReason)
                    .HasConstraintName("Battery_ReplacementReason");

                entity.HasOne(d => d.BatteryTypeBatteryNavigation)
                    .WithMany(p => p.BatterySet)
                    .HasForeignKey(d => d.BatteryTypeBattery)
                    .HasConstraintName("BatteryType_Battery");

                entity.HasOne(d => d.GasStationBatteryNavigation)
                    .WithMany(p => p.BatterySet)
                    .HasForeignKey(d => d.GasStationBattery)
                    .HasConstraintName("GasStation_Battery");

                entity.HasOne(d => d.ProductsBattery1Navigation)
                    .WithMany(p => p.BatterySet)
                    .HasForeignKey(d => d.ProductsBattery1)
                    .HasConstraintName("Products_Battery");
            });

            modelBuilder.Entity<BatteryTypeSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<BillingSet>(entity =>
            {
                entity.ToTable("BIllingSet");

                entity.Property(e => e.BillingClientGroup).HasColumnName("BIlling_ClientGroup");

                entity.Property(e => e.BillingEdc).HasColumnName("BIlling_EDC");

                entity.Property(e => e.BillingEde).HasColumnName("BIlling_EDE");

                entity.Property(e => e.BillingGasStation).HasColumnName("BIlling_GasStation");

                entity.Property(e => e.BillingRelacionEdccliente).HasColumnName("BIlling_RelacionEDCCliente");

                entity.Property(e => e.Comentarios).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Errores).HasMaxLength(255);

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEjecucion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaPeriodaFin)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaPeriodoInicio)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaTimbrado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TotalComisionEde)
                    .HasColumnName("TotalComisionEDE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalIvacomisionEde)
                    .HasColumnName("TotalIVAComisionEDE")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.BillingClientGroupNavigation)
                    .WithMany(p => p.BillingSet)
                    .HasForeignKey(d => d.BillingClientGroup)
                    .HasConstraintName("BIlling_ClientGroup");

                entity.HasOne(d => d.BillingEdcNavigation)
                    .WithMany(p => p.BillingSet)
                    .HasForeignKey(d => d.BillingEdc)
                    .HasConstraintName("BIlling_EDC");

                entity.HasOne(d => d.BillingEdeNavigation)
                    .WithMany(p => p.BillingSet)
                    .HasForeignKey(d => d.BillingEde)
                    .HasConstraintName("BIlling_EDE");

                entity.HasOne(d => d.BillingGasStationNavigation)
                    .WithMany(p => p.BillingSet)
                    .HasForeignKey(d => d.BillingGasStation)
                    .HasConstraintName("BIlling_GasStation");

                entity.HasOne(d => d.BillingRelacionEdcclienteNavigation)
                    .WithMany(p => p.BillingSet)
                    .HasForeignKey(d => d.BillingRelacionEdccliente)
                    .HasConstraintName("BIlling_RelacionEDCCliente");
            });

            modelBuilder.Entity<BrandModels>(entity =>
            {
                entity.Property(e => e.BrandModelVehicleBrand).HasColumnName("BrandModel_VehicleBrand");

                entity.Property(e => e.BrandModelsFuelTypes).HasColumnName("BrandModels_FuelTypes");

                entity.Property(e => e.BrandModelsOdometerUnits).HasColumnName("BrandModels_OdometerUnits");

                entity.Property(e => e.BrandModelsVehicleTypes).HasColumnName("BrandModels_VehicleTypes");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DefaultEstimatedCons).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BrandModelVehicleBrandNavigation)
                    .WithMany(p => p.BrandModels)
                    .HasForeignKey(d => d.BrandModelVehicleBrand)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BrandModel_VehicleBrand");

                entity.HasOne(d => d.BrandModelsFuelTypesNavigation)
                    .WithMany(p => p.BrandModels)
                    .HasForeignKey(d => d.BrandModelsFuelTypes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BrandModel_FuelType");

                entity.HasOne(d => d.BrandModelsOdometerUnitsNavigation)
                    .WithMany(p => p.BrandModels)
                    .HasForeignKey(d => d.BrandModelsOdometerUnits)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BrandModel_OdometerUnit");

                entity.HasOne(d => d.BrandModelsVehicleTypesNavigation)
                    .WithMany(p => p.BrandModels)
                    .HasForeignKey(d => d.BrandModelsVehicleTypes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BrandModel_VehicleType");
            });

            modelBuilder.Entity<CallRecordSet>(entity =>
            {
                entity.Property(e => e.CallRecordClient).HasColumnName("CallRecord_Client");

                entity.Property(e => e.CallRecordClientGroup).HasColumnName("CallRecord_ClientGroup");

                entity.Property(e => e.CallRecordContingency).HasColumnName("CallRecord_Contingency");

                entity.Property(e => e.CallRecordDepartment).HasColumnName("CallRecord_Department");

                entity.Property(e => e.CallRecordEmployee).HasColumnName("CallRecord_Employee");

                entity.Property(e => e.CallRecordGasStation).HasColumnName("CallRecord_GasStation");

                entity.Property(e => e.CallRecordStatusCall).HasColumnName("CallRecord_StatusCall");

                entity.Property(e => e.CallRecordTypeCall).HasColumnName("CallRecord_TypeCall");

                entity.Property(e => e.CallRecordTypeIdentifier).HasColumnName("CallRecord_TypeIdentifier");

                entity.Property(e => e.CallRecordVehicle).HasColumnName("CallRecord_Vehicle");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeEnd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateTimeStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameOfPeople)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PhoneSource).HasMaxLength(20);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CallRecordClientNavigation)
                    .WithMany(p => p.CallRecordSet)
                    .HasForeignKey(d => d.CallRecordClient)
                    .HasConstraintName("CallRecord_Client");

                entity.HasOne(d => d.CallRecordClientGroupNavigation)
                    .WithMany(p => p.CallRecordSet)
                    .HasForeignKey(d => d.CallRecordClientGroup)
                    .HasConstraintName("CallRecord_ClientGroup");

                entity.HasOne(d => d.CallRecordContingencyNavigation)
                    .WithMany(p => p.CallRecordSet)
                    .HasForeignKey(d => d.CallRecordContingency)
                    .HasConstraintName("CallRecord_Contingency");

                entity.HasOne(d => d.CallRecordDepartmentNavigation)
                    .WithMany(p => p.CallRecordSet)
                    .HasForeignKey(d => d.CallRecordDepartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CallRecord_Department");

                entity.HasOne(d => d.CallRecordEmployeeNavigation)
                    .WithMany(p => p.CallRecordSet)
                    .HasForeignKey(d => d.CallRecordEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CallRecord_Employee");

                entity.HasOne(d => d.CallRecordGasStationNavigation)
                    .WithMany(p => p.CallRecordSet)
                    .HasForeignKey(d => d.CallRecordGasStation)
                    .HasConstraintName("CallRecord_GasStation");

                entity.HasOne(d => d.CallRecordStatusCallNavigation)
                    .WithMany(p => p.CallRecordSet)
                    .HasForeignKey(d => d.CallRecordStatusCall)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CallRecord_StatusCall");

                entity.HasOne(d => d.CallRecordTypeCallNavigation)
                    .WithMany(p => p.CallRecordSet)
                    .HasForeignKey(d => d.CallRecordTypeCall)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CallRecord_TypeCall");

                entity.HasOne(d => d.CallRecordTypeIdentifierNavigation)
                    .WithMany(p => p.CallRecordSet)
                    .HasForeignKey(d => d.CallRecordTypeIdentifier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CallRecord_TypeIdentifier");

                entity.HasOne(d => d.CallRecordVehicleNavigation)
                    .WithMany(p => p.CallRecordSet)
                    .HasForeignKey(d => d.CallRecordVehicle)
                    .HasConstraintName("CallRecord_Vehicle");
            });

            modelBuilder.Entity<CatAvlcustomfieldsSet>(entity =>
            {
                entity.ToTable("CatAVLCustomfieldsSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CustomFieldDataType).HasMaxLength(255);

                entity.Property(e => e.CustomFieldLabel)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Homologate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CatCombustibleSet>(entity =>
            {
                entity.ToTable("catCombustibleSet");

                entity.Property(e => e.CClaveTipoCombustible)
                    .IsRequired()
                    .HasColumnName("c_ClaveTipoCombustible")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TipoCombustible)
                    .IsRequired()
                    .HasMaxLength(180)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CatCustomStickersModels>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CatCustomStickersStatusSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CatDeviceSet>(entity =>
            {
                entity.Property(e => e.AppointmentServiceCatDevice).HasColumnName("AppointmentService_CatDevice");

                entity.Property(e => e.CatDeviceBatteryType).HasColumnName("CatDevice_BatteryType");

                entity.Property(e => e.CatDeviceGasStation).HasColumnName("CatDevice_GasStation");

                entity.Property(e => e.CatDeviceGrttype1).HasColumnName("CatDevice_GRTType1");

                entity.Property(e => e.CatDeviceMeterType).HasColumnName("CatDevice_MeterType");

                entity.Property(e => e.CatDeviceReaderType).HasColumnName("CatDevice_ReaderType");

                entity.Property(e => e.CatDeviceTagType).HasColumnName("CatDevice_TagType");

                entity.Property(e => e.CatDeviceTipoGps).HasColumnName("CatDevice_TipoGps");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Quantity).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VehicleCatDevice1).HasColumnName("Vehicle_CatDevice1");

                entity.HasOne(d => d.AppointmentServiceCatDeviceNavigation)
                    .WithMany(p => p.CatDeviceSet)
                    .HasForeignKey(d => d.AppointmentServiceCatDevice)
                    .HasConstraintName("AppointmentService_CatDevice");

                entity.HasOne(d => d.CatDeviceBatteryTypeNavigation)
                    .WithMany(p => p.CatDeviceSet)
                    .HasForeignKey(d => d.CatDeviceBatteryType)
                    .HasConstraintName("CatDevice_BatteryType");

                entity.HasOne(d => d.CatDeviceGasStationNavigation)
                    .WithMany(p => p.CatDeviceSet)
                    .HasForeignKey(d => d.CatDeviceGasStation)
                    .HasConstraintName("CatDevice_GasStation");

                entity.HasOne(d => d.CatDeviceGrttype1Navigation)
                    .WithMany(p => p.CatDeviceSet)
                    .HasForeignKey(d => d.CatDeviceGrttype1)
                    .HasConstraintName("CatDevice_GRTType");

                entity.HasOne(d => d.CatDeviceMeterTypeNavigation)
                    .WithMany(p => p.CatDeviceSet)
                    .HasForeignKey(d => d.CatDeviceMeterType)
                    .HasConstraintName("CatDevice_MeterType");

                entity.HasOne(d => d.CatDeviceReaderTypeNavigation)
                    .WithMany(p => p.CatDeviceSet)
                    .HasForeignKey(d => d.CatDeviceReaderType)
                    .HasConstraintName("CatDevice_ReaderType");

                entity.HasOne(d => d.CatDeviceTagTypeNavigation)
                    .WithMany(p => p.CatDeviceSet)
                    .HasForeignKey(d => d.CatDeviceTagType)
                    .HasConstraintName("CatDevice_TagType");

                entity.HasOne(d => d.CatDeviceTipoGpsNavigation)
                    .WithMany(p => p.CatDeviceSet)
                    .HasForeignKey(d => d.CatDeviceTipoGps)
                    .HasConstraintName("CatDevice_TipoGps");

                entity.HasOne(d => d.VehicleCatDevice1Navigation)
                    .WithMany(p => p.CatDeviceSet)
                    .HasForeignKey(d => d.VehicleCatDevice1)
                    .HasConstraintName("Vehicle_CatDevice");
            });

            modelBuilder.Entity<CatExpertiseSet>(entity =>
            {
                entity.ToTable("Cat_ExpertiseSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CatMetodoPagoSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CatalogParametersSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Value).HasMaxLength(255);
            });

            modelBuilder.Entity<CatalogScreensSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DescriptionScreen).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameScreen).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CatalogTypeSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameDescription).HasMaxLength(255);

                entity.Property(e => e.NameSet).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CatalogTypeSetAttributteSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IdEntity)
                    .HasColumnName("id_Entity")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameAttribute).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CfdirelacionadosSet>(entity =>
            {
                entity.ToTable("CFDIRelacionadosSet");

                entity.Property(e => e.CfdirelacionadosDepositos).HasColumnName("CFDIRelacionados_Depositos");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CfdirelacionadosDepositosNavigation)
                    .WithMany(p => p.CfdirelacionadosSet)
                    .HasForeignKey(d => d.CfdirelacionadosDepositos)
                    .HasConstraintName("CFDIRelacionados_Depositos");
            });

            modelBuilder.Entity<ChangeRequestPlateSet>(entity =>
            {
                entity.Property(e => e.AutorizationKey).HasMaxLength(255);

                entity.Property(e => e.ChangeRequestPlateClient1).HasColumnName("ChangeRequestPlate_Client1");

                entity.Property(e => e.ChangeRequestPlateEmployee).HasColumnName("ChangeRequestPlate_Employee");

                entity.Property(e => e.ChangeRequestPlateVehicle1).HasColumnName("ChangeRequestPlate_Vehicle1");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EcoBefore).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PlateBefore).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VinBefore).HasMaxLength(255);

                entity.HasOne(d => d.ChangeRequestPlateClient1Navigation)
                    .WithMany(p => p.ChangeRequestPlateSet)
                    .HasForeignKey(d => d.ChangeRequestPlateClient1)
                    .HasConstraintName("ChangeRequestPlate_Client");

                entity.HasOne(d => d.ChangeRequestPlateEmployeeNavigation)
                    .WithMany(p => p.ChangeRequestPlateSet)
                    .HasForeignKey(d => d.ChangeRequestPlateEmployee)
                    .HasConstraintName("ChangeRequestPlate_Employee");

                entity.HasOne(d => d.ChangeRequestPlateVehicle1Navigation)
                    .WithMany(p => p.ChangeRequestPlateSet)
                    .HasForeignKey(d => d.ChangeRequestPlateVehicle1)
                    .HasConstraintName("ChangeRequestPlate_Vehicle");
            });

            modelBuilder.Entity<CitySet>(entity =>
            {
                entity.Property(e => e.CityReceptor).HasColumnName("City_Receptor");

                entity.Property(e => e.CountryCity).HasColumnName("Country_City");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CveEst)
                    .HasColumnName("Cve_Est")
                    .HasMaxLength(3);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameCity)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CityReceptorNavigation)
                    .WithMany(p => p.CitySet)
                    .HasForeignKey(d => d.CityReceptor)
                    .HasConstraintName("City_Receptor");

                entity.HasOne(d => d.CountryCityNavigation)
                    .WithMany(p => p.CitySet)
                    .HasForeignKey(d => d.CountryCity)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Country_City");
            });

            modelBuilder.Entity<ClaveProdServSet>(entity =>
            {
                entity.Property(e => e.CClaveProdServ)
                    .IsRequired()
                    .HasColumnName("c_ClaveProdServ")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ClientGroupInGpsSet>(entity =>
            {
                entity.Property(e => e.ClientGroupInGpsClientGroup).HasColumnName("ClientGroupInGps_ClientGroup");

                entity.Property(e => e.ClientGroupInGpsGpsServer).HasColumnName("ClientGroupInGps_GpsServer");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClientGroupInGpsClientGroupNavigation)
                    .WithMany(p => p.ClientGroupInGpsSet)
                    .HasForeignKey(d => d.ClientGroupInGpsClientGroup)
                    .HasConstraintName("ClientGroupInGps_ClientGroup");

                entity.HasOne(d => d.ClientGroupInGpsGpsServerNavigation)
                    .WithMany(p => p.ClientGroupInGpsSet)
                    .HasForeignKey(d => d.ClientGroupInGpsGpsServer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClientGroupInGps_GpsServer");
            });

            modelBuilder.Entity<ClientGroups>(entity =>
            {
                entity.Property(e => e.BalanceCalculated).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceCalculatedAlertThresholdLast).HasColumnType("datetime");

                entity.Property(e => e.CatMetodoPagoClientGroup).HasColumnName("CatMetodoPago_ClientGroup");

                entity.Property(e => e.ClientGroupAddress).HasColumnName("ClientGroup_Address");

                entity.Property(e => e.ClientGroupEmployee).HasColumnName("ClientGroup_Employee");

                entity.Property(e => e.ClientGroupTypeAccount).HasColumnName("ClientGroup_TypeAccount");

                entity.Property(e => e.ConfiguracionEdClientGroup).HasColumnName("ConfiguracionED_ClientGroup");

                entity.Property(e => e.ControlCompanyClientGroup).HasColumnName("ControlCompany_ClientGroup");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreditMaximum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CuotasEdClientGroup).HasColumnName("CuotasED_ClientGroup");

                entity.Property(e => e.FormaDePagoClientGroup).HasColumnName("FormaDePago_ClientGroup");

                entity.Property(e => e.Guidservices).HasColumnName("GUIDServices");

                entity.Property(e => e.IdTotvs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SaldosLimitConfigClientGroup).HasColumnName("SaldosLimitConfig_ClientGroup");

                entity.Property(e => e.SendMailForReportVt).HasColumnName("SendMailForReportVT");

                entity.HasOne(d => d.CatMetodoPagoClientGroupNavigation)
                    .WithMany(p => p.ClientGroups)
                    .HasForeignKey(d => d.CatMetodoPagoClientGroup)
                    .HasConstraintName("CatMetodoPago_ClientGroup");

                entity.HasOne(d => d.ClientGroupAddressNavigation)
                    .WithMany(p => p.ClientGroups)
                    .HasForeignKey(d => d.ClientGroupAddress)
                    .HasConstraintName("ClientGroup_Address");

                entity.HasOne(d => d.ClientGroupEmployeeNavigation)
                    .WithMany(p => p.ClientGroups)
                    .HasForeignKey(d => d.ClientGroupEmployee)
                    .HasConstraintName("ClientGroup_Employee");

                entity.HasOne(d => d.ClientGroupTypeAccountNavigation)
                    .WithMany(p => p.ClientGroups)
                    .HasForeignKey(d => d.ClientGroupTypeAccount)
                    .HasConstraintName("ClientGroup_TypeAccount");

                entity.HasOne(d => d.ConfiguracionEdClientGroupNavigation)
                    .WithMany(p => p.ClientGroups)
                    .HasForeignKey(d => d.ConfiguracionEdClientGroup)
                    .HasConstraintName("ConfiguracionED_ClientGroup");

                entity.HasOne(d => d.ControlCompanyClientGroupNavigation)
                    .WithMany(p => p.ClientGroups)
                    .HasForeignKey(d => d.ControlCompanyClientGroup)
                    .HasConstraintName("ControlCompany_ClientGroup");

                entity.HasOne(d => d.CuotasEdClientGroupNavigation)
                    .WithMany(p => p.ClientGroups)
                    .HasForeignKey(d => d.CuotasEdClientGroup)
                    .HasConstraintName("CuotasED_ClientGroup");

                entity.HasOne(d => d.FormaDePagoClientGroupNavigation)
                    .WithMany(p => p.ClientGroups)
                    .HasForeignKey(d => d.FormaDePagoClientGroup)
                    .HasConstraintName("FormaDePago_ClientGroup");

                entity.HasOne(d => d.SaldosLimitConfigClientGroupNavigation)
                    .WithMany(p => p.ClientGroups)
                    .HasForeignKey(d => d.SaldosLimitConfigClientGroup)
                    .HasConstraintName("SaldosLimitConfig_ClientGroup");
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.Property(e => e.ClientAddress).HasColumnName("Client_Address");

                entity.Property(e => e.ClientGroupClient).HasColumnName("ClientGroup_Client");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IdSucursalTotvs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdTotvs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsSubGroup).HasColumnName("isSubGroup");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumberClientCg)
                    .HasColumnName("NumberClientCG")
                    .HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SendMailForReportVt).HasColumnName("SendMailForReportVT");

                entity.Property(e => e.TimeZoneCClient).HasColumnName("TimeZoneC_Client");

                entity.HasOne(d => d.ClientAddressNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ClientAddress)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Client_Address");

                entity.HasOne(d => d.ClientGroupClientNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ClientGroupClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ClientGroup_Client");

                entity.HasOne(d => d.TimeZoneCClientNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.TimeZoneCClient)
                    .HasConstraintName("TimeZoneC_Client");
            });

            modelBuilder.Entity<ClientsBovsCgset>(entity =>
            {
                entity.ToTable("ClientsBOvsCGSet");

                entity.Property(e => e.ClientCg)
                    .HasColumnName("ClientCG")
                    .HasMaxLength(255);

                entity.Property(e => e.ClientGroupBo)
                    .HasColumnName("ClientGroupBO")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.GroupBo)
                    .HasColumnName("GroupBO")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupCg)
                    .HasColumnName("GroupCG")
                    .HasMaxLength(255);

                entity.Property(e => e.IdClientGroupBo).HasColumnName("IdClientGroupBO");

                entity.Property(e => e.IdGroupBo).HasColumnName("IdGroupBO");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ClientsMonitor>(entity =>
            {
                entity.Property(e => e.BalanceCalculated).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientsMonitorClientgroups).HasColumnName("ClientsMonitor_Clientgroups");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            });

            modelBuilder.Entity<ClosingReasonTicketSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CodigoPostalSet>(entity =>
            {
                entity.Property(e => e.CCodigoPostal)
                    .IsRequired()
                    .HasColumnName("c_CodigoPostal")
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoPostalCity).HasColumnName("CodigoPostal_City");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CodigoPostalCityNavigation)
                    .WithMany(p => p.CodigoPostalSet)
                    .HasForeignKey(d => d.CodigoPostalCity)
                    .HasConstraintName("CodigoPostal_City");
            });

            modelBuilder.Entity<ComplementoConceptosEdcset>(entity =>
            {
                entity.ToTable("ComplementoConceptosEDCSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ComplementoEdcset>(entity =>
            {
                entity.ToTable("ComplementoEDCSet");

                entity.Property(e => e.ComplementoEdcEdoCtaCombustible).HasColumnName("ComplementoEDC_EdoCtaCombustible");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ComplementoEdcEdoCtaCombustibleNavigation)
                    .WithMany(p => p.ComplementoEdcset)
                    .HasForeignKey(d => d.ComplementoEdcEdoCtaCombustible)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ComplementoEDC_EdoCtaCombustible");
            });

            modelBuilder.Entity<ComplementoEdeset>(entity =>
            {
                entity.ToTable("ComplementoEDESet");

                entity.Property(e => e.ComplementoEdeConsumoDeCombustibles).HasColumnName("ComplementoEDE_ConsumoDeCombustibles");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ConceptoCmoDeCombustiblesSet>(entity =>
            {
                entity.Property(e => e.Cantidad).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.ClaveEstacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CuotaIeps)
                    .HasColumnName("CuotaIEPS")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.EdcomplementoConceptoCmoDeCombustibles).HasColumnName("EDComplemento_ConceptoCmoDeCombustibles");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FolioOperacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Identificador)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Importe).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ImporteIeps)
                    .HasColumnName("ImporteIEPS")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ImporteIva)
                    .HasColumnName("ImporteIVA")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ImpuestoIeps)
                    .IsRequired()
                    .HasColumnName("ImpuestoIEPS")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImpuestoIva)
                    .IsRequired()
                    .HasColumnName("ImpuestoIVA")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NombreCombustible)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TasaIva)
                    .HasColumnName("TasaIVA")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(20, 2)");

                entity.HasOne(d => d.EdcomplementoConceptoCmoDeCombustiblesNavigation)
                    .WithMany(p => p.ConceptoCmoDeCombustiblesSet)
                    .HasForeignKey(d => d.EdcomplementoConceptoCmoDeCombustibles)
                    .HasConstraintName("EDComplemento_ConceptoCmoDeCombustibles");
            });

            modelBuilder.Entity<ConceptoEdoCtaCombustibleSet>(entity =>
            {
                entity.Property(e => e.Cantidad).HasColumnType("decimal(21, 3)");

                entity.Property(e => e.ClaveEstacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CuotaIeps)
                    .HasColumnName("CuotaIEPS")
                    .HasColumnType("decimal(23, 6)");

                entity.Property(e => e.EdcomplementoConceptoEdoCtaCombustible).HasColumnName("EDComplemento_ConceptoEdoCtaCombustible");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FolioOperacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Identificador)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Importe).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ImporteIeps)
                    .HasColumnName("ImporteIEPS")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ImporteIva)
                    .HasColumnName("ImporteIVA")
                    .HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ImpuestoIeps)
                    .HasColumnName("ImpuestoIEPS")
                    .HasMaxLength(4);

                entity.Property(e => e.ImpuestoIva)
                    .IsRequired()
                    .HasColumnName("ImpuestoIVA")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NoIdentificacionVer33).HasMaxLength(8);

                entity.Property(e => e.NombreCombustible)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tarver33)
                    .HasColumnName("TARVer33")
                    .HasMaxLength(4);

                entity.Property(e => e.TasaIva)
                    .HasColumnName("TasaIVA")
                    .HasColumnType("decimal(23, 6)");

                entity.Property(e => e.UnidadVer33).HasMaxLength(25);

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(21, 3)");

                entity.HasOne(d => d.EdcomplementoConceptoEdoCtaCombustibleNavigation)
                    .WithMany(p => p.ConceptoEdoCtaCombustibleSet)
                    .HasForeignKey(d => d.EdcomplementoConceptoEdoCtaCombustible)
                    .HasConstraintName("EDComplemento_ConceptoEdoCtaCombustible");
            });

            modelBuilder.Entity<ConceptosEdcset>(entity =>
            {
                entity.ToTable("ConceptosEDCSet");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ConceptosEdcComplementoConceptosEdc).HasColumnName("ConceptosEDC_ComplementoConceptosEDC");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ConceptosEdcComplementoConceptosEdcNavigation)
                    .WithMany(p => p.ConceptosEdcset)
                    .HasForeignKey(d => d.ConceptosEdcComplementoConceptosEdc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ConceptosEDC_ComplementoConceptosEDC");
            });

            modelBuilder.Entity<ConceptosEdeset>(entity =>
            {
                entity.ToTable("ConceptosEDESet");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EdeConceptosEde).HasColumnName("EDE_ConceptosEDE");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ConceptosEdset>(entity =>
            {
                entity.ToTable("ConceptosEDSet");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.ClaveProdServVer33).HasMaxLength(10);

                entity.Property(e => e.ClaveUnidadVer33).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descuento).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.EdcomplementoConceptosEd).HasColumnName("EDComplemento_ConceptosED");

                entity.Property(e => e.Importe).HasColumnType("decimal(24, 4)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NoIdentificacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(24, 6)");

                entity.HasOne(d => d.EdcomplementoConceptosEdNavigation)
                    .WithMany(p => p.ConceptosEdset)
                    .HasForeignKey(d => d.EdcomplementoConceptosEd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EDComplemento_ConceptosED");
            });

            modelBuilder.Entity<ConceptsSet>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tax)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxTransferred).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransferAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UnitValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Valuation).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ConciliateDispatchSet>(entity =>
            {
                entity.Property(e => e.Cost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NumTransaction).HasMaxLength(30);

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Volume).HasColumnType("decimal(8, 3)");
            });

            modelBuilder.Entity<ConciliationVinset>(entity =>
            {
                entity.ToTable("ConciliationVINSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FechaConciliacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdBo).HasColumnName("IdBO");

                entity.Property(e => e.IdVin).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NumEstacion).HasMaxLength(255);

                entity.Property(e => e.NumTransaction).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ValorBo)
                    .HasColumnName("ValorBO")
                    .HasMaxLength(255);

                entity.Property(e => e.ValorVin)
                    .HasColumnName("ValorVIN")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ConfiguracionDescuentoEdset>(entity =>
            {
                entity.ToTable("ConfiguracionDescuentoEDSet");

                entity.Property(e => e.ConfDescuentoEdClientGroups).HasColumnName("ConfDescuentoED_ClientGroups");

                entity.Property(e => e.ConfDescuentoEdGasStations).HasColumnName("ConfDescuentoED_GasStations");

                entity.Property(e => e.ConfiguracionDescuentoEdClientGroup).HasColumnName("ConfiguracionDescuentoED_ClientGroup");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ConfiguracionDescuentoEdClientGroupNavigation)
                    .WithMany(p => p.ConfiguracionDescuentoEdset)
                    .HasForeignKey(d => d.ConfiguracionDescuentoEdClientGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ConfiguracionDescuentoED_ClientGroup");
            });

            modelBuilder.Entity<ConfiguracionEdset>(entity =>
            {
                entity.ToTable("ConfiguracionEDSet");

                entity.Property(e => e.ConfiguracionEdUsoDeCfdi).HasColumnName("ConfiguracionED_UsoDeCFDI");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DesgloseIeps).HasColumnName("DesgloseIEPS");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NumRegIdTrib).HasMaxLength(255);

                entity.Property(e => e.PorcentajeComision).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ConfiguracionEdUsoDeCfdiNavigation)
                    .WithMany(p => p.ConfiguracionEdset)
                    .HasForeignKey(d => d.ConfiguracionEdUsoDeCfdi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ConfiguracionED_UsoDeCFDI");
            });

            modelBuilder.Entity<ConnectionByStationsSet>(entity =>
            {
                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(600)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ConnectionByStationsActivityInStation).HasColumnName("ConnectionByStations_ActivityInStation");

                entity.Property(e => e.ConnectionByStationsEmployee).HasColumnName("ConnectionByStations_Employee");

                entity.Property(e => e.ConnectionByStationsGasStation1).HasColumnName("ConnectionByStations_GasStation1");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeEnd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateTimeStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ConnectionByStationsActivityInStationNavigation)
                    .WithMany(p => p.ConnectionByStationsSet)
                    .HasForeignKey(d => d.ConnectionByStationsActivityInStation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ConnectionByStations_ActivityInStation");

                entity.HasOne(d => d.ConnectionByStationsEmployeeNavigation)
                    .WithMany(p => p.ConnectionByStationsSet)
                    .HasForeignKey(d => d.ConnectionByStationsEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ConnectionByStations_Employee");

                entity.HasOne(d => d.ConnectionByStationsGasStation1Navigation)
                    .WithMany(p => p.ConnectionByStationsSet)
                    .HasForeignKey(d => d.ConnectionByStationsGasStation1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ConnectionByStations_GasStation");
            });

            modelBuilder.Entity<ConsumoDeCombustiblesSet>(entity =>
            {
                entity.Property(e => e.ConsumoDeCombustiblesEde).HasColumnName("ConsumoDeCombustibles_EDE");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NumeroDeCuenta)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SubTotal).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Total).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ConsumoDeCombustiblesEdeNavigation)
                    .WithMany(p => p.ConsumoDeCombustiblesSet)
                    .HasForeignKey(d => d.ConsumoDeCombustiblesEde)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ConsumoDeCombustibles_EDE");
            });

            modelBuilder.Entity<ContactPersons>(entity =>
            {
                entity.Property(e => e.Cellular1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cellular2).HasMaxLength(255);

                entity.Property(e => e.CellularEmergency).HasMaxLength(255);

                entity.Property(e => e.ClientContactPerson).HasColumnName("Client_ContactPerson");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ContactPersonAddress).HasColumnName("ContactPerson_Address");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Email1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email2).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GasStationContactPerson).HasColumnName("GasStation_ContactPerson");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SubGroupContactPerson).HasColumnName("SubGroup_ContactPerson");

                entity.Property(e => e.WorkingDays).HasMaxLength(255);

                entity.Property(e => e.WorkingHoursFrom).HasMaxLength(255);

                entity.Property(e => e.WorkingHoursTill).HasMaxLength(255);

                entity.HasOne(d => d.ClientContactPersonNavigation)
                    .WithMany(p => p.ContactPersons)
                    .HasForeignKey(d => d.ClientContactPerson)
                    .HasConstraintName("Client_ContactPerson");

                entity.HasOne(d => d.ContactPersonAddressNavigation)
                    .WithMany(p => p.ContactPersons)
                    .HasForeignKey(d => d.ContactPersonAddress)
                    .HasConstraintName("ContactPerson_Address");

                entity.HasOne(d => d.GasStationContactPersonNavigation)
                    .WithMany(p => p.ContactPersons)
                    .HasForeignKey(d => d.GasStationContactPerson)
                    .HasConstraintName("GasStation_ContactPerson");

                entity.HasOne(d => d.SubGroupContactPersonNavigation)
                    .WithMany(p => p.ContactPersons)
                    .HasForeignKey(d => d.SubGroupContactPerson)
                    .HasConstraintName("ClientGroup_ContactPerson");
            });

            modelBuilder.Entity<ContingencyByPosSet>(entity =>
            {
                entity.Property(e => e.AuthorizationNumber)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeEnd).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStart).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ContingencyFileSet>(entity =>
            {
                entity.Property(e => e.ContingencyFileContingency).HasColumnName("ContingencyFile_Contingency");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FileExtension).HasMaxLength(255);

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ContingencyFileContingencyNavigation)
                    .WithMany(p => p.ContingencyFileSet)
                    .HasForeignKey(d => d.ContingencyFileContingency)
                    .HasConstraintName("ContingencyFile_Contingency");
            });

            modelBuilder.Entity<ContingencySet>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("UQ__tmp_ms_x__A25C5AA739427EBA")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CommentsCancel).HasMaxLength(255);

                entity.Property(e => e.ContingencyClientGroup).HasColumnName("Contingency_ClientGroup");

                entity.Property(e => e.ContingencyDriver).HasColumnName("Contingency_Driver");

                entity.Property(e => e.ContingencyEmployee).HasColumnName("Contingency_Employee");

                entity.Property(e => e.ContingencyEmployee1).HasColumnName("Contingency_Employee1");

                entity.Property(e => e.ContingencyFuelType).HasColumnName("Contingency_FuelType");

                entity.Property(e => e.ContingencyGasStation).HasColumnName("Contingency_GasStation");

                entity.Property(e => e.ContingencyStatusContingency).HasColumnName("Contingency_StatusContingency");

                entity.Property(e => e.ContingencyTypeContigency).HasColumnName("Contingency_TypeContigency");

                entity.Property(e => e.ContingencyVehicle).HasColumnName("Contingency_Vehicle");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateFinishAtcnoc)
                    .HasColumnName("DateFinishATCNOC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFinishFinanzas).HasColumnType("datetime");

                entity.Property(e => e.DateTimeContingency)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatetimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageError)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameDispatcher)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NcontrolGas)
                    .HasColumnName("NControlGas")
                    .HasMaxLength(255);

                entity.Property(e => e.NumberPump)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumberTransaction)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Odometer).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PathInvoice).HasMaxLength(255);

                entity.Property(e => e.PriceUnit).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ContingencyClientGroupNavigation)
                    .WithMany(p => p.ContingencySet)
                    .HasForeignKey(d => d.ContingencyClientGroup)
                    .HasConstraintName("Contingency_ClientGroup");

                entity.HasOne(d => d.ContingencyDriverNavigation)
                    .WithMany(p => p.ContingencySet)
                    .HasForeignKey(d => d.ContingencyDriver)
                    .HasConstraintName("Contingency_Driver");

                entity.HasOne(d => d.ContingencyEmployeeNavigation)
                    .WithMany(p => p.ContingencySetContingencyEmployeeNavigation)
                    .HasForeignKey(d => d.ContingencyEmployee)
                    .HasConstraintName("Contingency_Employee");

                entity.HasOne(d => d.ContingencyEmployee1Navigation)
                    .WithMany(p => p.ContingencySetContingencyEmployee1Navigation)
                    .HasForeignKey(d => d.ContingencyEmployee1)
                    .HasConstraintName("Contingency_Employee1");

                entity.HasOne(d => d.ContingencyFuelTypeNavigation)
                    .WithMany(p => p.ContingencySet)
                    .HasForeignKey(d => d.ContingencyFuelType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Contingency_FuelType");

                entity.HasOne(d => d.ContingencyGasStationNavigation)
                    .WithMany(p => p.ContingencySet)
                    .HasForeignKey(d => d.ContingencyGasStation)
                    .HasConstraintName("Contingency_GasStation");

                entity.HasOne(d => d.ContingencyStatusContingencyNavigation)
                    .WithMany(p => p.ContingencySet)
                    .HasForeignKey(d => d.ContingencyStatusContingency)
                    .HasConstraintName("Contingency_StatusContingency");

                entity.HasOne(d => d.ContingencyTypeContigencyNavigation)
                    .WithMany(p => p.ContingencySet)
                    .HasForeignKey(d => d.ContingencyTypeContigency)
                    .HasConstraintName("Contingency_TypeContigency");

                entity.HasOne(d => d.ContingencyVehicleNavigation)
                    .WithMany(p => p.ContingencySet)
                    .HasForeignKey(d => d.ContingencyVehicle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Contingency_Vehicle");
            });

            modelBuilder.Entity<ContingencyWebSet>(entity =>
            {
                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContingencyWebGasStation1).HasColumnName("ContingencyWeb_GasStation1");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FechaEnvio)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdContingency).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PathFiles)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Satus).HasColumnName("satus");

                entity.Property(e => e.SendNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ContingencyWebGasStation1Navigation)
                    .WithMany(p => p.ContingencyWebSet)
                    .HasForeignKey(d => d.ContingencyWebGasStation1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ContingencyWeb_GasStation");
            });

            modelBuilder.Entity<ContingencyWithoutVehicleSet>(entity =>
            {
                entity.HasIndex(e => e.IdContingency)
                    .HasName("UQ__tmp_ms_x__FF753A94D2A9B200")
                    .IsUnique();

                entity.Property(e => e.ContingencyWebContingencyWithoutVehicle1).HasColumnName("ContingencyWeb_ContingencyWithoutVehicle1");

                entity.Property(e => e.ContingencyWithoutVehicleClient).HasColumnName("ContingencyWithoutVehicle_Client");

                entity.Property(e => e.ContingencyWithoutVehicleFuelType).HasColumnName("ContingencyWithoutVehicle_FuelType");

                entity.Property(e => e.ContingencyWithoutVehicleGasStation).HasColumnName("ContingencyWithoutVehicle_GasStation");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateOperation)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdContingency)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PathInvoice).HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TimeOperation)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ContingencyWebContingencyWithoutVehicle1Navigation)
                    .WithMany(p => p.ContingencyWithoutVehicleSet)
                    .HasForeignKey(d => d.ContingencyWebContingencyWithoutVehicle1)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ContingencyWeb_ContingencyWithoutVehicle");

                entity.HasOne(d => d.ContingencyWithoutVehicleClientNavigation)
                    .WithMany(p => p.ContingencyWithoutVehicleSet)
                    .HasForeignKey(d => d.ContingencyWithoutVehicleClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ContingencyWithoutVehicle_Client");

                entity.HasOne(d => d.ContingencyWithoutVehicleFuelTypeNavigation)
                    .WithMany(p => p.ContingencyWithoutVehicleSet)
                    .HasForeignKey(d => d.ContingencyWithoutVehicleFuelType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ContingencyWithoutVehicle_FuelType");

                entity.HasOne(d => d.ContingencyWithoutVehicleGasStationNavigation)
                    .WithMany(p => p.ContingencyWithoutVehicleSet)
                    .HasForeignKey(d => d.ContingencyWithoutVehicleGasStation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ContingencyWithoutVehicle_GasStation");
            });

            modelBuilder.Entity<ContractFacSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeEnd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateTimeStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ControlCompanies>(entity =>
            {
                entity.Property(e => e.ControlCompanyClientGroup1).HasColumnName("ControlCompany_ClientGroup1");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ControlCompanyClientGroup1Navigation)
                    .WithMany(p => p.ControlCompanies)
                    .HasForeignKey(d => d.ControlCompanyClientGroup1)
                    .HasConstraintName("ControlCompany_ClientGroup1");
            });

            modelBuilder.Entity<ControlPermissionsWebSet>(entity =>
            {
                entity.Property(e => e.ControlPermissionsWebControlsWeb).HasColumnName("ControlPermissionsWeb_ControlsWeb");

                entity.Property(e => e.ControlPermissionsWebPermissionsWeb1).HasColumnName("ControlPermissionsWeb_PermissionsWeb1");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ControlPermissionsWebControlsWebNavigation)
                    .WithMany(p => p.ControlPermissionsWebSet)
                    .HasForeignKey(d => d.ControlPermissionsWebControlsWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ControlPermissionsWeb_ControlsWeb");

                entity.HasOne(d => d.ControlPermissionsWebPermissionsWeb1Navigation)
                    .WithMany(p => p.ControlPermissionsWebSet)
                    .HasForeignKey(d => d.ControlPermissionsWebPermissionsWeb1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ControlPermissionsWeb_PermissionsWeb");
            });

            modelBuilder.Entity<ControlPrintTargetSet>(entity =>
            {
                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ControlPrintTargetEmployee).HasColumnName("ControlPrintTarget_Employee");

                entity.Property(e => e.ControlPrintTargetRePrintTargetReason).HasColumnName("ControlPrintTarget_RePrintTargetReason");

                entity.Property(e => e.ControlPrintTargetTag).HasColumnName("ControlPrintTarget_Tag");

                entity.Property(e => e.ControlPrintTargetVehicle).HasColumnName("ControlPrintTarget_Vehicle");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("SID")
                    .HasMaxLength(18)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ControlPrintTargetEmployeeNavigation)
                    .WithMany(p => p.ControlPrintTargetSet)
                    .HasForeignKey(d => d.ControlPrintTargetEmployee)
                    .HasConstraintName("ControlPrintTarget_Employee");

                entity.HasOne(d => d.ControlPrintTargetRePrintTargetReasonNavigation)
                    .WithMany(p => p.ControlPrintTargetSet)
                    .HasForeignKey(d => d.ControlPrintTargetRePrintTargetReason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ControlPrintTarget_RePrintTargetReason");

                entity.HasOne(d => d.ControlPrintTargetTagNavigation)
                    .WithMany(p => p.ControlPrintTargetSet)
                    .HasForeignKey(d => d.ControlPrintTargetTag)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ControlPrintTarget_Tag");

                entity.HasOne(d => d.ControlPrintTargetVehicleNavigation)
                    .WithMany(p => p.ControlPrintTargetSet)
                    .HasForeignKey(d => d.ControlPrintTargetVehicle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ControlPrintTarget_Vehicle");
            });

            modelBuilder.Entity<ControllerWebSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ImagePath).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ControlsWebSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CostCenterSet>(entity =>
            {
                entity.Property(e => e.CostCenterClientGroup).HasColumnName("CostCenter_ClientGroup");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CostCenterClientGroupNavigation)
                    .WithMany(p => p.CostCenterSet)
                    .HasForeignKey(d => d.CostCenterClientGroup)
                    .HasConstraintName("CostCenter_ClientGroup");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__tmp_ms_x__737584F639A7C791")
                    .IsUnique();

                entity.Property(e => e.CodCountry).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CvePais)
                    .HasColumnName("Cve_Pais")
                    .HasMaxLength(5);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CreditConfigSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreditConfigClientGroup).HasColumnName("CreditConfig_ClientGroup");

                entity.Property(e => e.CreditConfigGasStation).HasColumnName("CreditConfig_GasStation");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CreditConfigClientGroupNavigation)
                    .WithMany(p => p.CreditConfigSet)
                    .HasForeignKey(d => d.CreditConfigClientGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CreditConfig_ClientGroup");

                entity.HasOne(d => d.CreditConfigGasStationNavigation)
                    .WithMany(p => p.CreditConfigSet)
                    .HasForeignKey(d => d.CreditConfigGasStation)
                    .HasConstraintName("CreditConfig_GasStation");
            });

            modelBuilder.Entity<CuotasEdset>(entity =>
            {
                entity.ToTable("CuotasEDSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CustomFieldsToVehiclesSet>(entity =>
            {
                entity.Property(e => e.CatAvlcustomfieldsCustomFieldsToVehicles).HasColumnName("CatAVLCustomfields_CustomFieldsToVehicles");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CustomFieldValue)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustomFieldsToVehiclesVehicle).HasColumnName("CustomFieldsToVehicles_Vehicle");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CatAvlcustomfieldsCustomFieldsToVehiclesNavigation)
                    .WithMany(p => p.CustomFieldsToVehiclesSet)
                    .HasForeignKey(d => d.CatAvlcustomfieldsCustomFieldsToVehicles)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("CatAVLCustomfields_CustomFieldsToVehicles");

                entity.HasOne(d => d.CustomFieldsToVehiclesVehicleNavigation)
                    .WithMany(p => p.CustomFieldsToVehiclesSet)
                    .HasForeignKey(d => d.CustomFieldsToVehiclesVehicle)
                    .HasConstraintName("CustomFieldsToVehicles_Vehicle");
            });

            modelBuilder.Entity<CustomStickers>(entity =>
            {
                entity.Property(e => e.CatalogNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CustomStickerCatCustomStickersModel).HasColumnName("CustomSticker_CatCustomStickersModel");

                entity.Property(e => e.CustomStickerCatCustomStickersStatus).HasColumnName("CustomSticker_CatCustomStickersStatus");

                entity.Property(e => e.CustomStickerTag).HasColumnName("CustomSticker_Tag");

                entity.Property(e => e.CustomStickerUserWeb).HasColumnName("CustomSticker_UserWeb");

                entity.Property(e => e.Lot).HasMaxLength(60);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Po)
                    .HasColumnName("PO")
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("SID")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sidpers)
                    .IsRequired()
                    .HasColumnName("SIDPers")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CustomStickerCatCustomStickersModelNavigation)
                    .WithMany(p => p.CustomStickers)
                    .HasForeignKey(d => d.CustomStickerCatCustomStickersModel)
                    .HasConstraintName("CustomSticker_CatCustomStickersModel");

                entity.HasOne(d => d.CustomStickerCatCustomStickersStatusNavigation)
                    .WithMany(p => p.CustomStickers)
                    .HasForeignKey(d => d.CustomStickerCatCustomStickersStatus)
                    .HasConstraintName("CustomSticker_CatCustomStickersStatus");

                entity.HasOne(d => d.CustomStickerTagNavigation)
                    .WithMany(p => p.CustomStickers)
                    .HasForeignKey(d => d.CustomStickerTag)
                    .HasConstraintName("CustomSticker_Tag");
            });

            modelBuilder.Entity<CustomStickers59Produccion>(entity =>
            {
                entity.HasIndex(e => e.Sid)
                    .HasName("UQ__CustomSt__CA195971A57060E1")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IdTag).HasColumnName("idTag");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("SID")
                    .HasMaxLength(18);

                entity.Property(e => e.Sidpers)
                    .IsRequired()
                    .HasColumnName("SIDPers")
                    .HasMaxLength(255);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.CustomStickers59Produccion)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatStatusCustomStickers9Produccion");
            });

            modelBuilder.Entity<CustomStickersProd2300>(entity =>
            {
                entity.HasIndex(e => e.Sid)
                    .HasName("UQ__CustomSt__CA195971E715DF2E")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IdTag).HasColumnName("idTag");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("SID")
                    .HasMaxLength(18);

                entity.Property(e => e.Sidpers)
                    .IsRequired()
                    .HasColumnName("SIDPers")
                    .HasMaxLength(255);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.CustomStickersProd2300)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CatStatusCustomStickersProd2300");
            });

            modelBuilder.Entity<CustomStickersTrakings>(entity =>
            {
                entity.Property(e => e.CatalogNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CustomStickersTrakingCatCustomStickersModel).HasColumnName("CustomStickersTraking_CatCustomStickersModel");

                entity.Property(e => e.CustomStickersTrakingCatCustomStickersStatus).HasColumnName("CustomStickersTraking_CatCustomStickersStatus");

                entity.Property(e => e.CustomStickersTrakingCustomSticker).HasColumnName("CustomStickersTraking_CustomSticker");

                entity.Property(e => e.CustomStickersTrakingTag).HasColumnName("CustomStickersTraking_Tag");

                entity.Property(e => e.CustomStickersTrakingUserWeb).HasColumnName("CustomStickersTraking_UserWeb");

                entity.Property(e => e.Lot).HasMaxLength(60);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasColumnName("operation")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Po)
                    .HasColumnName("PO")
                    .HasMaxLength(180)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("SID")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sidpers)
                    .IsRequired()
                    .HasColumnName("SIDPers")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(255);

                entity.HasOne(d => d.CustomStickersTrakingCatCustomStickersModelNavigation)
                    .WithMany(p => p.CustomStickersTrakings)
                    .HasForeignKey(d => d.CustomStickersTrakingCatCustomStickersModel)
                    .HasConstraintName("CustomStickersTraking_CatCustomStickersModel");

                entity.HasOne(d => d.CustomStickersTrakingCatCustomStickersStatusNavigation)
                    .WithMany(p => p.CustomStickersTrakings)
                    .HasForeignKey(d => d.CustomStickersTrakingCatCustomStickersStatus)
                    .HasConstraintName("CustomStickersTraking_CatCustomStickersStatus");

                entity.HasOne(d => d.CustomStickersTrakingCustomStickerNavigation)
                    .WithMany(p => p.CustomStickersTrakings)
                    .HasForeignKey(d => d.CustomStickersTrakingCustomSticker)
                    .HasConstraintName("CustomStickersTraking_CustomSticker");

                entity.HasOne(d => d.CustomStickersTrakingTagNavigation)
                    .WithMany(p => p.CustomStickersTrakings)
                    .HasForeignKey(d => d.CustomStickersTrakingTag)
                    .HasConstraintName("CustomStickersTraking_Tag");

                entity.HasOne(d => d.CustomStickersTrakingUserWebNavigation)
                    .WithMany(p => p.CustomStickersTrakings)
                    .HasForeignKey(d => d.CustomStickersTrakingUserWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CustomStickersTraking_UserWeb");
            });

            modelBuilder.Entity<DailyDataSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DataSource).HasMaxLength(255);

                entity.Property(e => e.DateChange).HasColumnType("datetime");

                entity.Property(e => e.EventSql).HasMaxLength(255);

                entity.Property(e => e.IdRecord).HasColumnName("id_record");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Table).HasMaxLength(255);

                entity.Property(e => e.UserEvent)
                    .HasColumnName("User_Event")
                    .HasMaxLength(255);

                entity.Property(e => e.Variable).HasMaxLength(255);
            });

            modelBuilder.Entity<DataBillingSet>(entity =>
            {
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Colony)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.InsideNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(180)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutsideNumer)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DateTimeEndCorrect>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateTimeEnd).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DatosFiscalesSet>(entity =>
            {
                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Colonia).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CuentaBancaria)
                    .IsRequired()
                    .HasMaxLength(18)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasMaxLength(255);

                entity.Property(e => e.DataBillingCity1).HasColumnName("DataBilling_City1");

                entity.Property(e => e.DataBillingClientGroup1).HasColumnName("DataBilling_ClientGroup1");

                entity.Property(e => e.DataBillingCountry).HasColumnName("DataBilling_Country");

                entity.Property(e => e.DataBillingGasStation1).HasColumnName("DataBilling_GasStation1");

                entity.Property(e => e.DatosFiscalesCodigoPostal).HasColumnName("DatosFiscales_CodigoPostal");

                entity.Property(e => e.DatosFiscalesLocalidad).HasColumnName("DatosFiscales_Localidad");

                entity.Property(e => e.DatosFiscalesMunicipio).HasColumnName("DatosFiscales_Municipio");

                entity.Property(e => e.Localidad).HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Municipio).HasMaxLength(100);

                entity.Property(e => e.NamePerson)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoExterior)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoInterior)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(180)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObservationsBilling).HasMaxLength(150);

                entity.Property(e => e.Pf).HasColumnName("PF");

                entity.Property(e => e.Pm).HasColumnName("PM");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rfcperson)
                    .HasColumnName("RFCPerson")
                    .HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DataBillingCity1Navigation)
                    .WithMany(p => p.DatosFiscalesSet)
                    .HasForeignKey(d => d.DataBillingCity1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DatosFiscales_City");

                entity.HasOne(d => d.DataBillingClientGroup1Navigation)
                    .WithMany(p => p.DatosFiscalesSet)
                    .HasForeignKey(d => d.DataBillingClientGroup1)
                    .HasConstraintName("DatosFiscales_ClientGroup");

                entity.HasOne(d => d.DataBillingCountryNavigation)
                    .WithMany(p => p.DatosFiscalesSet)
                    .HasForeignKey(d => d.DataBillingCountry)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DatosFiscales_Country");

                entity.HasOne(d => d.DataBillingGasStation1Navigation)
                    .WithMany(p => p.DatosFiscalesSet)
                    .HasForeignKey(d => d.DataBillingGasStation1)
                    .HasConstraintName("DatosFiscales_GasStation");

                entity.HasOne(d => d.DatosFiscalesCodigoPostalNavigation)
                    .WithMany(p => p.DatosFiscalesSet)
                    .HasForeignKey(d => d.DatosFiscalesCodigoPostal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DatosFiscales_CodigoPostal");

                entity.HasOne(d => d.DatosFiscalesLocalidadNavigation)
                    .WithMany(p => p.DatosFiscalesSet)
                    .HasForeignKey(d => d.DatosFiscalesLocalidad)
                    .HasConstraintName("DatosFiscales_Localidad");

                entity.HasOne(d => d.DatosFiscalesMunicipioNavigation)
                    .WithMany(p => p.DatosFiscalesSet)
                    .HasForeignKey(d => d.DatosFiscalesMunicipio)
                    .HasConstraintName("DatosFiscales_Municipio");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasIndex(e => e.DepartmentName)
                    .HasName("UQ__Departme__D949CC34C70CA391")
                    .IsUnique();

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DepositosSet>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankReference)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankingDepositAccountGng).HasColumnName("BankingDeposit_AccountGng");

                entity.Property(e => e.BankingDepositClientGroup).HasColumnName("BankingDeposit_ClientGroup");

                entity.Property(e => e.BillingDepositos).HasColumnName("BIlling_Depositos");

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeDeposit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepositosEdc).HasColumnName("Depositos_EDC");

                entity.Property(e => e.DepositosEmployee).HasColumnName("Depositos_Employee");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.MontoDisponible).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TransferNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.BankingDepositAccountGngNavigation)
                    .WithMany(p => p.DepositosSet)
                    .HasForeignKey(d => d.BankingDepositAccountGng)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Depositos_AccountGng");

                entity.HasOne(d => d.BankingDepositClientGroupNavigation)
                    .WithMany(p => p.DepositosSet)
                    .HasForeignKey(d => d.BankingDepositClientGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Depositos_ClientGroup");

                entity.HasOne(d => d.BillingDepositosNavigation)
                    .WithMany(p => p.DepositosSet)
                    .HasForeignKey(d => d.BillingDepositos)
                    .HasConstraintName("BIlling_Depositos");

                entity.HasOne(d => d.DepositosEdcNavigation)
                    .WithMany(p => p.DepositosSet)
                    .HasForeignKey(d => d.DepositosEdc)
                    .HasConstraintName("Depositos_EDC");

                entity.HasOne(d => d.DepositosEmployeeNavigation)
                    .WithMany(p => p.DepositosSet)
                    .HasForeignKey(d => d.DepositosEmployee)
                    .HasConstraintName("Depositos_Employee");
            });

            modelBuilder.Entity<DesignTemplateWeb>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ButtonHeaderColor)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DesignTemplateWebControlCompanies).HasColumnName("DesignTemplateWeb_ControlCompanies");

                entity.Property(e => e.FontColorByReports)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PathIconFacebook)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PathIconLinkedin)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PathImagenIndex)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PathImagenLoading)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PathImagenReports)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PathImagenTruck)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PathImagenUserFace)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PathLogoHeader)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PathLogoLogin)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryColor)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.SecondaryColor)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.DesignTemplateWebControlCompaniesNavigation)
                    .WithMany(p => p.DesignTemplateWeb)
                    .HasForeignKey(d => d.DesignTemplateWebControlCompanies)
                    .HasConstraintName("FK_DesignTemplateWeb_DesignTemplateWeb");
            });

            modelBuilder.Entity<DesignTemplateWebs>(entity =>
            {
                entity.Property(e => e.ButtonHeaderColor)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DesignTemplateWebControlCompany1).HasColumnName("DesignTemplateWeb_ControlCompany1");

                entity.Property(e => e.FontColorByReports)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NavBarColor)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PathIconFacebook)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PathIconLinkedin)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PathImagenIndex)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PathImagenLoading)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PathImagenReports)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PathImagenTruck)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PathImagenUserFace)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PathLogoHeader)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PathLogoLogin)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PrimaryColor)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SecondaryColor)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.DesignTemplateWebControlCompany1Navigation)
                    .WithMany(p => p.DesignTemplateWebs)
                    .HasForeignKey(d => d.DesignTemplateWebControlCompany1)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("DesignTemplateWeb_ControlCompany1");
            });

            modelBuilder.Entity<DespachosProxySet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeEnd).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateTimeStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Numref)
                    .IsRequired()
                    .HasColumnName("numref")
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlateNumber).HasMaxLength(10);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TagId)
                    .IsRequired()
                    .HasColumnName("TagID")
                    .HasMaxLength(18)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransactionNumber).HasMaxLength(15);
            });

            modelBuilder.Entity<DetailAppointmentSet>(entity =>
            {
                entity.Property(e => e.AppointmentServiceDetailAppointment).HasColumnName("AppointmentService_DetailAppointment");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateAppointment)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateAproxFinish)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateRealFinish).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AppointmentServiceDetailAppointmentNavigation)
                    .WithMany(p => p.DetailAppointmentSet)
                    .HasForeignKey(d => d.AppointmentServiceDetailAppointment)
                    .HasConstraintName("AppointmentService_DetailAppointment");
            });

            modelBuilder.Entity<DetailConceptSet>(entity =>
            {
                entity.Property(e => e.Accountnumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeOperation)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FolioOperation)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FuelName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FuelTotalAccountStatement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PublicId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Tax)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TransferAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TypeOperation)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UnitValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Valuation).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DetalleEdcset>(entity =>
            {
                entity.ToTable("DetalleEDCSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DetalleEdcClient).HasColumnName("DetalleEDC_Client");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RelacionEdcclienteDetalleEdc).HasColumnName("RelacionEDCCliente_DetalleEDC");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DetalleEdcClientNavigation)
                    .WithMany(p => p.DetalleEdcset)
                    .HasForeignKey(d => d.DetalleEdcClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DetalleEDC_Client");

                entity.HasOne(d => d.RelacionEdcclienteDetalleEdcNavigation)
                    .WithMany(p => p.DetalleEdcset)
                    .HasForeignKey(d => d.RelacionEdcclienteDetalleEdc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RelacionEDCCliente_DetalleEDC");
            });

            modelBuilder.Entity<DeteilAppointmentSet>(entity =>
            {
                entity.Property(e => e.AppointmentServiceDeteilAppointment1).HasColumnName("AppointmentService_DeteilAppointment1");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateAppointment)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateAproxFinish)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateRealFinish).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AppointmentServiceDeteilAppointment1Navigation)
                    .WithMany(p => p.DeteilAppointmentSet)
                    .HasForeignKey(d => d.AppointmentServiceDeteilAppointment1)
                    .HasConstraintName("AppointmentService_DeteilAppointment");
            });

            modelBuilder.Entity<DeterminadosEdeset>(entity =>
            {
                entity.ToTable("DeterminadosEDESet");

                entity.Property(e => e.ConceptoCmoDeCombustiblesDeterminadosEde).HasColumnName("ConceptoCmoDeCombustibles_DeterminadosEDE");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Impuesto)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tasa).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<DiagnosticBatterySet>(entity =>
            {
                entity.Property(e => e.BatteryDiagnosticBattery).HasColumnName("Battery_DiagnosticBattery");

                entity.Property(e => e.Comentarios).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DiagnosticBatteryLaboratoryDiagnosticBattery).HasColumnName("DiagnosticBattery_LaboratoryDiagnosticBattery");

                entity.Property(e => e.FinalDiagnostic).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.BatteryDiagnosticBatteryNavigation)
                    .WithMany(p => p.DiagnosticBatterySet)
                    .HasForeignKey(d => d.BatteryDiagnosticBattery)
                    .HasConstraintName("Battery_DiagnosticBattery");

                entity.HasOne(d => d.DiagnosticBatteryLaboratoryDiagnosticBatteryNavigation)
                    .WithMany(p => p.DiagnosticBatterySet)
                    .HasForeignKey(d => d.DiagnosticBatteryLaboratoryDiagnosticBattery)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DiagnosticBattery_LaboratoryDiagnosticBattery");
            });

            modelBuilder.Entity<DiagnosticReaderSet>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DiagnosticReaderLaboratoryDiagnosticReader).HasColumnName("DiagnosticReader_LaboratoryDiagnosticReader");

                entity.Property(e => e.FinalDiagnostic).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ReaderDiagnosticReader).HasColumnName("Reader_DiagnosticReader");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DiagnosticReaderLaboratoryDiagnosticReaderNavigation)
                    .WithMany(p => p.DiagnosticReaderSet)
                    .HasForeignKey(d => d.DiagnosticReaderLaboratoryDiagnosticReader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DiagnosticReader_LaboratoryDiagnosticReader");

                entity.HasOne(d => d.ReaderDiagnosticReaderNavigation)
                    .WithMany(p => p.DiagnosticReaderSet)
                    .HasForeignKey(d => d.ReaderDiagnosticReader)
                    .HasConstraintName("Reader_DiagnosticReader");
            });

            modelBuilder.Entity<DiagnosticTicketSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DispatchCg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DispatchCG");

                entity.Property(e => e.ClaveEstacion)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Eco)
                    .IsRequired()
                    .HasMaxLength(19);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Grupo)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ieps)
                    .HasColumnName("IEPS")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.Litros).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Monto).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NombreCombustible)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NombreEstacion)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Odometro).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.PrecioPub).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PublicId).HasColumnName("PublicID");

                entity.Property(e => e.Rfcestacion)
                    .IsRequired()
                    .HasColumnName("RFCEstacion")
                    .HasMaxLength(14)
                    .IsFixedLength();

                entity.Property(e => e.Tar).HasColumnName("TAR");
            });

            modelBuilder.Entity<DispatchExSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DispatchExDispatch).HasColumnName("DispatchEx_Dispatch");

                entity.Property(e => e.ESid)
                    .HasColumnName("eSID")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Sid)
                    .HasColumnName("SID")
                    .HasMaxLength(20);

                entity.HasOne(d => d.DispatchExDispatchNavigation)
                    .WithMany(p => p.DispatchExSet)
                    .HasForeignKey(d => d.DispatchExDispatch)
                    .HasConstraintName("DispatchEx_Dispatch");
            });

            modelBuilder.Entity<DispatchExternSet>(entity =>
            {
                entity.Property(e => e.AplicationName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FolioTransaction)
                    .IsRequired()
                    .HasMaxLength(38)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdStationNumber).HasMaxLength(255);

                entity.Property(e => e.LastRecord)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NearestOdometer).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NearestOdometerDateUtc)
                    .HasColumnName("NearestOdometerDateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.OdometerFoundInSection).HasMaxLength(255);

                entity.Property(e => e.OdometerResult).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.OdometerResultDateUtc)
                    .HasColumnName("OdometerResultDateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.OverSection).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SearchedInDateUtc)
                    .HasColumnName("SearchedInDateUTC")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DispatchExternSet2222>(entity =>
            {
                entity.Property(e => e.AplicationName).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FolioTransaction)
                    .IsRequired()
                    .HasMaxLength(38)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdStationNumber).HasMaxLength(255);

                entity.Property(e => e.LastRecord)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NearestOdometer).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.NearestOdometerDateUtc)
                    .HasColumnName("NearestOdometerDateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.OdometerFoundInSection).HasMaxLength(255);

                entity.Property(e => e.OdometerResult).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.OdometerResultDateUtc)
                    .HasColumnName("OdometerResultDateUTC")
                    .HasColumnType("datetime");

                entity.Property(e => e.OverSection).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SearchedInDateUtc)
                    .HasColumnName("SearchedInDateUTC")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DispatchHistorySet>(entity =>
            {
                entity.Property(e => e.Can).HasColumnName("can");

                entity.Property(e => e.Cli)
                    .HasColumnName("cli")
                    .HasMaxLength(99);

                entity.Property(e => e.ClientGroupBo).HasColumnName("ClientGroupBO");

                entity.Property(e => e.CodCli).HasColumnName("codCli");

                entity.Property(e => e.CodGas).HasColumnName("codGas");

                entity.Property(e => e.CodProd).HasColumnName("codProd");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Den)
                    .HasColumnName("den")
                    .HasMaxLength(20);

                entity.Property(e => e.Est).HasColumnName("est");

                entity.Property(e => e.Fch)
                    .HasColumnName("fch")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gas)
                    .HasColumnName("gas")
                    .HasMaxLength(255);

                entity.Property(e => e.Grp)
                    .HasColumnName("grp")
                    .HasMaxLength(60);

                entity.Property(e => e.IdClientGroupBo).HasColumnName("IdClientGroupBO");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Mto).HasColumnName("mto");

                entity.Property(e => e.Nro).HasColumnName("nro");

                entity.Property(e => e.Nrobom).HasColumnName("nrobom");

                entity.Property(e => e.Nroeco)
                    .HasColumnName("nroeco")
                    .HasMaxLength(255);

                entity.Property(e => e.Odm).HasColumnName("odm");

                entity.Property(e => e.Plc)
                    .HasColumnName("plc")
                    .HasMaxLength(10);

                entity.Property(e => e.Prd)
                    .HasColumnName("prd")
                    .HasMaxLength(255);

                entity.Property(e => e.Pre).HasColumnName("pre");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Rsp)
                    .HasColumnName("rsp")
                    .HasMaxLength(30);

                entity.Property(e => e.Rut)
                    .HasColumnName("rut")
                    .HasMaxLength(30);

                entity.Property(e => e.Sbg)
                    .HasColumnName("sbg")
                    .HasMaxLength(50);

                entity.Property(e => e.Tar).HasColumnName("tar");

                entity.Property(e => e.Veh).HasColumnName("veh");
            });

            modelBuilder.Entity<DispatchOdometerHigherMessageSet>(entity =>
            {
                entity.Property(e => e.ClientCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodgasCg).HasColumnName("CodgasCG");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeSearched)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DespDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NrovehCg).HasColumnName("NrovehCG");

                entity.Property(e => e.NumberClientCg)
                    .IsRequired()
                    .HasColumnName("NumberClientCG")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<DispatchSet>(entity =>
            {
                entity.Property(e => e.AllocateCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.AllocateVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.BaseBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillingDispatch).HasColumnName("BIlling_Dispatch");

                entity.Property(e => e.CgCommand).HasMaxLength(15);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ContingencyDispatch).HasColumnName("Contingency_Dispatch");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DatetimeCanceled).HasColumnType("datetime");

                entity.Property(e => e.DatetimeEnd).HasColumnType("datetime");

                entity.Property(e => e.DatetimeFeed)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatetimeInvoicing).HasColumnType("datetime");

                entity.Property(e => e.DatetimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatetimeStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeltaValue).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.DispatchBilling).HasColumnName("Dispatch_BIlling");

                entity.Property(e => e.DispatchFuelType2).HasColumnName("Dispatch_FuelType2");

                entity.Property(e => e.DispatchGasStation).HasColumnName("Dispatch_GasStation");

                entity.Property(e => e.DispatchVehicle).HasColumnName("Dispatch_Vehicle");

                entity.Property(e => e.DriverName).HasMaxLength(50);

                entity.Property(e => e.EngineHours).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Ieps)
                    .HasColumnName("IEPS")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameCenterCost).HasMaxLength(255);

                entity.Property(e => e.NumTransactionExternal).HasMaxLength(255);

                entity.Property(e => e.Odometer).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.OdometerModified).HasColumnType("datetime");

                entity.Property(e => e.OldNameCedi)
                    .HasColumnName("OldNameCEDI")
                    .HasMaxLength(255);

                entity.Property(e => e.PriceUnit).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.ProductCodeDispatch).HasColumnName("ProductCode_Dispatch");

                entity.Property(e => e.RealCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RealVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.RecordOk).HasColumnName("RecordOK");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tar).HasColumnName("TAR");

                entity.Property(e => e.TransactionInternalId)
                    .HasColumnName("TransactionInternalID")
                    .HasMaxLength(50);

                entity.HasOne(d => d.BillingDispatchNavigation)
                    .WithMany(p => p.DispatchSetBillingDispatchNavigation)
                    .HasForeignKey(d => d.BillingDispatch)
                    .HasConstraintName("BIlling_Dispatch");

                entity.HasOne(d => d.ContingencyDispatchNavigation)
                    .WithMany(p => p.DispatchSet)
                    .HasForeignKey(d => d.ContingencyDispatch)
                    .HasConstraintName("Contingency_Dispatch");

                entity.HasOne(d => d.DispatchBillingNavigation)
                    .WithMany(p => p.DispatchSetDispatchBillingNavigation)
                    .HasForeignKey(d => d.DispatchBilling)
                    .HasConstraintName("Dispatch_BIlling");

                entity.HasOne(d => d.DispatchFuelType2Navigation)
                    .WithMany(p => p.DispatchSet)
                    .HasForeignKey(d => d.DispatchFuelType2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Dispatch_FuelType");

                entity.HasOne(d => d.DispatchGasStationNavigation)
                    .WithMany(p => p.DispatchSet)
                    .HasForeignKey(d => d.DispatchGasStation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Dispatch_GasStation");

                entity.HasOne(d => d.DispatchVehicleNavigation)
                    .WithMany(p => p.DispatchSet)
                    .HasForeignKey(d => d.DispatchVehicle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Dispatch_Vehicle");

                entity.HasOne(d => d.ProductCodeDispatchNavigation)
                    .WithMany(p => p.DispatchSet)
                    .HasForeignKey(d => d.ProductCodeDispatch)
                    .HasConstraintName("ProductCode_Dispatch");
            });

            modelBuilder.Entity<DispatchedWithoutMessageSet>(entity =>
            {
                entity.Property(e => e.AccumulatorType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClientCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodgasCg).HasColumnName("CodgasCG");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeSearched)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DespDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NrovehCg).HasColumnName("NrovehCG");

                entity.Property(e => e.NumberClientCg)
                    .IsRequired()
                    .HasColumnName("NumberClientCG")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Drivers>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__Drivers__737584F6A4AAE7BE")
                    .IsUnique();

                entity.Property(e => e.Cellular).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DriversVehiclesSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DriversVehiclesDriver).HasColumnName("DriversVehicles_Driver");

                entity.Property(e => e.DriversVehiclesVehicle).HasColumnName("DriversVehicles_Vehicle");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DriversVehiclesDriverNavigation)
                    .WithMany(p => p.DriversVehiclesSet)
                    .HasForeignKey(d => d.DriversVehiclesDriver)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DriversVehicles_Driver");

                entity.HasOne(d => d.DriversVehiclesVehicleNavigation)
                    .WithMany(p => p.DriversVehiclesSet)
                    .HasForeignKey(d => d.DriversVehiclesVehicle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DriversVehicles_Vehicle");
            });

            modelBuilder.Entity<EdcomplementoSet>(entity =>
            {
                entity.ToTable("EDComplementoSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Edcset>(entity =>
            {
                entity.ToTable("EDCSet");

                entity.Property(e => e.ConnectedToCfdi).HasColumnName("ConnectedToCFDI");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EdcEmisor).HasColumnName("EDC_Emisor");

                entity.Property(e => e.EdcEncabezadoEstadoCuenta).HasColumnName("EDC_EncabezadoEstadoCuenta");

                entity.Property(e => e.EdcImpuestoTrasladadoEdc).HasColumnName("EDC_ImpuestoTrasladadoEDC");

                entity.Property(e => e.EdcReceptor).HasColumnName("EDC_Receptor");

                entity.Property(e => e.EdcTimbreFiscal).HasColumnName("EDC_TimbreFiscal");

                entity.Property(e => e.Edccomplete).HasColumnName("EDCComplete");

                entity.Property(e => e.EdcomplementoEdc).HasColumnName("EDComplemento_EDC");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EdcEmisorNavigation)
                    .WithMany(p => p.Edcset)
                    .HasForeignKey(d => d.EdcEmisor)
                    .HasConstraintName("EDC_Emisor");

                entity.HasOne(d => d.EdcEncabezadoEstadoCuentaNavigation)
                    .WithMany(p => p.Edcset)
                    .HasForeignKey(d => d.EdcEncabezadoEstadoCuenta)
                    .HasConstraintName("EDC_EncabezadoEstadoCuenta");

                entity.HasOne(d => d.EdcImpuestoTrasladadoEdcNavigation)
                    .WithMany(p => p.Edcset)
                    .HasForeignKey(d => d.EdcImpuestoTrasladadoEdc)
                    .HasConstraintName("EDC_ImpuestoTrasladadoEDC");

                entity.HasOne(d => d.EdcReceptorNavigation)
                    .WithMany(p => p.Edcset)
                    .HasForeignKey(d => d.EdcReceptor)
                    .HasConstraintName("EDC_Receptor");

                entity.HasOne(d => d.EdcTimbreFiscalNavigation)
                    .WithMany(p => p.Edcset)
                    .HasForeignKey(d => d.EdcTimbreFiscal)
                    .HasConstraintName("EDC_TimbreFiscal");

                entity.HasOne(d => d.EdcomplementoEdcNavigation)
                    .WithMany(p => p.Edcset)
                    .HasForeignKey(d => d.EdcomplementoEdc)
                    .HasConstraintName("EDComplemento_EDC");
            });

            modelBuilder.Entity<Edeset>(entity =>
            {
                entity.ToTable("EDESet");

                entity.Property(e => e.ConnectedToCfdi).HasColumnName("ConnectedToCFDI");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EdcomplementoEde).HasColumnName("EDComplemento_EDE");

                entity.Property(e => e.EdeEmisor).HasColumnName("EDE_Emisor");

                entity.Property(e => e.EdeEncabezadoEstadoCuenta).HasColumnName("EDE_EncabezadoEstadoCuenta");

                entity.Property(e => e.EdeImpuetosTrasladadosEde).HasColumnName("EDE_ImpuetosTrasladadosEDE");

                entity.Property(e => e.EdeReceptor).HasColumnName("EDE_Receptor");

                entity.Property(e => e.EdeTimbreFiscal).HasColumnName("EDE_TimbreFiscal");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EdcomplementoEdeNavigation)
                    .WithMany(p => p.Edeset)
                    .HasForeignKey(d => d.EdcomplementoEde)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("EDComplemento_EDE");

                entity.HasOne(d => d.EdeEmisorNavigation)
                    .WithMany(p => p.Edeset)
                    .HasForeignKey(d => d.EdeEmisor)
                    .HasConstraintName("EDE_Emisor");

                entity.HasOne(d => d.EdeEncabezadoEstadoCuentaNavigation)
                    .WithMany(p => p.Edeset)
                    .HasForeignKey(d => d.EdeEncabezadoEstadoCuenta)
                    .HasConstraintName("EDE_EncabezadoEstadoCuenta");

                entity.HasOne(d => d.EdeImpuetosTrasladadosEdeNavigation)
                    .WithMany(p => p.Edeset)
                    .HasForeignKey(d => d.EdeImpuetosTrasladadosEde)
                    .HasConstraintName("EDE_ImpuetosTrasladadosEDE");

                entity.HasOne(d => d.EdeReceptorNavigation)
                    .WithMany(p => p.Edeset)
                    .HasForeignKey(d => d.EdeReceptor)
                    .HasConstraintName("EDE_Receptor");

                entity.HasOne(d => d.EdeTimbreFiscalNavigation)
                    .WithMany(p => p.Edeset)
                    .HasForeignKey(d => d.EdeTimbreFiscal)
                    .HasConstraintName("EDE_TimbreFiscal");
            });

            modelBuilder.Entity<EdoCtaCombustibleSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NumeroDeCuenta)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<EmisorDetalleSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DomicilioFiscalCalle).HasMaxLength(254);

                entity.Property(e => e.DomicilioFiscalCodigoPostal).HasMaxLength(5);

                entity.Property(e => e.DomicilioFiscalColonia).HasMaxLength(254);

                entity.Property(e => e.DomicilioFiscalEstado).HasMaxLength(254);

                entity.Property(e => e.DomicilioFiscalMunicipio).HasMaxLength(254);

                entity.Property(e => e.DomicilioFiscalNoExterior).HasMaxLength(10);

                entity.Property(e => e.DomicilioFiscalNoInterior).HasMaxLength(10);

                entity.Property(e => e.DomicilioFiscalPais).HasMaxLength(5);

                entity.Property(e => e.ExpedidoCalle).HasMaxLength(254);

                entity.Property(e => e.ExpedidoCodigoPostal).HasMaxLength(5);

                entity.Property(e => e.ExpedidoColonia).HasMaxLength(254);

                entity.Property(e => e.ExpedidoEstado).HasMaxLength(254);

                entity.Property(e => e.ExpedidoMunicipio).HasMaxLength(254);

                entity.Property(e => e.ExpedidoNoExterior).HasMaxLength(10);

                entity.Property(e => e.ExpedidoNoInterior).HasMaxLength(10);

                entity.Property(e => e.ExpedidoPais).HasMaxLength(5);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegimenFiscal).HasMaxLength(120);

                entity.Property(e => e.RegimenFiscalVer33).HasMaxLength(5);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<EmisorSet>(entity =>
            {
                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryEmisor).HasColumnName("Country_Emisor");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EmisorCity).HasColumnName("Emisor_City");

                entity.Property(e => e.EmisorCodigoPostal).HasColumnName("Emisor_CodigoPostal");

                entity.Property(e => e.EmisorExpedidoEn).HasColumnName("Emisor_ExpedidoEn");

                entity.Property(e => e.EmisorMunicipio).HasColumnName("Emisor_Municipio");

                entity.Property(e => e.EmisorRegimenFiscal1).HasColumnName("Emisor_RegimenFiscal1");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoExterior)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoInterior)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CountryEmisorNavigation)
                    .WithMany(p => p.EmisorSet)
                    .HasForeignKey(d => d.CountryEmisor)
                    .HasConstraintName("Country_Emisor");

                entity.HasOne(d => d.EmisorCityNavigation)
                    .WithMany(p => p.EmisorSet)
                    .HasForeignKey(d => d.EmisorCity)
                    .HasConstraintName("Emisor_City");

                entity.HasOne(d => d.EmisorCodigoPostalNavigation)
                    .WithMany(p => p.EmisorSet)
                    .HasForeignKey(d => d.EmisorCodigoPostal)
                    .HasConstraintName("Emisor_CodigoPostal");

                entity.HasOne(d => d.EmisorExpedidoEnNavigation)
                    .WithMany(p => p.EmisorSet)
                    .HasForeignKey(d => d.EmisorExpedidoEn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Emisor_ExpedidoEn");

                entity.HasOne(d => d.EmisorMunicipioNavigation)
                    .WithMany(p => p.EmisorSet)
                    .HasForeignKey(d => d.EmisorMunicipio)
                    .HasConstraintName("Emisor_Municipio");

                entity.HasOne(d => d.EmisorRegimenFiscal1Navigation)
                    .WithMany(p => p.EmisorSet)
                    .HasForeignKey(d => d.EmisorRegimenFiscal1)
                    .HasConstraintName("Emisor_RegimenFiscal");
            });

            modelBuilder.Entity<EmployeeRolesSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EmployeeRolesClientGroup).HasColumnName("EmployeeRoles_ClientGroup");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.EmployeeRolesClientGroupNavigation)
                    .WithMany(p => p.EmployeeRolesSet)
                    .HasForeignKey(d => d.EmployeeRolesClientGroup)
                    .HasConstraintName("EmployeeRoles_ClientGroup");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("UQ__tmp_ms_x__A9D1053479B76AB5")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__tmp_ms_x__737584F6DA65E974")
                    .IsUnique();

                entity.Property(e => e.Cellular).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmployeeDepartment).HasColumnName("Employee_Department");

                entity.Property(e => e.EmployeeTechnicalEmployee).HasColumnName("Employee_TechnicalEmployee");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.EmployeeDepartmentNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployeeDepartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Employee_Department");

                entity.HasOne(d => d.EmployeeTechnicalEmployeeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.EmployeeTechnicalEmployee)
                    .HasConstraintName("Employee_TechnicalEmployee");
            });

            modelBuilder.Entity<EmployeesAppointmentSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DetailAppointmentEmployeesAppointment).HasColumnName("DetailAppointment_EmployeesAppointment");

                entity.Property(e => e.EmployeesAppointmentEmployee).HasColumnName("EmployeesAppointment_Employee");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DetailAppointmentEmployeesAppointmentNavigation)
                    .WithMany(p => p.EmployeesAppointmentSet)
                    .HasForeignKey(d => d.DetailAppointmentEmployeesAppointment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DetailAppointment_EmployeesAppointment");

                entity.HasOne(d => d.EmployeesAppointmentEmployeeNavigation)
                    .WithMany(p => p.EmployeesAppointmentSet)
                    .HasForeignKey(d => d.EmployeesAppointmentEmployee)
                    .HasConstraintName("EmployeesAppointment_Employee");
            });

            modelBuilder.Entity<EncabezadoEstadoCuentaSet>(entity =>
            {
                entity.Property(e => e.Certificado)
                    .IsRequired()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormaDePago)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LugarExpedicion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MetodoPago)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Moneda).HasMaxLength(5);

                entity.Property(e => e.NoCertificado)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NumCtaPago).HasMaxLength(18);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Sello)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TipoCambio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoDeComprobante).HasMaxLength(10);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Version).HasMaxLength(6);
            });

            modelBuilder.Entity<ErrorRevisionMeterSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DescriptionError)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<EstadoDeCuentaCombustibleSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EstadoDeCuentaCombustibleEdc).HasColumnName("EstadoDeCuentaCombustible_EDC");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NumeroDeCuenta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Subtotal).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Total).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.VersionVer33).HasMaxLength(10);

                entity.HasOne(d => d.EstadoDeCuentaCombustibleEdcNavigation)
                    .WithMany(p => p.EstadoDeCuentaCombustibleSet)
                    .HasForeignKey(d => d.EstadoDeCuentaCombustibleEdc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EstadoDeCuentaCombustible_EDC");
            });

            modelBuilder.Entity<ExpedidoEnSet>(entity =>
            {
                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryExpedidoEn).HasColumnName("Country_ExpedidoEn");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpedidoEnCity).HasColumnName("ExpedidoEn_City");

                entity.Property(e => e.ExpedidoEnCodigoPostal).HasColumnName("ExpedidoEn_CodigoPostal");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MunicipioExpedidoEn).HasColumnName("Municipio_ExpedidoEn");

                entity.Property(e => e.NoExterior)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoInterior)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Referencia).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CountryExpedidoEnNavigation)
                    .WithMany(p => p.ExpedidoEnSet)
                    .HasForeignKey(d => d.CountryExpedidoEn)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Country_ExpedidoEn");

                entity.HasOne(d => d.ExpedidoEnCityNavigation)
                    .WithMany(p => p.ExpedidoEnSet)
                    .HasForeignKey(d => d.ExpedidoEnCity)
                    .HasConstraintName("ExpedidoEn_City");

                entity.HasOne(d => d.ExpedidoEnCodigoPostalNavigation)
                    .WithMany(p => p.ExpedidoEnSet)
                    .HasForeignKey(d => d.ExpedidoEnCodigoPostal)
                    .HasConstraintName("ExpedidoEn_CodigoPostal");

                entity.HasOne(d => d.MunicipioExpedidoEnNavigation)
                    .WithMany(p => p.ExpedidoEnSet)
                    .HasForeignKey(d => d.MunicipioExpedidoEn)
                    .HasConstraintName("Municipio_ExpedidoEn");
            });

            modelBuilder.Entity<ExpertiseSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<FeeCommisionSet>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CommentsCanceled).HasMaxLength(150);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateTimeOperation)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FeeCommisionBilling).HasColumnName("FeeCommision_BIlling");

                entity.Property(e => e.FeeCommisionClientGroup).HasColumnName("FeeCommision_ClientGroup");

                entity.Property(e => e.FeeCommisionTypeConceptBalance).HasColumnName("FeeCommision_TypeConceptBalance");

                entity.Property(e => e.FeeCommisionTypeExpenses).HasColumnName("FeeCommision_TypeExpenses");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FeeCommisionBillingNavigation)
                    .WithMany(p => p.FeeCommisionSet)
                    .HasForeignKey(d => d.FeeCommisionBilling)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FeeCommision_BIlling");

                entity.HasOne(d => d.FeeCommisionClientGroupNavigation)
                    .WithMany(p => p.FeeCommisionSet)
                    .HasForeignKey(d => d.FeeCommisionClientGroup)
                    .HasConstraintName("FeeCommision_ClientGroup");

                entity.HasOne(d => d.FeeCommisionTypeConceptBalanceNavigation)
                    .WithMany(p => p.FeeCommisionSet)
                    .HasForeignKey(d => d.FeeCommisionTypeConceptBalance)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FeeCommision_TypeConceptBalance");

                entity.HasOne(d => d.FeeCommisionTypeExpensesNavigation)
                    .WithMany(p => p.FeeCommisionSet)
                    .HasForeignKey(d => d.FeeCommisionTypeExpenses)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FeeCommision_TypeExpenses");
            });

            modelBuilder.Entity<FormaDePagoSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<FsGetInfoSet>(entity =>
            {
                entity.Property(e => e.ConnectionState)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FsGetInfoEmployee).HasColumnName("FsGetInfo_Employee");

                entity.Property(e => e.InformationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.FsGetInfoEmployeeNavigation)
                    .WithMany(p => p.FsGetInfoSet)
                    .HasForeignKey(d => d.FsGetInfoEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FsGetInfo_Employee");
            });

            modelBuilder.Entity<FuelCodesByStationSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FuelCodesByStationGasStation).HasColumnName("FuelCodesByStation_GasStation");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProductCodeFuelCodesByStation).HasColumnName("ProductCode_FuelCodesByStation");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FuelCodesByStationGasStationNavigation)
                    .WithMany(p => p.FuelCodesByStationSet)
                    .HasForeignKey(d => d.FuelCodesByStationGasStation)
                    .HasConstraintName("FuelCodesByStation_GasStation");

                entity.HasOne(d => d.ProductCodeFuelCodesByStationNavigation)
                    .WithMany(p => p.FuelCodesByStationSet)
                    .HasForeignKey(d => d.ProductCodeFuelCodesByStation)
                    .HasConstraintName("ProductCode_FuelCodesByStation");
            });

            modelBuilder.Entity<FuelSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FuelFuelType).HasColumnName("Fuel_FuelType");

                entity.Property(e => e.FuelGasStation).HasColumnName("Fuel_GasStation");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.FuelFuelTypeNavigation)
                    .WithMany(p => p.FuelSet)
                    .HasForeignKey(d => d.FuelFuelType)
                    .HasConstraintName("Fuel_FuelType");

                entity.HasOne(d => d.FuelGasStationNavigation)
                    .WithMany(p => p.FuelSet)
                    .HasForeignKey(d => d.FuelGasStation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fuel_GasStation");
            });

            modelBuilder.Entity<FuelTypes>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CveUnidad).HasMaxLength(5);

                entity.Property(e => e.DescriptionUnidad).HasMaxLength(255);

                entity.Property(e => e.FuelTypeClaveProdServ).HasColumnName("FuelType_ClaveProdServ");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.FuelTypeClaveProdServNavigation)
                    .WithMany(p => p.FuelTypes)
                    .HasForeignKey(d => d.FuelTypeClaveProdServ)
                    .HasConstraintName("FuelType_ClaveProdServ");
            });

            modelBuilder.Entity<GasStationExtraActivitiesSet>(entity =>
            {
                entity.Property(e => e.ActivityDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GasStationExtraActivitiesTaskStatus).HasColumnName("GasStationExtraActivities_TaskStatus");

                entity.Property(e => e.GasStationGasStationExtraActivities).HasColumnName("GasStation_GasStationExtraActivities");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.GasStationExtraActivitiesTaskStatusNavigation)
                    .WithMany(p => p.GasStationExtraActivitiesSet)
                    .HasForeignKey(d => d.GasStationExtraActivitiesTaskStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GasStationExtraActivities_TaskStatus");

                entity.HasOne(d => d.GasStationGasStationExtraActivitiesNavigation)
                    .WithMany(p => p.GasStationExtraActivitiesSet)
                    .HasForeignKey(d => d.GasStationGasStationExtraActivities)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GasStation_GasStationExtraActivities");
            });

            modelBuilder.Entity<GasStationGroups>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IdTotvs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Nickname).HasMaxLength(255);

                entity.Property(e => e.OficialName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GasStations>(entity =>
            {
                entity.HasIndex(e => e.OficialName)
                    .HasName("UQ__tmp_ms_x__E5E85EEE4ACB23C2")
                    .IsUnique();

                entity.Property(e => e.AccountNumber).HasMaxLength(18);

                entity.Property(e => e.AviVersion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Bandera).HasMaxLength(150);

                entity.Property(e => e.CablesLocationDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CatMetodoPagoGasStation).HasColumnName("CatMetodoPago_GasStation");

                entity.Property(e => e.CgProvider)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CgVersion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ConfiguracionEdGasStation).HasColumnName("ConfiguracionED_GasStation");

                entity.Property(e => e.CreId)
                    .HasColumnName("CRE_Id")
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FormaDePagoGasStation).HasColumnName("FormaDePago_GasStation");

                entity.Property(e => e.GasStationAddress).HasColumnName("GasStation_Address");

                entity.Property(e => e.GasStationClientGroup).HasColumnName("GasStation_ClientGroup");

                entity.Property(e => e.GasStationGasStationGroup).HasColumnName("GasStation_GasStationGroup");

                entity.Property(e => e.GasStationPcOsVersion).HasColumnName("GasStation_PcOsVersion");

                entity.Property(e => e.GasStationPumpController).HasColumnName("GasStation_PumpController");

                entity.Property(e => e.GasStationTimeZoneC).HasColumnName("GasStation_TimeZoneC");

                entity.Property(e => e.GasStationVolumetric).HasColumnName("GasStation_Volumetric");

                entity.Property(e => e.HelpCommentsTicket).HasMaxLength(255);

                entity.Property(e => e.HelpNameEmployee).HasMaxLength(255);

                entity.Property(e => e.IdSucursalTotvs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdTotvs)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NickName).HasMaxLength(255);

                entity.Property(e => e.OficialName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PassWa)
                    .IsRequired()
                    .HasColumnName("PassWA")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PlaceId).HasColumnName("Place_Id");

                entity.Property(e => e.PumpTypeGasStation).HasColumnName("PumpType_GasStation");

                entity.Property(e => e.ReadersNozzles).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SgpmVersion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SgpsVersion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StationTypeGasStation).HasColumnName("StationType_GasStation");

                entity.Property(e => e.Tardefault).HasColumnName("TARDefault");

                entity.Property(e => e.UserWa)
                    .IsRequired()
                    .HasColumnName("UserWA")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.CatMetodoPagoGasStationNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.CatMetodoPagoGasStation)
                    .HasConstraintName("CatMetodoPago_GasStation");

                entity.HasOne(d => d.ConfiguracionEdGasStationNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.ConfiguracionEdGasStation)
                    .HasConstraintName("ConfiguracionED_GasStation");

                entity.HasOne(d => d.FormaDePagoGasStationNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.FormaDePagoGasStation)
                    .HasConstraintName("FormaDePago_GasStation");

                entity.HasOne(d => d.GasStationAddressNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.GasStationAddress)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GasStation_Address");

                entity.HasOne(d => d.GasStationClientGroupNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.GasStationClientGroup)
                    .HasConstraintName("GasStation_ClientGroup");

                entity.HasOne(d => d.GasStationGasStationGroupNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.GasStationGasStationGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GasStation_GasStationGroup");

                entity.HasOne(d => d.GasStationPcOsVersionNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.GasStationPcOsVersion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GasStation_PcOsVersion");

                entity.HasOne(d => d.GasStationPumpControllerNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.GasStationPumpController)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GasStation_PumpController");

                entity.HasOne(d => d.GasStationTimeZoneCNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.GasStationTimeZoneC)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GasStation_TimeZoneC");

                entity.HasOne(d => d.GasStationVolumetricNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.GasStationVolumetric)
                    .HasConstraintName("GasStation_Volumetric");

                entity.HasOne(d => d.PumpTypeGasStationNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.PumpTypeGasStation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PumpType_GasStation");

                entity.HasOne(d => d.StationTypeGasStationNavigation)
                    .WithMany(p => p.GasStations)
                    .HasForeignKey(d => d.StationTypeGasStation)
                    .HasConstraintName("StationType_GasStation");
            });

            modelBuilder.Entity<GlobalParametersSet>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<GpsConfiguracionParametrosSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.GpsConfiguracionParametrosGpsParameters).HasColumnName("GpsConfiguracionParametros_GpsParameters");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.Valor).HasMaxLength(255);

                entity.HasOne(d => d.GpsConfiguracionParametrosGpsParametersNavigation)
                    .WithMany(p => p.GpsConfiguracionParametrosSet)
                    .HasForeignKey(d => d.GpsConfiguracionParametrosGpsParameters)
                    .HasConstraintName("GpsConfiguracionParametros_GpsParameters");
            });

            modelBuilder.Entity<GpsDbManagerSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DbType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GpsJobSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServiceIp)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<GpsOdometerSet>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DeltaValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.GpsOdometerEmployee).HasColumnName("GpsOdometer_Employee");

                entity.Property(e => e.GpsOdometerVehicle).HasColumnName("GpsOdometer_Vehicle");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OdometerDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OdometerDateLocal).HasColumnType("datetime");

                entity.Property(e => e.OdometerValue).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.OdometerValueBefore).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UnitIdHex).HasMaxLength(255);

                entity.HasOne(d => d.GpsOdometerEmployeeNavigation)
                    .WithMany(p => p.GpsOdometerSet)
                    .HasForeignKey(d => d.GpsOdometerEmployee)
                    .HasConstraintName("GpsOdometer_Employee");

                entity.HasOne(d => d.GpsOdometerVehicleNavigation)
                    .WithMany(p => p.GpsOdometerSet)
                    .HasForeignKey(d => d.GpsOdometerVehicle)
                    .HasConstraintName("GpsOdometer_Vehicle");
            });

            modelBuilder.Entity<GpsParametersSet>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GpsServerSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DataBaseName).HasMaxLength(255);

                entity.Property(e => e.GpsServerGpsDbManager).HasColumnName("GpsServer_GpsDbManager");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NickName).HasMaxLength(80);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.GpsServerGpsDbManagerNavigation)
                    .WithMany(p => p.GpsServerSet)
                    .HasForeignKey(d => d.GpsServerGpsDbManager)
                    .HasConstraintName("GpsServer_GpsDbManager");
            });

            modelBuilder.Entity<GpsSet>(entity =>
            {
                entity.Property(e => e.Box).HasMaxLength(255);

                entity.Property(e => e.Comentarios).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateGpsSim).HasColumnType("datetime");

                entity.Property(e => e.DateInstallation).HasColumnType("datetime");

                entity.Property(e => e.DatePackage).HasColumnType("datetime");

                entity.Property(e => e.Fw).HasMaxLength(255);

                entity.Property(e => e.GpsEmployee).HasColumnName("Gps_Employee");

                entity.Property(e => e.GpsEmployee1).HasColumnName("Gps_Employee1");

                entity.Property(e => e.GpsGpsServer).HasColumnName("Gps_GpsServer");

                entity.Property(e => e.GpsParametersGps).HasColumnName("GpsParameters_Gps");

                entity.Property(e => e.GpsStatus).HasColumnName("Gps_Status");

                entity.Property(e => e.GpsVersionGps).HasColumnName("GpsVersion_Gps");

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OdometerDate).HasColumnType("datetime");

                entity.Property(e => e.ParamVersion).HasMaxLength(255);

                entity.Property(e => e.ProductsGps).HasColumnName("Products_Gps");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitIdhex)
                    .HasColumnName("UnitIDHex")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitType).HasMaxLength(255);

                entity.Property(e => e.ValorOdometer).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.VehicleGps).HasColumnName("Vehicle_Gps");

                entity.HasOne(d => d.GpsEmployeeNavigation)
                    .WithMany(p => p.GpsSetGpsEmployeeNavigation)
                    .HasForeignKey(d => d.GpsEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Gps_Employee");

                entity.HasOne(d => d.GpsEmployee1Navigation)
                    .WithMany(p => p.GpsSetGpsEmployee1Navigation)
                    .HasForeignKey(d => d.GpsEmployee1)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("Gps_Employee1");

                entity.HasOne(d => d.GpsGpsServerNavigation)
                    .WithMany(p => p.GpsSet)
                    .HasForeignKey(d => d.GpsGpsServer)
                    .HasConstraintName("Gps_GpsServer");

                entity.HasOne(d => d.GpsParametersGpsNavigation)
                    .WithMany(p => p.GpsSet)
                    .HasForeignKey(d => d.GpsParametersGps)
                    .HasConstraintName("GpsParameters_Gps");

                entity.HasOne(d => d.GpsStatusNavigation)
                    .WithMany(p => p.GpsSet)
                    .HasForeignKey(d => d.GpsStatus)
                    .HasConstraintName("Gps_Status");

                entity.HasOne(d => d.GpsVersionGpsNavigation)
                    .WithMany(p => p.GpsSet)
                    .HasForeignKey(d => d.GpsVersionGps)
                    .HasConstraintName("GpsVersion_Gps");

                entity.HasOne(d => d.ProductsGpsNavigation)
                    .WithMany(p => p.GpsSet)
                    .HasForeignKey(d => d.ProductsGps)
                    .HasConstraintName("Products_Gps");

                entity.HasOne(d => d.VehicleGpsNavigation)
                    .WithMany(p => p.GpsSet)
                    .HasForeignKey(d => d.VehicleGps)
                    .HasConstraintName("Vehicle_Gps");
            });

            modelBuilder.Entity<GpsVersionSet>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateUpdate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<GrtfailureSet>(entity =>
            {
                entity.ToTable("GRTFailureSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DescriptionFailure)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Grtset>(entity =>
            {
                entity.ToTable("GRTSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FactoryOwner).HasMaxLength(255);

                entity.Property(e => e.GrttypeGrt).HasColumnName("GRTType_GRT");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.GrttypeGrtNavigation)
                    .WithMany(p => p.Grtset)
                    .HasForeignKey(d => d.GrttypeGrt)
                    .HasConstraintName("GRTType_GRT");
            });

            modelBuilder.Entity<GrttypeSet>(entity =>
            {
                entity.ToTable("GRTTypeSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<HeaderBillingSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeOperation)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<HistorialDeFacturacionSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StatusDescription).HasMaxLength(255);

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<HistoryAccesoriesSet>(entity =>
            {
                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.ActivationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FisicalLocation).HasMaxLength(255);

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.GasStationsAccesories)
                    .HasColumnName("GasStations_Accesories")
                    .HasMaxLength(255);

                entity.Property(e => e.GpsAccesories)
                    .HasColumnName("Gps_Accesories")
                    .HasMaxLength(255);

                entity.Property(e => e.HistoryAccesoriesReplacementReason).HasColumnName("HistoryAccesories_ReplacementReason");

                entity.Property(e => e.HistoryAccesoriesTreatmentType).HasColumnName("HistoryAccesories_TreatmentType");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProductsAccesories)
                    .HasColumnName("Products_Accesories")
                    .HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SerialNumber).HasMaxLength(255);

                entity.Property(e => e.ServiceDataTime).HasColumnType("datetime");

                entity.Property(e => e.TestingProductsAccesories)
                    .HasColumnName("TestingProducts_Accesories")
                    .HasMaxLength(255);

                entity.Property(e => e.VehiclesAccesories)
                    .HasColumnName("Vehicles_Accesories")
                    .HasMaxLength(255);

                entity.HasOne(d => d.HistoryAccesoriesReplacementReasonNavigation)
                    .WithMany(p => p.HistoryAccesoriesSet)
                    .HasForeignKey(d => d.HistoryAccesoriesReplacementReason)
                    .HasConstraintName("HistoryAccesories_ReplacementReason");

                entity.HasOne(d => d.HistoryAccesoriesTreatmentTypeNavigation)
                    .WithMany(p => p.HistoryAccesoriesSet)
                    .HasForeignKey(d => d.HistoryAccesoriesTreatmentType)
                    .HasConstraintName("HistoryAccesories_TreatmentType");
            });

            modelBuilder.Entity<HistoryAntennas>(entity =>
            {
                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.ActualIp)
                    .HasColumnName("Actual_Ip")
                    .HasMaxLength(255);

                entity.Property(e => e.CablesLocationDescription).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.HistoryAntennaGasStation).HasColumnName("HistoryAntenna_GasStation");

                entity.Property(e => e.HistoryAntennaProducts).HasColumnName("HistoryAntenna_Products");

                entity.Property(e => e.HistoryAntennaReplacementReason).HasColumnName("HistoryAntenna_ReplacementReason");

                entity.Property(e => e.InstallationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.MalfunctionAntennas).HasColumnName("Malfunction_Antennas");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PowerSupplyLocationDescription).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.HistoryAntennaGasStationNavigation)
                    .WithMany(p => p.HistoryAntennas)
                    .HasForeignKey(d => d.HistoryAntennaGasStation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HistoryAntenna_GasStation");

                entity.HasOne(d => d.HistoryAntennaProductsNavigation)
                    .WithMany(p => p.HistoryAntennas)
                    .HasForeignKey(d => d.HistoryAntennaProducts)
                    .HasConstraintName("HistoryAntenna_Products");

                entity.HasOne(d => d.HistoryAntennaReplacementReasonNavigation)
                    .WithMany(p => p.HistoryAntennas)
                    .HasForeignKey(d => d.HistoryAntennaReplacementReason)
                    .HasConstraintName("HistoryAntenna_ReplacementReason");
            });

            modelBuilder.Entity<HistoryBatterySet>(entity =>
            {
                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateInstallation).HasColumnType("datetime");

                entity.Property(e => e.DateSendLaboratory).HasColumnType("datetime");

                entity.Property(e => e.DiagnosticBattery).HasMaxLength(255);

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.FuelType).HasMaxLength(255);

                entity.Property(e => e.HistoryBatteryBatteryFailure).HasColumnName("HistoryBattery_BatteryFailure");

                entity.Property(e => e.HistoryBatteryBatteryType).HasColumnName("HistoryBattery_BatteryType");

                entity.Property(e => e.HistoryBatteryGasStation).HasColumnName("HistoryBattery_GasStation");

                entity.Property(e => e.HistoryBatteryReplacementReason).HasColumnName("HistoryBattery_ReplacementReason");

                entity.Property(e => e.LaboratoryNumber).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SerialNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Voltage).HasMaxLength(255);

                entity.HasOne(d => d.HistoryBatteryBatteryFailureNavigation)
                    .WithMany(p => p.HistoryBatterySet)
                    .HasForeignKey(d => d.HistoryBatteryBatteryFailure)
                    .HasConstraintName("HistoryBattery_BatteryFailure");

                entity.HasOne(d => d.HistoryBatteryBatteryTypeNavigation)
                    .WithMany(p => p.HistoryBatterySet)
                    .HasForeignKey(d => d.HistoryBatteryBatteryType)
                    .HasConstraintName("HistoryBattery_BatteryType");

                entity.HasOne(d => d.HistoryBatteryGasStationNavigation)
                    .WithMany(p => p.HistoryBatterySet)
                    .HasForeignKey(d => d.HistoryBatteryGasStation)
                    .HasConstraintName("HistoryBattery_GasStation");

                entity.HasOne(d => d.HistoryBatteryReplacementReasonNavigation)
                    .WithMany(p => p.HistoryBatterySet)
                    .HasForeignKey(d => d.HistoryBatteryReplacementReason)
                    .HasConstraintName("HistoryBattery_ReplacementReason");
            });

            modelBuilder.Entity<HistoryContractFacSet>(entity =>
            {
                entity.Property(e => e.ContractFacHistoryContractFac).HasColumnName("ContractFac_HistoryContractFac");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ContractFacHistoryContractFacNavigation)
                    .WithMany(p => p.HistoryContractFacSet)
                    .HasForeignKey(d => d.ContractFacHistoryContractFac)
                    .HasConstraintName("ContractFac_HistoryContractFac");
            });

            modelBuilder.Entity<HistoryGasStationSet>(entity =>
            {
                entity.Property(e => e.AccountNumber).HasMaxLength(255);

                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.AviVersion).HasMaxLength(255);

                entity.Property(e => e.CablesLocationDescription).HasMaxLength(255);

                entity.Property(e => e.CgProvider).HasMaxLength(255);

                entity.Property(e => e.CgVersion).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.HelpCommentsTicket).HasMaxLength(255);

                entity.Property(e => e.HelpNameEmployee).HasMaxLength(255);

                entity.Property(e => e.HistoryGasStationAddress).HasColumnName("HistoryGasStation_Address");

                entity.Property(e => e.HistoryGasStationCatMetodoPago).HasColumnName("HistoryGasStation_CatMetodoPago");

                entity.Property(e => e.HistoryGasStationConfiguracionEd).HasColumnName("HistoryGasStation_ConfiguracionED");

                entity.Property(e => e.HistoryGasStationFormaDePago).HasColumnName("HistoryGasStation_FormaDePago");

                entity.Property(e => e.HistoryGasStationGasStationGroup).HasColumnName("HistoryGasStation_GasStationGroup");

                entity.Property(e => e.HistoryGasStationPcOsVersion).HasColumnName("HistoryGasStation_PcOsVersion");

                entity.Property(e => e.HistoryGasStationPumpController).HasColumnName("HistoryGasStation_PumpController");

                entity.Property(e => e.HistoryGasStationPumpType).HasColumnName("HistoryGasStation_PumpType");

                entity.Property(e => e.HistoryGasStationTimeZoneC).HasColumnName("HistoryGasStation_TimeZoneC");

                entity.Property(e => e.HistoryGasStationVolumetric).HasColumnName("HistoryGasStation_Volumetric");

                entity.Property(e => e.IdSucursalTotvs).HasMaxLength(255);

                entity.Property(e => e.IdTotvs).HasMaxLength(255);

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OficialName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PassWa)
                    .HasColumnName("PassWA")
                    .HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SgpmVersion).HasMaxLength(255);

                entity.Property(e => e.SgpsVersion).HasMaxLength(255);

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tardefault).HasColumnName("TARDefault");

                entity.Property(e => e.UserWa)
                    .HasColumnName("UserWA")
                    .HasMaxLength(255);

                entity.HasOne(d => d.HistoryGasStationAddressNavigation)
                    .WithMany(p => p.HistoryGasStationSet)
                    .HasForeignKey(d => d.HistoryGasStationAddress)
                    .HasConstraintName("HistoryGasStation_Address");

                entity.HasOne(d => d.HistoryGasStationCatMetodoPagoNavigation)
                    .WithMany(p => p.HistoryGasStationSet)
                    .HasForeignKey(d => d.HistoryGasStationCatMetodoPago)
                    .HasConstraintName("HistoryGasStation_CatMetodoPago");

                entity.HasOne(d => d.HistoryGasStationConfiguracionEdNavigation)
                    .WithMany(p => p.HistoryGasStationSet)
                    .HasForeignKey(d => d.HistoryGasStationConfiguracionEd)
                    .HasConstraintName("HistoryGasStation_ConfiguracionED");

                entity.HasOne(d => d.HistoryGasStationFormaDePagoNavigation)
                    .WithMany(p => p.HistoryGasStationSet)
                    .HasForeignKey(d => d.HistoryGasStationFormaDePago)
                    .HasConstraintName("HistoryGasStation_FormaDePago");

                entity.HasOne(d => d.HistoryGasStationGasStationGroupNavigation)
                    .WithMany(p => p.HistoryGasStationSet)
                    .HasForeignKey(d => d.HistoryGasStationGasStationGroup)
                    .HasConstraintName("HistoryGasStation_GasStationGroup");

                entity.HasOne(d => d.HistoryGasStationPcOsVersionNavigation)
                    .WithMany(p => p.HistoryGasStationSet)
                    .HasForeignKey(d => d.HistoryGasStationPcOsVersion)
                    .HasConstraintName("HistoryGasStation_PcOsVersion");

                entity.HasOne(d => d.HistoryGasStationPumpControllerNavigation)
                    .WithMany(p => p.HistoryGasStationSet)
                    .HasForeignKey(d => d.HistoryGasStationPumpController)
                    .HasConstraintName("HistoryGasStation_PumpController");

                entity.HasOne(d => d.HistoryGasStationPumpTypeNavigation)
                    .WithMany(p => p.HistoryGasStationSet)
                    .HasForeignKey(d => d.HistoryGasStationPumpType)
                    .HasConstraintName("HistoryGasStation_PumpType");

                entity.HasOne(d => d.HistoryGasStationTimeZoneCNavigation)
                    .WithMany(p => p.HistoryGasStationSet)
                    .HasForeignKey(d => d.HistoryGasStationTimeZoneC)
                    .HasConstraintName("HistoryGasStation_TimeZoneC");

                entity.HasOne(d => d.HistoryGasStationVolumetricNavigation)
                    .WithMany(p => p.HistoryGasStationSet)
                    .HasForeignKey(d => d.HistoryGasStationVolumetric)
                    .HasConstraintName("HistoryGasStation_Volumetric");
            });

            modelBuilder.Entity<HistoryGpsSet>(entity =>
            {
                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.Box).HasMaxLength(255);

                entity.Property(e => e.Comentarios).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateGpsSim).HasColumnType("datetime");

                entity.Property(e => e.DateInstallation).HasColumnType("datetime");

                entity.Property(e => e.DatePackage).HasColumnType("datetime");

                entity.Property(e => e.Fw).HasMaxLength(255);

                entity.Property(e => e.HistoryGpsEmployee).HasColumnName("HistoryGps_Employee");

                entity.Property(e => e.HistoryGpsGpsParameters).HasColumnName("HistoryGps_GpsParameters");

                entity.Property(e => e.HistoryGpsGpsVersion).HasColumnName("HistoryGps_GpsVersion");

                entity.Property(e => e.HistoryGpsProducts).HasColumnName("HistoryGps_Products");

                entity.Property(e => e.HistoryGpsStatus).HasColumnName("HistoryGps_Status");

                entity.Property(e => e.HistoryGpsVehicle).HasColumnName("HistoryGps_Vehicle");

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OdometerDate).HasColumnType("datetime");

                entity.Property(e => e.ParamVersion).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Simgps)
                    .HasColumnName("SIMGps")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitId)
                    .IsRequired()
                    .HasColumnName("UnitID")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UnitIdhex)
                    .IsRequired()
                    .HasColumnName("UnitIDHex")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UnitType).HasMaxLength(255);

                entity.Property(e => e.ValorOdometer).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.HistoryGpsEmployeeNavigation)
                    .WithMany(p => p.HistoryGpsSet)
                    .HasForeignKey(d => d.HistoryGpsEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HistoryGps_Employee");

                entity.HasOne(d => d.HistoryGpsGpsParametersNavigation)
                    .WithMany(p => p.HistoryGpsSet)
                    .HasForeignKey(d => d.HistoryGpsGpsParameters)
                    .HasConstraintName("HistoryGps_GpsParameters");

                entity.HasOne(d => d.HistoryGpsGpsVersionNavigation)
                    .WithMany(p => p.HistoryGpsSet)
                    .HasForeignKey(d => d.HistoryGpsGpsVersion)
                    .HasConstraintName("HistoryGps_GpsVersion");

                entity.HasOne(d => d.HistoryGpsProductsNavigation)
                    .WithMany(p => p.HistoryGpsSet)
                    .HasForeignKey(d => d.HistoryGpsProducts)
                    .HasConstraintName("HistoryGps_Products");

                entity.HasOne(d => d.HistoryGpsStatusNavigation)
                    .WithMany(p => p.HistoryGpsSet)
                    .HasForeignKey(d => d.HistoryGpsStatus)
                    .HasConstraintName("HistoryGps_Status");

                entity.HasOne(d => d.HistoryGpsVehicleNavigation)
                    .WithMany(p => p.HistoryGpsSet)
                    .HasForeignKey(d => d.HistoryGpsVehicle)
                    .HasConstraintName("HistoryGps_Vehicle");
            });

            modelBuilder.Entity<HistoryImageInstallationSet>(entity =>
            {
                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.HistoryImageInstallationAccesories).HasColumnName("HistoryImageInstallation_Accesories");

                entity.Property(e => e.HistoryImageInstallationAccesories1).HasColumnName("HistoryImageInstallation_Accesories1");

                entity.Property(e => e.HistoryImageInstallationAntenna).HasColumnName("HistoryImageInstallation_Antenna");

                entity.Property(e => e.HistoryImageInstallationBattery).HasColumnName("HistoryImageInstallation_Battery");

                entity.Property(e => e.HistoryImageInstallationBattery1).HasColumnName("HistoryImageInstallation_Battery1");

                entity.Property(e => e.HistoryImageInstallationChangeRequestPlate).HasColumnName("HistoryImageInstallation_ChangeRequestPlate");

                entity.Property(e => e.HistoryImageInstallationGasStation).HasColumnName("HistoryImageInstallation_GasStation");

                entity.Property(e => e.HistoryImageInstallationGasStationExtraActivities).HasColumnName("HistoryImageInstallation_GasStationExtraActivities");

                entity.Property(e => e.HistoryImageInstallationGps).HasColumnName("HistoryImageInstallation_Gps");

                entity.Property(e => e.HistoryImageInstallationGps1).HasColumnName("HistoryImageInstallation_Gps1");

                entity.Property(e => e.HistoryImageInstallationMeter).HasColumnName("HistoryImageInstallation_Meter");

                entity.Property(e => e.HistoryImageInstallationMeter1).HasColumnName("HistoryImageInstallation_Meter1");

                entity.Property(e => e.HistoryImageInstallationReader).HasColumnName("HistoryImageInstallation_Reader");

                entity.Property(e => e.HistoryImageInstallationTag).HasColumnName("HistoryImageInstallation_Tag");

                entity.Property(e => e.HistoryImageInstallationTag1).HasColumnName("HistoryImageInstallation_Tag1");

                entity.Property(e => e.HistoryImageInstallationVehicle).HasColumnName("HistoryImageInstallation_Vehicle");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.HistoryImageInstallationAccesoriesNavigation)
                    .WithMany(p => p.HistoryImageInstallationSetHistoryImageInstallationAccesoriesNavigation)
                    .HasForeignKey(d => d.HistoryImageInstallationAccesories)
                    .HasConstraintName("HistoryImageInstallation_Accesories");

                entity.HasOne(d => d.HistoryImageInstallationAccesories1Navigation)
                    .WithMany(p => p.HistoryImageInstallationSetHistoryImageInstallationAccesories1Navigation)
                    .HasForeignKey(d => d.HistoryImageInstallationAccesories1)
                    .HasConstraintName("HistoryImageInstallation_Accesories1");

                entity.HasOne(d => d.HistoryImageInstallationAntennaNavigation)
                    .WithMany(p => p.HistoryImageInstallationSet)
                    .HasForeignKey(d => d.HistoryImageInstallationAntenna)
                    .HasConstraintName("HistoryImageInstallation_Antenna");

                entity.HasOne(d => d.HistoryImageInstallationBatteryNavigation)
                    .WithMany(p => p.HistoryImageInstallationSetHistoryImageInstallationBatteryNavigation)
                    .HasForeignKey(d => d.HistoryImageInstallationBattery)
                    .HasConstraintName("HistoryImageInstallation_Battery");

                entity.HasOne(d => d.HistoryImageInstallationBattery1Navigation)
                    .WithMany(p => p.HistoryImageInstallationSetHistoryImageInstallationBattery1Navigation)
                    .HasForeignKey(d => d.HistoryImageInstallationBattery1)
                    .HasConstraintName("HistoryImageInstallation_Battery1");

                entity.HasOne(d => d.HistoryImageInstallationChangeRequestPlateNavigation)
                    .WithMany(p => p.HistoryImageInstallationSet)
                    .HasForeignKey(d => d.HistoryImageInstallationChangeRequestPlate)
                    .HasConstraintName("HistoryImageInstallation_ChangeRequestPlate");

                entity.HasOne(d => d.HistoryImageInstallationGasStationNavigation)
                    .WithMany(p => p.HistoryImageInstallationSet)
                    .HasForeignKey(d => d.HistoryImageInstallationGasStation)
                    .HasConstraintName("HistoryImageInstallation_GasStation");

                entity.HasOne(d => d.HistoryImageInstallationGasStationExtraActivitiesNavigation)
                    .WithMany(p => p.HistoryImageInstallationSet)
                    .HasForeignKey(d => d.HistoryImageInstallationGasStationExtraActivities)
                    .HasConstraintName("HistoryImageInstallation_GasStationExtraActivities");

                entity.HasOne(d => d.HistoryImageInstallationGpsNavigation)
                    .WithMany(p => p.HistoryImageInstallationSetHistoryImageInstallationGpsNavigation)
                    .HasForeignKey(d => d.HistoryImageInstallationGps)
                    .HasConstraintName("HistoryImageInstallation_Gps");

                entity.HasOne(d => d.HistoryImageInstallationGps1Navigation)
                    .WithMany(p => p.HistoryImageInstallationSetHistoryImageInstallationGps1Navigation)
                    .HasForeignKey(d => d.HistoryImageInstallationGps1)
                    .HasConstraintName("HistoryImageInstallation_Gps1");

                entity.HasOne(d => d.HistoryImageInstallationMeterNavigation)
                    .WithMany(p => p.HistoryImageInstallationSetHistoryImageInstallationMeterNavigation)
                    .HasForeignKey(d => d.HistoryImageInstallationMeter)
                    .HasConstraintName("HistoryImageInstallation_Meter");

                entity.HasOne(d => d.HistoryImageInstallationMeter1Navigation)
                    .WithMany(p => p.HistoryImageInstallationSetHistoryImageInstallationMeter1Navigation)
                    .HasForeignKey(d => d.HistoryImageInstallationMeter1)
                    .HasConstraintName("HistoryImageInstallation_Meter1");

                entity.HasOne(d => d.HistoryImageInstallationReaderNavigation)
                    .WithMany(p => p.HistoryImageInstallationSet)
                    .HasForeignKey(d => d.HistoryImageInstallationReader)
                    .HasConstraintName("HistoryImageInstallation_Reader");

                entity.HasOne(d => d.HistoryImageInstallationTagNavigation)
                    .WithMany(p => p.HistoryImageInstallationSetHistoryImageInstallationTagNavigation)
                    .HasForeignKey(d => d.HistoryImageInstallationTag)
                    .HasConstraintName("HistoryImageInstallation_Tag");

                entity.HasOne(d => d.HistoryImageInstallationTag1Navigation)
                    .WithMany(p => p.HistoryImageInstallationSetHistoryImageInstallationTag1Navigation)
                    .HasForeignKey(d => d.HistoryImageInstallationTag1)
                    .HasConstraintName("HistoryImageInstallation_Tag1");

                entity.HasOne(d => d.HistoryImageInstallationVehicleNavigation)
                    .WithMany(p => p.HistoryImageInstallationSet)
                    .HasForeignKey(d => d.HistoryImageInstallationVehicle)
                    .HasConstraintName("HistoryImageInstallation_Vehicle");
            });

            modelBuilder.Entity<HistoryMetersSet>(entity =>
            {
                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.ActivationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Connector).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.HistoryMetersEmployee).HasColumnName("HistoryMeters_Employee");

                entity.Property(e => e.HistoryMetersMeterType).HasColumnName("HistoryMeters_MeterType");

                entity.Property(e => e.HistoryMetersReplacementReason).HasColumnName("HistoryMeters_ReplacementReason");

                entity.Property(e => e.HistoryMetersTreatmentType).HasColumnName("HistoryMeters_TreatmentType");

                entity.Property(e => e.HistoryMetersVehicle).HasColumnName("HistoryMeters_Vehicle");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RevisionMeterCollection).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ServiceDataTime).HasColumnType("datetime");

                entity.HasOne(d => d.HistoryMetersEmployeeNavigation)
                    .WithMany(p => p.HistoryMetersSet)
                    .HasForeignKey(d => d.HistoryMetersEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HistoryMeters_Employee");

                entity.HasOne(d => d.HistoryMetersMeterTypeNavigation)
                    .WithMany(p => p.HistoryMetersSet)
                    .HasForeignKey(d => d.HistoryMetersMeterType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HistoryMeters_MeterType");

                entity.HasOne(d => d.HistoryMetersReplacementReasonNavigation)
                    .WithMany(p => p.HistoryMetersSet)
                    .HasForeignKey(d => d.HistoryMetersReplacementReason)
                    .HasConstraintName("HistoryMeters_ReplacementReason");

                entity.HasOne(d => d.HistoryMetersTreatmentTypeNavigation)
                    .WithMany(p => p.HistoryMetersSet)
                    .HasForeignKey(d => d.HistoryMetersTreatmentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HistoryMeters_TreatmentType");

                entity.HasOne(d => d.HistoryMetersVehicleNavigation)
                    .WithMany(p => p.HistoryMetersSet)
                    .HasForeignKey(d => d.HistoryMetersVehicle)
                    .HasConstraintName("HistoryMeters_Vehicle");
            });

            modelBuilder.Entity<HistoryProductMovementsSet>(entity =>
            {
                entity.Property(e => e.AccesoriesCollection).HasMaxLength(255);

                entity.Property(e => e.Antennas).HasMaxLength(255);

                entity.Property(e => e.BatteryCollection).HasMaxLength(255);

                entity.Property(e => e.CodProd)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.GpsCollection).HasMaxLength(255);

                entity.Property(e => e.Meters).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Readers).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.Tags).HasMaxLength(255);

                entity.Property(e => e.Tipo).HasMaxLength(255);

                entity.Property(e => e.Unidad).HasMaxLength(255);
            });

            modelBuilder.Entity<HistoryReaders>(entity =>
            {
                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.ActivationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.HistoryReaderAntenna).HasColumnName("HistoryReader_Antenna");

                entity.Property(e => e.HistoryReaderFuelType).HasColumnName("HistoryReader_FuelType");

                entity.Property(e => e.HistoryReaderGasStation).HasColumnName("HistoryReader_GasStation");

                entity.Property(e => e.HistoryReaderNozzleType).HasColumnName("HistoryReader_NozzleType");

                entity.Property(e => e.HistoryReaderReaderType).HasColumnName("HistoryReader_ReaderType");

                entity.Property(e => e.HistoryReaderReplacementReason).HasColumnName("HistoryReader_ReplacementReason");

                entity.Property(e => e.MalfunctionReader).HasColumnName("Malfunction_Reader");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.HistoryReaderAntennaNavigation)
                    .WithMany(p => p.HistoryReaders)
                    .HasForeignKey(d => d.HistoryReaderAntenna)
                    .HasConstraintName("HistoryReader_Antenna");

                entity.HasOne(d => d.HistoryReaderFuelTypeNavigation)
                    .WithMany(p => p.HistoryReaders)
                    .HasForeignKey(d => d.HistoryReaderFuelType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HistoryReader_FuelType");

                entity.HasOne(d => d.HistoryReaderGasStationNavigation)
                    .WithMany(p => p.HistoryReaders)
                    .HasForeignKey(d => d.HistoryReaderGasStation)
                    .HasConstraintName("HistoryReader_GasStation");

                entity.HasOne(d => d.HistoryReaderNozzleTypeNavigation)
                    .WithMany(p => p.HistoryReaders)
                    .HasForeignKey(d => d.HistoryReaderNozzleType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HistoryReader_NozzleType");

                entity.HasOne(d => d.HistoryReaderReaderTypeNavigation)
                    .WithMany(p => p.HistoryReaders)
                    .HasForeignKey(d => d.HistoryReaderReaderType)
                    .HasConstraintName("HistoryReader_ReaderType");

                entity.HasOne(d => d.HistoryReaderReplacementReasonNavigation)
                    .WithMany(p => p.HistoryReaders)
                    .HasForeignKey(d => d.HistoryReaderReplacementReason)
                    .HasConstraintName("HistoryReader_ReplacementReason");
            });

            modelBuilder.Entity<HistorySimgpsSet>(entity =>
            {
                entity.ToTable("HistorySIMGpsSet");

                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.HistorySimgpsGps).HasColumnName("HistorySIMGps_Gps");

                entity.Property(e => e.HistorySimgpsGpsBefore).HasColumnName("HistorySIMGps_GpsBefore");

                entity.Property(e => e.IdSimgps).HasColumnName("IdSIMGps");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PhoneNumberInter).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Simcard)
                    .HasColumnName("SIMCARD")
                    .HasMaxLength(255);

                entity.HasOne(d => d.HistorySimgpsGpsNavigation)
                    .WithMany(p => p.HistorySimgpsSet)
                    .HasForeignKey(d => d.HistorySimgpsGps)
                    .HasConstraintName("HistorySIMGps_Gps");
            });

            modelBuilder.Entity<HistoryTags>(entity =>
            {
                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.ActivationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.HistoryTagEmployee).HasColumnName("HistoryTag_Employee");

                entity.Property(e => e.HistoryTagGasStation).HasColumnName("HistoryTag_GasStation");

                entity.Property(e => e.HistoryTagReplacementReason).HasColumnName("HistoryTag_ReplacementReason");

                entity.Property(e => e.HistoryTagTagType).HasColumnName("HistoryTag_TagType");

                entity.Property(e => e.HistoryTagTankIdentifier).HasColumnName("HistoryTag_TankIdentifier");

                entity.Property(e => e.HistoryTagTreatmentType).HasColumnName("HistoryTag_TreatmentType");

                entity.Property(e => e.HistoryTagVehicle).HasColumnName("HistoryTag_Vehicle");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SerialMeter).HasMaxLength(255);

                entity.Property(e => e.ServiceDataTime).HasColumnType("datetime");

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("SID")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(255);

                entity.Property(e => e.WithNth).HasColumnName("WithNTH");

                entity.HasOne(d => d.HistoryTagEmployeeNavigation)
                    .WithMany(p => p.HistoryTags)
                    .HasForeignKey(d => d.HistoryTagEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HistoryTag_Employee");

                entity.HasOne(d => d.HistoryTagGasStationNavigation)
                    .WithMany(p => p.HistoryTags)
                    .HasForeignKey(d => d.HistoryTagGasStation)
                    .HasConstraintName("HistoryTag_GasStation");

                entity.HasOne(d => d.HistoryTagReplacementReasonNavigation)
                    .WithMany(p => p.HistoryTags)
                    .HasForeignKey(d => d.HistoryTagReplacementReason)
                    .HasConstraintName("HistoryTag_ReplacementReason");

                entity.HasOne(d => d.HistoryTagTagTypeNavigation)
                    .WithMany(p => p.HistoryTags)
                    .HasForeignKey(d => d.HistoryTagTagType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HistoryTag_TagType");

                entity.HasOne(d => d.HistoryTagTankIdentifierNavigation)
                    .WithMany(p => p.HistoryTags)
                    .HasForeignKey(d => d.HistoryTagTankIdentifier)
                    .HasConstraintName("HistoryTag_TankIdentifier");

                entity.HasOne(d => d.HistoryTagTreatmentTypeNavigation)
                    .WithMany(p => p.HistoryTags)
                    .HasForeignKey(d => d.HistoryTagTreatmentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("HistoryTag_TreatmentType");

                entity.HasOne(d => d.HistoryTagVehicleNavigation)
                    .WithMany(p => p.HistoryTags)
                    .HasForeignKey(d => d.HistoryTagVehicle)
                    .HasConstraintName("HistoryTag_Vehicle");
            });

            modelBuilder.Entity<HistoryTankVehicleSet>(entity =>
            {
                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.HistoryTankVehicleTankIdentifier).HasColumnName("HistoryTankVehicle_TankIdentifier");

                entity.Property(e => e.HistoryTankVehicleVehicle).HasColumnName("HistoryTankVehicle_Vehicle");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.HistoryTankVehicleTankIdentifierNavigation)
                    .WithMany(p => p.HistoryTankVehicleSet)
                    .HasForeignKey(d => d.HistoryTankVehicleTankIdentifier)
                    .HasConstraintName("HistoryTankVehicle_TankIdentifier");

                entity.HasOne(d => d.HistoryTankVehicleVehicleNavigation)
                    .WithMany(p => p.HistoryTankVehicleSet)
                    .HasForeignKey(d => d.HistoryTankVehicleVehicle)
                    .HasConstraintName("HistoryTankVehicle_Vehicle");
            });

            modelBuilder.Entity<HistoryVehiclesSet>(entity =>
            {
                entity.Property(e => e.ActionTransac).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExtraordinaryDatetime).HasColumnType("datetime");

                entity.Property(e => e.HelpComentsTicket).HasMaxLength(255);

                entity.Property(e => e.HelpNameEmployee).HasMaxLength(255);

                entity.Property(e => e.HistoryVehiclesBrandModel).HasColumnName("HistoryVehicles_BrandModel");

                entity.Property(e => e.HistoryVehiclesClient).HasColumnName("HistoryVehicles_Client");

                entity.Property(e => e.HistoryVehiclesCostCenter).HasColumnName("HistoryVehicles_CostCenter");

                entity.Property(e => e.HistoryVehiclesFuelType).HasColumnName("HistoryVehicles_FuelType");

                entity.Property(e => e.HistoryVehiclesRules).HasColumnName("HistoryVehicles_Rules");

                entity.Property(e => e.HistoryVehiclesStatus).HasColumnName("HistoryVehicles_Status");

                entity.Property(e => e.HistoryVehiclesVehicleBrand).HasColumnName("HistoryVehicles_VehicleBrand");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NumTransactionExternal).HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PublicId).HasColumnName("PublicID");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SearchProperty1).HasMaxLength(255);

                entity.Property(e => e.SearchProperty2).HasMaxLength(255);

                entity.Property(e => e.SingleEventDatetimeEnd).HasColumnType("datetime");

                entity.Property(e => e.SingleEventDatetimeStart).HasColumnType("datetime");

                entity.Property(e => e.SingleEventFuelType).HasMaxLength(255);

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WithTempValuesDate).HasColumnType("datetime");

                entity.HasOne(d => d.HistoryVehiclesBrandModelNavigation)
                    .WithMany(p => p.HistoryVehiclesSet)
                    .HasForeignKey(d => d.HistoryVehiclesBrandModel)
                    .HasConstraintName("HistoryVehicles_BrandModel");

                entity.HasOne(d => d.HistoryVehiclesClientNavigation)
                    .WithMany(p => p.HistoryVehiclesSet)
                    .HasForeignKey(d => d.HistoryVehiclesClient)
                    .HasConstraintName("HistoryVehicles_Client");

                entity.HasOne(d => d.HistoryVehiclesCostCenterNavigation)
                    .WithMany(p => p.HistoryVehiclesSet)
                    .HasForeignKey(d => d.HistoryVehiclesCostCenter)
                    .HasConstraintName("HistoryVehicles_CostCenter");

                entity.HasOne(d => d.HistoryVehiclesFuelTypeNavigation)
                    .WithMany(p => p.HistoryVehiclesSet)
                    .HasForeignKey(d => d.HistoryVehiclesFuelType)
                    .HasConstraintName("HistoryVehicles_FuelType");

                entity.HasOne(d => d.HistoryVehiclesRulesNavigation)
                    .WithMany(p => p.HistoryVehiclesSet)
                    .HasForeignKey(d => d.HistoryVehiclesRules)
                    .HasConstraintName("HistoryVehicles_Rules");

                entity.HasOne(d => d.HistoryVehiclesStatusNavigation)
                    .WithMany(p => p.HistoryVehiclesSet)
                    .HasForeignKey(d => d.HistoryVehiclesStatus)
                    .HasConstraintName("HistoryVehicles_Status");

                entity.HasOne(d => d.HistoryVehiclesVehicleBrandNavigation)
                    .WithMany(p => p.HistoryVehiclesSet)
                    .HasForeignKey(d => d.HistoryVehiclesVehicleBrand)
                    .HasConstraintName("HistoryVehicles_VehicleBrand");
            });

            modelBuilder.Entity<HorarySet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.HoraryRules).HasColumnName("Horary_Rules");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TimeEnd)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStart)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.HoraryRulesNavigation)
                    .WithMany(p => p.HorarySet)
                    .HasForeignKey(d => d.HoraryRules)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Horary_Rules");
            });

            modelBuilder.Entity<Iepsset>(entity =>
            {
                entity.ToTable("IEPSSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DataTimeEnd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataTimeStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IepsFuelType).HasColumnName("IEPS_FuelType");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tax).HasColumnType("decimal(6, 4)");

                entity.HasOne(d => d.IepsFuelTypeNavigation)
                    .WithMany(p => p.Iepsset)
                    .HasForeignKey(d => d.IepsFuelType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("IEPS_FuelType");
            });

            modelBuilder.Entity<ImageInstallationSet>(entity =>
            {
                entity.Property(e => e.AccesoriesImageInstallation).HasColumnName("Accesories_ImageInstallation");

                entity.Property(e => e.AccesoriesImageInstallation1).HasColumnName("Accesories_ImageInstallation1");

                entity.Property(e => e.AntennaImageInstallation).HasColumnName("Antenna_ImageInstallation");

                entity.Property(e => e.BatteryImageInstallation).HasColumnName("Battery_ImageInstallation");

                entity.Property(e => e.ChangeRequestPlateImageInstallation).HasColumnName("ChangeRequestPlate_ImageInstallation");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.GasStationExtraActivitiesImageInstallation).HasColumnName("GasStationExtraActivities_ImageInstallation");

                entity.Property(e => e.GpsImageInstallation).HasColumnName("Gps_ImageInstallation");

                entity.Property(e => e.GpsImageInstallation1).HasColumnName("Gps_ImageInstallation1");

                entity.Property(e => e.ImageInstallationBattery).HasColumnName("ImageInstallation_Battery");

                entity.Property(e => e.ImageInstallationGasStation).HasColumnName("ImageInstallation_GasStation");

                entity.Property(e => e.ImageInstallationVehicle).HasColumnName("ImageInstallation_Vehicle");

                entity.Property(e => e.ImageInstaller)
                    .IsRequired()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MeterImageInstallation).HasColumnName("Meter_ImageInstallation");

                entity.Property(e => e.MeterImageInstallation1).HasColumnName("Meter_ImageInstallation1");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ReaderImageInstallation).HasColumnName("Reader_ImageInstallation");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TagImageTag).HasColumnName("Tag_ImageTag");

                entity.Property(e => e.TagImageTag1).HasColumnName("Tag_ImageTag1");

                entity.HasOne(d => d.AccesoriesImageInstallationNavigation)
                    .WithMany(p => p.ImageInstallationSetAccesoriesImageInstallationNavigation)
                    .HasForeignKey(d => d.AccesoriesImageInstallation)
                    .HasConstraintName("Accesories_ImageInstallation");

                entity.HasOne(d => d.AccesoriesImageInstallation1Navigation)
                    .WithMany(p => p.ImageInstallationSetAccesoriesImageInstallation1Navigation)
                    .HasForeignKey(d => d.AccesoriesImageInstallation1)
                    .HasConstraintName("Accesories_ImageInstallation1");

                entity.HasOne(d => d.AntennaImageInstallationNavigation)
                    .WithMany(p => p.ImageInstallationSet)
                    .HasForeignKey(d => d.AntennaImageInstallation)
                    .HasConstraintName("Antenna_ImageInstallation");

                entity.HasOne(d => d.BatteryImageInstallationNavigation)
                    .WithMany(p => p.ImageInstallationSetBatteryImageInstallationNavigation)
                    .HasForeignKey(d => d.BatteryImageInstallation)
                    .HasConstraintName("Battery_ImageInstallation");

                entity.HasOne(d => d.ChangeRequestPlateImageInstallationNavigation)
                    .WithMany(p => p.ImageInstallationSet)
                    .HasForeignKey(d => d.ChangeRequestPlateImageInstallation)
                    .HasConstraintName("ChangeRequestPlate_ImageInstallation");

                entity.HasOne(d => d.GasStationExtraActivitiesImageInstallationNavigation)
                    .WithMany(p => p.ImageInstallationSet)
                    .HasForeignKey(d => d.GasStationExtraActivitiesImageInstallation)
                    .HasConstraintName("GasStationExtraActivities_ImageInstallation");

                entity.HasOne(d => d.GpsImageInstallationNavigation)
                    .WithMany(p => p.ImageInstallationSetGpsImageInstallationNavigation)
                    .HasForeignKey(d => d.GpsImageInstallation)
                    .HasConstraintName("Gps_ImageInstallation");

                entity.HasOne(d => d.GpsImageInstallation1Navigation)
                    .WithMany(p => p.ImageInstallationSetGpsImageInstallation1Navigation)
                    .HasForeignKey(d => d.GpsImageInstallation1)
                    .HasConstraintName("Gps_ImageInstallation1");

                entity.HasOne(d => d.ImageInstallationBatteryNavigation)
                    .WithMany(p => p.ImageInstallationSetImageInstallationBatteryNavigation)
                    .HasForeignKey(d => d.ImageInstallationBattery)
                    .HasConstraintName("ImageInstallation_Battery");

                entity.HasOne(d => d.ImageInstallationGasStationNavigation)
                    .WithMany(p => p.ImageInstallationSet)
                    .HasForeignKey(d => d.ImageInstallationGasStation)
                    .HasConstraintName("ImageInstallation_GasStation");

                entity.HasOne(d => d.ImageInstallationVehicleNavigation)
                    .WithMany(p => p.ImageInstallationSet)
                    .HasForeignKey(d => d.ImageInstallationVehicle)
                    .HasConstraintName("ImageInstallation_Vehicle");

                entity.HasOne(d => d.MeterImageInstallationNavigation)
                    .WithMany(p => p.ImageInstallationSetMeterImageInstallationNavigation)
                    .HasForeignKey(d => d.MeterImageInstallation)
                    .HasConstraintName("Meter_ImageInstallation");

                entity.HasOne(d => d.MeterImageInstallation1Navigation)
                    .WithMany(p => p.ImageInstallationSetMeterImageInstallation1Navigation)
                    .HasForeignKey(d => d.MeterImageInstallation1)
                    .HasConstraintName("Meter_ImageInstallation1");

                entity.HasOne(d => d.ReaderImageInstallationNavigation)
                    .WithMany(p => p.ImageInstallationSet)
                    .HasForeignKey(d => d.ReaderImageInstallation)
                    .HasConstraintName("Reader_ImageInstallation");

                entity.HasOne(d => d.TagImageTagNavigation)
                    .WithMany(p => p.ImageInstallationSetTagImageTagNavigation)
                    .HasForeignKey(d => d.TagImageTag)
                    .HasConstraintName("Tag_ImageInstallation");

                entity.HasOne(d => d.TagImageTag1Navigation)
                    .WithMany(p => p.ImageInstallationSetTagImageTag1Navigation)
                    .HasForeignKey(d => d.TagImageTag1)
                    .HasConstraintName("Tag_ImageInstallation1");
            });

            modelBuilder.Entity<ImpuestoSet>(entity =>
            {
                entity.Property(e => e.CImpuesto)
                    .IsRequired()
                    .HasColumnName("c_Impuesto")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TasaCuota).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ImpuestoTrasladadoEdcset>(entity =>
            {
                entity.ToTable("ImpuestoTrasladadoEDCSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TotalImpuestoTraladados).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<ImpuetosTrasladadosEdeset>(entity =>
            {
                entity.ToTable("ImpuetosTrasladadosEDESet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TotalImpuestosTrasladados).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<InventaryTagSet>(entity =>
            {
                entity.HasIndex(e => e.Serial)
                    .HasName("UQ__Inventar__1A00E093497C6908")
                    .IsUnique();

                entity.HasIndex(e => e.Sid)
                    .HasName("UQ__Inventar__CA195971A3EF2768")
                    .IsUnique();

                entity.HasIndex(e => e.Uuid)
                    .HasName("UQ__Inventar__65A475E6585DE981")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.InventaryTagEmployee).HasColumnName("InventaryTag_Employee");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sid)
                    .HasColumnName("SID")
                    .HasMaxLength(255);

                entity.Property(e => e.Uuid)
                    .HasColumnName("UUID")
                    .HasMaxLength(255);

                entity.HasOne(d => d.InventaryTagEmployeeNavigation)
                    .WithMany(p => p.InventaryTagSet)
                    .HasForeignKey(d => d.InventaryTagEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("InventaryTag_Employee");
            });

            modelBuilder.Entity<LaboratoryDiagnosticBatterySet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Diagnostic)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<LaboratoryDiagnosticGrtset>(entity =>
            {
                entity.ToTable("LaboratoryDiagnosticGRTSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Diagnostic)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<LaboratoryDiagnosticPowerSupplySet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Diagnostic)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<LaboratoryDiagnosticReaderSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Diagnostic)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<LocalidadSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CveLoc)
                    .IsRequired()
                    .HasColumnName("Cve_Loc")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocalidadCity).HasColumnName("Localidad_City");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.LocalidadCityNavigation)
                    .WithMany(p => p.LocalidadSet)
                    .HasForeignKey(d => d.LocalidadCity)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Localidad_City");
            });

            modelBuilder.Entity<MailsEnvioEdset>(entity =>
            {
                entity.ToTable("MailsEnvioEDSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MailsEnvioEdConfiguracionEd).HasColumnName("MailsEnvioED_ConfiguracionED");

                entity.Property(e => e.MailsEnvioEdRelacionEdccliente).HasColumnName("MailsEnvioED_RelacionEDCCliente");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MailsEnvioEdConfiguracionEdNavigation)
                    .WithMany(p => p.MailsEnvioEdset)
                    .HasForeignKey(d => d.MailsEnvioEdConfiguracionEd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MailsEnvioED_ConfiguracionED");

                entity.HasOne(d => d.MailsEnvioEdRelacionEdcclienteNavigation)
                    .WithMany(p => p.MailsEnvioEdset)
                    .HasForeignKey(d => d.MailsEnvioEdRelacionEdccliente)
                    .HasConstraintName("MailsEnvioED_RelacionEDCCliente");
            });

            modelBuilder.Entity<MailsEnvioSaldosSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SaldosLimitConfigMailsEnvioSaldos).HasColumnName("SaldosLimitConfig_MailsEnvioSaldos");

                entity.HasOne(d => d.SaldosLimitConfigMailsEnvioSaldosNavigation)
                    .WithMany(p => p.MailsEnvioSaldosSet)
                    .HasForeignKey(d => d.SaldosLimitConfigMailsEnvioSaldos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SaldosLimitConfig_MailsEnvioSaldos");
            });

            modelBuilder.Entity<MalfunctionAntennas>(entity =>
            {
                entity.ToTable("Malfunction_Antennas");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IsAviManagerServiceOk).HasColumnName("IsAviManagerServiceOK");

                entity.Property(e => e.IsSgpsHasTheRightForecourtIp).HasColumnName("IsSgpsHasTheRightForecourtIP");

                entity.Property(e => e.MalfunctionAntennaAntenna).HasColumnName("Malfunction_Antenna_Antenna");

                entity.Property(e => e.MalfunctionReportMalfunctionAntenna).HasColumnName("MalfunctionReport_Malfunction_Antenna");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MalfunctionAntennaAntennaNavigation)
                    .WithMany(p => p.MalfunctionAntennas)
                    .HasForeignKey(d => d.MalfunctionAntennaAntenna)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Malfunction_Antenna_Antenna");

                entity.HasOne(d => d.MalfunctionReportMalfunctionAntennaNavigation)
                    .WithMany(p => p.MalfunctionAntennas)
                    .HasForeignKey(d => d.MalfunctionReportMalfunctionAntenna)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MalfunctionReport_Malfunction_Antenna");
            });

            modelBuilder.Entity<MalfunctionCgs>(entity =>
            {
                entity.ToTable("Malfunction_CGs");

                entity.Property(e => e.CgVersion).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.MalfunctionReportMalfunctionCg).HasColumnName("MalfunctionReport_Malfunction_CG");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SgpmLastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.SgpmVersion).HasMaxLength(255);

                entity.Property(e => e.SgpsLastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.SgpsVersion).HasMaxLength(255);

                entity.HasOne(d => d.MalfunctionReportMalfunctionCgNavigation)
                    .WithMany(p => p.MalfunctionCgs)
                    .HasForeignKey(d => d.MalfunctionReportMalfunctionCg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MalfunctionReport_Malfunction_CG");
            });

            modelBuilder.Entity<MalfunctionConnections>(entity =>
            {
                entity.ToTable("Malfunction_Connections");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IsInternetOk).HasColumnName("IsInternetOK");

                entity.Property(e => e.MalfunctionReportMalfunctionConnection).HasColumnName("MalfunctionReport_Malfunction_Connection");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MalfunctionReportMalfunctionConnectionNavigation)
                    .WithMany(p => p.MalfunctionConnections)
                    .HasForeignKey(d => d.MalfunctionReportMalfunctionConnection)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MalfunctionReport_Malfunction_Connection");
            });

            modelBuilder.Entity<MalfunctionFleets>(entity =>
            {
                entity.ToTable("Malfunction_Fleets");

                entity.Property(e => e.AreRulesOk).HasColumnName("AreRulesOK");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IsBalanceOk).HasColumnName("IsBalanceOK");

                entity.Property(e => e.MalfunctionReportMalfunctionFleet).HasColumnName("MalfunctionReport_Malfunction_Fleet");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MalfunctionReportMalfunctionFleetNavigation)
                    .WithMany(p => p.MalfunctionFleets)
                    .HasForeignKey(d => d.MalfunctionReportMalfunctionFleet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MalfunctionReport_Malfunction_Fleet");
            });

            modelBuilder.Entity<MalfunctionReaders>(entity =>
            {
                entity.ToTable("Malfunction_Readers");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.MalfunctionReaderReader).HasColumnName("Malfunction_Reader_Reader");

                entity.Property(e => e.MalfunctionReaderReaderStatus).HasColumnName("Malfunction_Reader_ReaderStatus");

                entity.Property(e => e.MalfunctionReportMalfunctionReader).HasColumnName("MalfunctionReport_Malfunction_Reader");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MalfunctionReaderReaderNavigation)
                    .WithMany(p => p.MalfunctionReaders)
                    .HasForeignKey(d => d.MalfunctionReaderReader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Malfunction_Reader_Reader");

                entity.HasOne(d => d.MalfunctionReaderReaderStatusNavigation)
                    .WithMany(p => p.MalfunctionReaders)
                    .HasForeignKey(d => d.MalfunctionReaderReaderStatus)
                    .HasConstraintName("Malfunction_Reader_ReaderStatus");

                entity.HasOne(d => d.MalfunctionReportMalfunctionReaderNavigation)
                    .WithMany(p => p.MalfunctionReaders)
                    .HasForeignKey(d => d.MalfunctionReportMalfunctionReader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MalfunctionReport_Malfunction_Reader");
            });

            modelBuilder.Entity<MalfunctionReports>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.MalfunctionReportDepartment).HasColumnName("MalfunctionReport_Department");

                entity.Property(e => e.MalfunctionReportDriver).HasColumnName("MalfunctionReport_Driver");

                entity.Property(e => e.MalfunctionReportGasStation).HasColumnName("MalfunctionReport_GasStation");

                entity.Property(e => e.MalfunctionReportVehicle).HasColumnName("MalfunctionReport_Vehicle");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MalfunctionReportDepartmentNavigation)
                    .WithMany(p => p.MalfunctionReports)
                    .HasForeignKey(d => d.MalfunctionReportDepartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MalfunctionReport_Department");

                entity.HasOne(d => d.MalfunctionReportDriverNavigation)
                    .WithMany(p => p.MalfunctionReports)
                    .HasForeignKey(d => d.MalfunctionReportDriver)
                    .HasConstraintName("MalfunctionReport_Driver");

                entity.HasOne(d => d.MalfunctionReportGasStationNavigation)
                    .WithMany(p => p.MalfunctionReports)
                    .HasForeignKey(d => d.MalfunctionReportGasStation)
                    .HasConstraintName("MalfunctionReport_GasStation");

                entity.HasOne(d => d.MalfunctionReportVehicleNavigation)
                    .WithMany(p => p.MalfunctionReports)
                    .HasForeignKey(d => d.MalfunctionReportVehicle)
                    .HasConstraintName("MalfunctionReport_Vehicle");
            });

            modelBuilder.Entity<MalfunctionStationProblems>(entity =>
            {
                entity.ToTable("Malfunction_StationProblems");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IsElectricityOk).HasColumnName("IsElectricityOK");

                entity.Property(e => e.IsPosOk).HasColumnName("IsPosOK");

                entity.Property(e => e.IsProfecoOk).HasColumnName("IsProfecoOK");

                entity.Property(e => e.MalfunctionReportMalfunctionStationProblem).HasColumnName("MalfunctionReport_Malfunction_StationProblem");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MalfunctionReportMalfunctionStationProblemNavigation)
                    .WithMany(p => p.MalfunctionStationProblems)
                    .HasForeignKey(d => d.MalfunctionReportMalfunctionStationProblem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MalfunctionReport_Malfunction_StationProblem");
            });

            modelBuilder.Entity<MalfunctionTags>(entity =>
            {
                entity.ToTable("Malfunction_Tags");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.IsRingLooksOk).HasColumnName("IsRingLooksOK");

                entity.Property(e => e.MalfunctionReportMalfunctionTag).HasColumnName("MalfunctionReport_Malfunction_Tag");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MalfunctionReportMalfunctionTagNavigation)
                    .WithMany(p => p.MalfunctionTags)
                    .HasForeignKey(d => d.MalfunctionReportMalfunctionTag)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MalfunctionReport_Malfunction_Tag");
            });

            modelBuilder.Entity<MalfunctionTrainings>(entity =>
            {
                entity.ToTable("Malfunction_Trainings");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.MalfunctionReportMalfunctionTraining).HasColumnName("MalfunctionReport_Malfunction_Training");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MalfunctionReportMalfunctionTrainingNavigation)
                    .WithMany(p => p.MalfunctionTrainings)
                    .HasForeignKey(d => d.MalfunctionReportMalfunctionTraining)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MalfunctionReport_Malfunction_Training");
            });

            modelBuilder.Entity<MessageErrorSet>(entity =>
            {
                entity.HasIndex(e => e.IdError)
                    .HasName("UQ__MessageE__C8A4CFD8FE4331FD")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<MeterTypes>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Meters>(entity =>
            {
                entity.HasIndex(e => e.Serial)
                    .HasName("UQ__tmp_ms_x__1A00E09326F6FD2B")
                    .IsUnique();

                entity.Property(e => e.ActivationDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Connector).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.MeterEmployee).HasColumnName("Meter_Employee");

                entity.Property(e => e.MeterMeterType).HasColumnName("Meter_MeterType");

                entity.Property(e => e.MeterReplacementReason).HasColumnName("Meter_ReplacementReason");

                entity.Property(e => e.MeterTreatmentType).HasColumnName("Meter_TreatmentType");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProductsMeter).HasColumnName("Products_Meter");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ServiceDataTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VehicleMeter).HasColumnName("Vehicle_Meter");

                entity.HasOne(d => d.MeterEmployeeNavigation)
                    .WithMany(p => p.Meters)
                    .HasForeignKey(d => d.MeterEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Meter_Employee");

                entity.HasOne(d => d.MeterMeterTypeNavigation)
                    .WithMany(p => p.Meters)
                    .HasForeignKey(d => d.MeterMeterType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Meter_MeterType");

                entity.HasOne(d => d.MeterReplacementReasonNavigation)
                    .WithMany(p => p.Meters)
                    .HasForeignKey(d => d.MeterReplacementReason)
                    .HasConstraintName("Meter_ReplacementReason");

                entity.HasOne(d => d.MeterTreatmentTypeNavigation)
                    .WithMany(p => p.Meters)
                    .HasForeignKey(d => d.MeterTreatmentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Meter_TreatmentType");

                entity.HasOne(d => d.ProductsMeterNavigation)
                    .WithMany(p => p.Meters)
                    .HasForeignKey(d => d.ProductsMeter)
                    .HasConstraintName("Products_Meter");

                entity.HasOne(d => d.VehicleMeterNavigation)
                    .WithMany(p => p.Meters)
                    .HasForeignKey(d => d.VehicleMeter)
                    .HasConstraintName("Vehicle_Meter");
            });

            modelBuilder.Entity<MetodoDePagoSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(180)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<MunicipioSet>(entity =>
            {
                entity.Property(e => e.CityMunicipio).HasColumnName("City_Municipio");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CveMun)
                    .IsRequired()
                    .HasColumnName("Cve_Mun")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CityMunicipioNavigation)
                    .WithMany(p => p.MunicipioSet)
                    .HasForeignKey(d => d.CityMunicipio)
                    .HasConstraintName("City_Municipio");
            });

            modelBuilder.Entity<NipsSet>(entity =>
            {
                entity.ToTable("NIPsSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DriverName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Nip)
                    .IsRequired()
                    .HasColumnName("NIP")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NipsTag).HasColumnName("NIPs_Tag");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.NipsTagNavigation)
                    .WithMany(p => p.NipsSet)
                    .HasForeignKey(d => d.NipsTag)
                    .HasConstraintName("NIPs_Tag");
            });

            modelBuilder.Entity<NozzleTypes>(entity =>
            {
                entity.HasIndex(e => e.Model)
                    .HasName("UQ__tmp_ms_x__FB104C13D768436E")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<OdometerTypes>(entity =>
            {
                entity.HasIndex(e => e.Type)
                    .HasName("UQ__Odometer__F9B8A48B2F0B1430")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<OdometerUnits>(entity =>
            {
                entity.HasIndex(e => e.Unit)
                    .HasName("UQ__Odometer__5EF93412D139C8F2")
                    .IsUnique();

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<OfflineAccessSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationSync).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OfflineAccessEmployee).HasColumnName("OfflineAccess_Employee");

                entity.Property(e => e.OfflineSyncStatusOfflineAccess).HasColumnName("OfflineSyncStatus_OfflineAccess");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.OfflineAccessEmployeeNavigation)
                    .WithMany(p => p.OfflineAccessSet)
                    .HasForeignKey(d => d.OfflineAccessEmployee)
                    .HasConstraintName("OfflineAccess_Employee");

                entity.HasOne(d => d.OfflineSyncStatusOfflineAccessNavigation)
                    .WithMany(p => p.OfflineAccessSet)
                    .HasForeignKey(d => d.OfflineSyncStatusOfflineAccess)
                    .HasConstraintName("OfflineSyncStatus_OfflineAccess");
            });

            modelBuilder.Entity<OfflineSyncStatusSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<OrderOfServiceSet>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OrderOfServiceAppointmentService).HasColumnName("OrderOfService_AppointmentService");

                entity.Property(e => e.OrderOfServiceEmployee).HasColumnName("OrderOfService_Employee");

                entity.Property(e => e.OrderOfServiceEmployee1).HasColumnName("OrderOfService_Employee1");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StatusOrderOrderOfService).HasColumnName("StatusOrder_OrderOfService");

                entity.Property(e => e.TypeOfServiceByAreaOrderOfService).HasColumnName("TypeOfServiceByArea_OrderOfService");

                entity.HasOne(d => d.OrderOfServiceAppointmentServiceNavigation)
                    .WithMany(p => p.OrderOfServiceSet)
                    .HasForeignKey(d => d.OrderOfServiceAppointmentService)
                    .HasConstraintName("OrderOfService_AppointmentService");

                entity.HasOne(d => d.OrderOfServiceEmployeeNavigation)
                    .WithMany(p => p.OrderOfServiceSetOrderOfServiceEmployeeNavigation)
                    .HasForeignKey(d => d.OrderOfServiceEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderOfService_Employee");

                entity.HasOne(d => d.OrderOfServiceEmployee1Navigation)
                    .WithMany(p => p.OrderOfServiceSetOrderOfServiceEmployee1Navigation)
                    .HasForeignKey(d => d.OrderOfServiceEmployee1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderOfService_Employee1");

                entity.HasOne(d => d.StatusOrderOrderOfServiceNavigation)
                    .WithMany(p => p.OrderOfServiceSet)
                    .HasForeignKey(d => d.StatusOrderOrderOfService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("StatusOrder_OrderOfService");

                entity.HasOne(d => d.TypeOfServiceByAreaOrderOfServiceNavigation)
                    .WithMany(p => p.OrderOfServiceSet)
                    .HasForeignKey(d => d.TypeOfServiceByAreaOrderOfService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TypeOfServiceByArea_OrderOfService");
            });

            modelBuilder.Entity<PagosEstacionSet>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Comentarios).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FechaAplicacion).HasColumnType("datetime");

                entity.Property(e => e.FechaPago)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NumeroTransferencia)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PagosEstacionAccountGng).HasColumnName("PagosEstacion_AccountGng");

                entity.Property(e => e.PagosEstacionBilling).HasColumnName("PagosEstacion_BIlling");

                entity.Property(e => e.PagosEstacionEmployee).HasColumnName("PagosEstacion_Employee");

                entity.Property(e => e.PagosEstacionGasStation).HasColumnName("PagosEstacion_GasStation");

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.PagosEstacionAccountGngNavigation)
                    .WithMany(p => p.PagosEstacionSet)
                    .HasForeignKey(d => d.PagosEstacionAccountGng)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PagosEstacion_AccountGng");

                entity.HasOne(d => d.PagosEstacionBillingNavigation)
                    .WithMany(p => p.PagosEstacionSet)
                    .HasForeignKey(d => d.PagosEstacionBilling)
                    .HasConstraintName("PagosEstacion_BIlling");

                entity.HasOne(d => d.PagosEstacionEmployeeNavigation)
                    .WithMany(p => p.PagosEstacionSet)
                    .HasForeignKey(d => d.PagosEstacionEmployee)
                    .HasConstraintName("PagosEstacion_Employee");

                entity.HasOne(d => d.PagosEstacionGasStationNavigation)
                    .WithMany(p => p.PagosEstacionSet)
                    .HasForeignKey(d => d.PagosEstacionGasStation)
                    .HasConstraintName("PagosEstacion_GasStation");
            });

            modelBuilder.Entity<PcOsVersions>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PermissionsWebSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PermissionsWebRolesWeb).HasColumnName("PermissionsWeb_RolesWeb");

                entity.Property(e => e.PermissionsWebViewsWeb).HasColumnName("PermissionsWeb_ViewsWeb");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.PermissionsWebRolesWebNavigation)
                    .WithMany(p => p.PermissionsWebSet)
                    .HasForeignKey(d => d.PermissionsWebRolesWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PermissionsWeb_RolesWeb");

                entity.HasOne(d => d.PermissionsWebViewsWebNavigation)
                    .WithMany(p => p.PermissionsWebSet)
                    .HasForeignKey(d => d.PermissionsWebViewsWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PermissionsWeb_ViewsWeb");
            });

            modelBuilder.Entity<PowerSupplyFailureSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DescriptionFailure)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<PriceFuelSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Iesp)
                    .HasColumnName("IESP")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceFuelFuel).HasColumnName("PriceFuel_Fuel");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.PriceFuelFuelNavigation)
                    .WithMany(p => p.PriceFuelSet)
                    .HasForeignKey(d => d.PriceFuelFuel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PriceFuel_Fuel");
            });

            modelBuilder.Entity<ProductCodeSet>(entity =>
            {
                entity.Property(e => e.CatCombustibleProductCode).HasColumnName("catCombustible_ProductCode");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductCodeClaveProdServ).HasColumnName("ProductCode_ClaveProdServ");

                entity.Property(e => e.ProductCodeFuelType).HasColumnName("ProductCode_FuelType");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CatCombustibleProductCodeNavigation)
                    .WithMany(p => p.ProductCodeSet)
                    .HasForeignKey(d => d.CatCombustibleProductCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("catCombustible_ProductCode");

                entity.HasOne(d => d.ProductCodeClaveProdServNavigation)
                    .WithMany(p => p.ProductCodeSet)
                    .HasForeignKey(d => d.ProductCodeClaveProdServ)
                    .HasConstraintName("ProductCode_ClaveProdServ");

                entity.HasOne(d => d.ProductCodeFuelTypeNavigation)
                    .WithMany(p => p.ProductCodeSet)
                    .HasForeignKey(d => d.ProductCodeFuelType)
                    .HasConstraintName("ProductCode_FuelType");
            });

            modelBuilder.Entity<ProductSectionSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ProductsSet>(entity =>
            {
                entity.Property(e => e.CodProd)
                    .IsRequired()
                    .HasColumnName("codProd")
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProductSectionProducts).HasColumnName("ProductSection_Products");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Unidad).HasMaxLength(6);

                entity.HasOne(d => d.ProductSectionProductsNavigation)
                    .WithMany(p => p.ProductsSet)
                    .HasForeignKey(d => d.ProductSectionProducts)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("ProductSection_Products");
            });

            modelBuilder.Entity<ProfileInClientGroupSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProfileInClientGroupClientGroup).HasColumnName("ProfileInClientGroup_ClientGroup");

                entity.Property(e => e.ProfileInClientGroupGasStationGroup).HasColumnName("ProfileInClientGroup_GasStationGroup");

                entity.Property(e => e.ProfileInClientGroupProfile).HasColumnName("ProfileInClientGroup_Profile");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ProfileInClientGroupClientGroupNavigation)
                    .WithMany(p => p.ProfileInClientGroupSet)
                    .HasForeignKey(d => d.ProfileInClientGroupClientGroup)
                    .HasConstraintName("ProfileInClientGroup_ClientGroup");

                entity.HasOne(d => d.ProfileInClientGroupGasStationGroupNavigation)
                    .WithMany(p => p.ProfileInClientGroupSet)
                    .HasForeignKey(d => d.ProfileInClientGroupGasStationGroup)
                    .HasConstraintName("ProfileInClientGroup_GasStationGroup");

                entity.HasOne(d => d.ProfileInClientGroupProfileNavigation)
                    .WithMany(p => p.ProfileInClientGroupSet)
                    .HasForeignKey(d => d.ProfileInClientGroupProfile)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ProfileInClientGroup_Profile");
            });

            modelBuilder.Entity<ProfileInClientSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProfileClientGroupProfileInClient).HasColumnName("ProfileClientGroup_ProfileInClient");

                entity.Property(e => e.ProfileInClientClient).HasColumnName("ProfileInClient_Client");

                entity.Property(e => e.ProfileInClientGasStation).HasColumnName("ProfileInClient_GasStation");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ProfileClientGroupProfileInClientNavigation)
                    .WithMany(p => p.ProfileInClientSet)
                    .HasForeignKey(d => d.ProfileClientGroupProfileInClient)
                    .HasConstraintName("Profile_ProfileInClient");

                entity.HasOne(d => d.ProfileInClientClientNavigation)
                    .WithMany(p => p.ProfileInClientSet)
                    .HasForeignKey(d => d.ProfileInClientClient)
                    .HasConstraintName("ProfileInClient_Client");

                entity.HasOne(d => d.ProfileInClientGasStationNavigation)
                    .WithMany(p => p.ProfileInClientSet)
                    .HasForeignKey(d => d.ProfileInClientGasStation)
                    .HasConstraintName("ProfileInClient_GasStation");
            });

            modelBuilder.Entity<ProfileSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProfileUserWeb).HasColumnName("Profile_UserWeb");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ProfileUserWebNavigation)
                    .WithMany(p => p.ProfileSet)
                    .HasForeignKey(d => d.ProfileUserWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Profile_UserWeb");
            });

            modelBuilder.Entity<PumpControllers>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Version).HasMaxLength(255);
            });

            modelBuilder.Entity<PumpTypeSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<QlikViewReportsSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<RePrintTargetReasonSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ReaderFailureSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DescriptionFailure)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ReaderStatuses>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ReaderTypeSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Readers>(entity =>
            {
                entity.HasIndex(e => e.Serial)
                    .HasName("UQ__tmp_ms_x__1A00E0934E60DCCC")
                    .IsUnique();

                entity.Property(e => e.ActivationDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AntennaReader).HasColumnName("Antenna_Reader");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.GasStationReader).HasColumnName("GasStation_Reader");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProductsReader1).HasColumnName("Products_Reader1");

                entity.Property(e => e.ReaderFuelType).HasColumnName("Reader_FuelType");

                entity.Property(e => e.ReaderNozzle).HasColumnName("Reader_Nozzle");

                entity.Property(e => e.ReaderReplacementReason).HasColumnName("Reader_ReplacementReason");

                entity.Property(e => e.ReaderTypeReader).HasColumnName("ReaderType_Reader");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.AntennaReaderNavigation)
                    .WithMany(p => p.Readers)
                    .HasForeignKey(d => d.AntennaReader)
                    .HasConstraintName("Antenna_Reader");

                entity.HasOne(d => d.GasStationReaderNavigation)
                    .WithMany(p => p.Readers)
                    .HasForeignKey(d => d.GasStationReader)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GasStation_Reader");

                entity.HasOne(d => d.ProductsReader1Navigation)
                    .WithMany(p => p.Readers)
                    .HasForeignKey(d => d.ProductsReader1)
                    .HasConstraintName("Products_Reader");

                entity.HasOne(d => d.ReaderFuelTypeNavigation)
                    .WithMany(p => p.Readers)
                    .HasForeignKey(d => d.ReaderFuelType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reader_FuelType");

                entity.HasOne(d => d.ReaderNozzleNavigation)
                    .WithMany(p => p.Readers)
                    .HasForeignKey(d => d.ReaderNozzle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Reader_NozzleType");

                entity.HasOne(d => d.ReaderReplacementReasonNavigation)
                    .WithMany(p => p.Readers)
                    .HasForeignKey(d => d.ReaderReplacementReason)
                    .HasConstraintName("Reader_ReplacementReason");

                entity.HasOne(d => d.ReaderTypeReaderNavigation)
                    .WithMany(p => p.Readers)
                    .HasForeignKey(d => d.ReaderTypeReader)
                    .HasConstraintName("ReaderType_Reader");
            });

            modelBuilder.Entity<ReceptorSet>(entity =>
            {
                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodigoPostal)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Colonia)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Localidad)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NoExterior).HasMaxLength(255);

                entity.Property(e => e.NoInterior).HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UsoCfdiver33)
                    .HasColumnName("UsoCFDIVer33")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<RegimenFiscalSet>(entity =>
            {
                entity.Property(e => e.CRegimenFiscal)
                    .IsRequired()
                    .HasColumnName("c_RegimenFiscal")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<RelacionEdcclienteSet>(entity =>
            {
                entity.ToTable("RelacionEDCClienteSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NickName).HasMaxLength(80);

                entity.Property(e => e.RelacionEdcclienteClientGroup).HasColumnName("RelacionEDCCliente_ClientGroup");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.RelacionEdcclienteClientGroupNavigation)
                    .WithMany(p => p.RelacionEdcclienteSet)
                    .HasForeignKey(d => d.RelacionEdcclienteClientGroup)
                    .HasConstraintName("RelacionEDCCliente_ClientGroup");
            });

            modelBuilder.Entity<RelationProductsSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ReplacementReasons>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SectionReasonsReplacementReason).HasColumnName("SectionReasons_ReplacementReason");

                entity.HasOne(d => d.SectionReasonsReplacementReasonNavigation)
                    .WithMany(p => p.ReplacementReasons)
                    .HasForeignKey(d => d.SectionReasonsReplacementReason)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SectionReasons_ReplacementReason");
            });

            modelBuilder.Entity<ReportForClients>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ReportForClientClient).HasColumnName("ReportForClient_Client");

                entity.Property(e => e.ReportInClientReportVt).HasColumnName("ReportInClient_ReportVT");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ReportForClientClientNavigation)
                    .WithMany(p => p.ReportForClients)
                    .HasForeignKey(d => d.ReportForClientClient)
                    .HasConstraintName("ReportForClient_Client");

                entity.HasOne(d => d.ReportInClientReportVtNavigation)
                    .WithMany(p => p.ReportForClients)
                    .HasForeignKey(d => d.ReportInClientReportVt)
                    .HasConstraintName("ReportForClient_ReportVT");
            });

            modelBuilder.Entity<ReportVtfileDetailsSet>(entity =>
            {
                entity.ToTable("ReportVTFileDetailsSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReportVtemailsReportVtfileDetails).HasColumnName("ReportVTEmails_ReportVTFileDetails");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ReportVtemailsReportVtfileDetailsNavigation)
                    .WithMany(p => p.ReportVtfileDetailsSet)
                    .HasForeignKey(d => d.ReportVtemailsReportVtfileDetails)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ReportVT_ReportVTFileDetails");
            });

            modelBuilder.Entity<ReportVts>(entity =>
            {
                entity.ToTable("ReportVTs");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(600);

                entity.Property(e => e.Emails)
                    .IsRequired()
                    .HasMaxLength(450)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReportVtClientGroup).HasColumnName("ReportVT_ClientGroup");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ReportVtClientGroupNavigation)
                    .WithMany(p => p.ReportVts)
                    .HasForeignKey(d => d.ReportVtClientGroup)
                    .HasConstraintName("ReportVT_ClientGroup");
            });

            modelBuilder.Entity<RevisionMeterSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.MeterRevisionMeter).HasColumnName("Meter_RevisionMeter");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RevisionComments).HasMaxLength(255);

                entity.Property(e => e.RevisionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RevisionMeterEmployee).HasColumnName("RevisionMeter_Employee");

                entity.Property(e => e.RevisionMeterErrorRevisionMeter).HasColumnName("RevisionMeter_ErrorRevisionMeter");

                entity.Property(e => e.RevisionMeterStatusRevisionMeter).HasColumnName("RevisionMeter_StatusRevisionMeter");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.MeterRevisionMeterNavigation)
                    .WithMany(p => p.RevisionMeterSet)
                    .HasForeignKey(d => d.MeterRevisionMeter)
                    .HasConstraintName("Meter_RevisionMeter");

                entity.HasOne(d => d.RevisionMeterEmployeeNavigation)
                    .WithMany(p => p.RevisionMeterSet)
                    .HasForeignKey(d => d.RevisionMeterEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RevisionMeter_Employee");

                entity.HasOne(d => d.RevisionMeterErrorRevisionMeterNavigation)
                    .WithMany(p => p.RevisionMeterSet)
                    .HasForeignKey(d => d.RevisionMeterErrorRevisionMeter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RevisionMeter_ErrorRevisionMeter");

                entity.HasOne(d => d.RevisionMeterStatusRevisionMeterNavigation)
                    .WithMany(p => p.RevisionMeterSet)
                    .HasForeignKey(d => d.RevisionMeterStatusRevisionMeter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RevisionMeter_StatusRevisionMeter");
            });

            modelBuilder.Entity<RoleClientGroupSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RoleClientGroupClientGroup).HasColumnName("RoleClientGroup_ClientGroup");

                entity.Property(e => e.RoleClientGroupRolesWeb).HasColumnName("RoleClientGroup_RolesWeb");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.RoleClientGroupClientGroupNavigation)
                    .WithMany(p => p.RoleClientGroupSet)
                    .HasForeignKey(d => d.RoleClientGroupClientGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RoleClientGroup_ClientGroup");

                entity.HasOne(d => d.RoleClientGroupRolesWebNavigation)
                    .WithMany(p => p.RoleClientGroupSet)
                    .HasForeignKey(d => d.RoleClientGroupRolesWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RoleClientGroup_RolesWeb");
            });

            modelBuilder.Entity<RoleClientSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RoleClientClient).HasColumnName("RoleClient_Client");

                entity.Property(e => e.RoleClientRolesWeb).HasColumnName("RoleClient_RolesWeb");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.RoleClientClientNavigation)
                    .WithMany(p => p.RoleClientSet)
                    .HasForeignKey(d => d.RoleClientClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RoleClient_Client");

                entity.HasOne(d => d.RoleClientRolesWebNavigation)
                    .WithMany(p => p.RoleClientSet)
                    .HasForeignKey(d => d.RoleClientRolesWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RoleClient_RolesWeb");
            });

            modelBuilder.Entity<RolePermissions>(entity =>
            {
                entity.HasKey(e => new { e.RoleName, e.PermissionId })
                    .HasName("PK__RolePerm__64D10ED33D2FABC7");

                entity.Property(e => e.RoleName).HasMaxLength(128);

                entity.Property(e => e.PermissionId).HasMaxLength(322);
            });

            modelBuilder.Entity<RolesWebSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RolesWebUserWeb).HasColumnName("RolesWeb_UserWeb");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.RolesWebUserWebNavigation)
                    .WithMany(p => p.RolesWebSet)
                    .HasForeignKey(d => d.RolesWebUserWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RolesWeb_UserWeb");
            });

            modelBuilder.Entity<RulesClientSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RulesClientClientGroup).HasColumnName("RulesClient_ClientGroup");

                entity.Property(e => e.RulesClientRules).HasColumnName("RulesClient_Rules");

                entity.Property(e => e.RulesClientUserWeb).HasColumnName("RulesClient_UserWeb");

                entity.HasOne(d => d.RulesClientClientGroupNavigation)
                    .WithMany(p => p.RulesClientSet)
                    .HasForeignKey(d => d.RulesClientClientGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RulesClient_ClientGroup");

                entity.HasOne(d => d.RulesClientRulesNavigation)
                    .WithMany(p => p.RulesClientSet)
                    .HasForeignKey(d => d.RulesClientRules)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RulesClient_Rules");

                entity.HasOne(d => d.RulesClientUserWebNavigation)
                    .WithMany(p => p.RulesClientSet)
                    .HasForeignKey(d => d.RulesClientUserWeb)
                    .HasConstraintName("RulesClient_UserWeb");
            });

            modelBuilder.Entity<RulesSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NumTransactionExternal).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RulesFuelType).HasColumnName("Rules_FuelType");

                entity.HasOne(d => d.RulesFuelTypeNavigation)
                    .WithMany(p => p.RulesSet)
                    .HasForeignKey(d => d.RulesFuelType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Rules_FuelType");
            });

            modelBuilder.Entity<SaldosLimitConfigSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Limit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<SaldosSet>(entity =>
            {
                entity.Property(e => e.Comentarios).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeFecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaldosClientGroup).HasColumnName("Saldos_ClientGroup");

                entity.Property(e => e.SaldosEdc).HasColumnName("Saldos_EDC");

                entity.HasOne(d => d.SaldosClientGroupNavigation)
                    .WithMany(p => p.SaldosSet)
                    .HasForeignKey(d => d.SaldosClientGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Saldos_ClientGroup");

                entity.HasOne(d => d.SaldosEdcNavigation)
                    .WithMany(p => p.SaldosSet)
                    .HasForeignKey(d => d.SaldosEdc)
                    .HasConstraintName("Saldos_EDC");
            });

            modelBuilder.Entity<SamcommandsSet>(entity =>
            {
                entity.ToTable("SAMCommandsSet");

                entity.Property(e => e.Columns).HasMaxLength(255);

                entity.Property(e => e.Condition).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DescriptionCommand).HasMaxLength(255);

                entity.Property(e => e.ExampleCommand).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameCommand)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NickName).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TableDb).HasMaxLength(255);
            });

            modelBuilder.Entity<SamrolComandoSet>(entity =>
            {
                entity.ToTable("SAMRolComandoSet");

                entity.Property(e => e.AspnetRolesItemRoleId).HasColumnName("aspnet_RolesItem_RoleId");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SamrolComandoSamcommands).HasColumnName("SAMRolComando_SAMCommands");

                entity.HasOne(d => d.SamrolComandoSamcommandsNavigation)
                    .WithMany(p => p.SamrolComandoSet)
                    .HasForeignKey(d => d.SamrolComandoSamcommands)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SAMRolComando_SAMCommands");
            });

            modelBuilder.Entity<SectionReasonsSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DisplayUser)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SectionControl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SerieBillingSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ExpeditionPlace)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FormOfPayment)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TypeOfVoucher)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SimgpsSet>(entity =>
            {
                entity.ToTable("SIMGpsSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.GpsSimgps).HasColumnName("Gps_SIMGps");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PhoneNumberInter).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Simcard)
                    .HasColumnName("SIMCARD")
                    .HasMaxLength(255);

                entity.HasOne(d => d.GpsSimgpsNavigation)
                    .WithMany(p => p.SimgpsSet)
                    .HasForeignKey(d => d.GpsSimgps)
                    .HasConstraintName("Gps_SIMGps");
            });

            modelBuilder.Entity<StationTypes>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<StatusAppointmentSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<StatusCallSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<StatusContingencySet>(entity =>
            {
                entity.HasIndex(e => e.Color)
                    .HasName("UQ__StatusCo__E11D38451F5A3940")
                    .IsUnique();

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<StatusOrderSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<StatusRevisionMeterSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DescriptionStatus)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<StatusSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameStatus)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<StatusTicketSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<SustitucionCfdiset>(entity =>
            {
                entity.ToTable("SustitucionCFDISet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FechaSustitucion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FolioNuevo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FolioSustitucion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdBillingNuevo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoOperacion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uuidnuevo)
                    .IsRequired()
                    .HasColumnName("UUIDNuevo")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uuidsustitucion)
                    .IsRequired()
                    .HasColumnName("UUIDSustitucion")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SyncDisable>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<SynchronizerFilesVersionSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FilesVersion)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FtpUpgradeFileName)
                    .HasColumnName("ftpUpgradeFileName")
                    .HasMaxLength(100);

                entity.Property(e => e.FtpUpgradeFilePass)
                    .HasColumnName("ftpUpgradeFilePass")
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TablePropertiesSet>(entity =>
            {
                entity.Property(e => e.AllTablesTableProperties).HasColumnName("AllTables_TableProperties");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ShowName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.AllTablesTablePropertiesNavigation)
                    .WithMany(p => p.TablePropertiesSet)
                    .HasForeignKey(d => d.AllTablesTableProperties)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AllTables_TableProperties");
            });

            modelBuilder.Entity<TagTypes>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.HasIndex(e => e.Sid)
                    .HasName("UQ__tmp_ms_x__CA195971EE7E84D0")
                    .IsUnique();

                entity.Property(e => e.ActivationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ESid)
                    .HasColumnName("eSID")
                    .HasMaxLength(255);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.GasStationTag).HasColumnName("GasStation_Tag");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProductsTag).HasColumnName("Products_Tag");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SerialMeter).HasMaxLength(255);

                entity.Property(e => e.ServiceDataTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("SID")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TagEmployee).HasColumnName("Tag_Employee");

                entity.Property(e => e.TagReplacementReason).HasColumnName("Tag_ReplacementReason");

                entity.Property(e => e.TagTagType).HasColumnName("Tag_TagType");

                entity.Property(e => e.TagTankIdentifier).HasColumnName("Tag_TankIdentifier");

                entity.Property(e => e.TagTicket).HasColumnName("Tag_Ticket");

                entity.Property(e => e.TagTreatmentType).HasColumnName("Tag_TreatmentType");

                entity.Property(e => e.TagVehicle).HasColumnName("Tag_Vehicle");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(16)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WithNth).HasColumnName("WithNTH");

                entity.HasOne(d => d.GasStationTagNavigation)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(d => d.GasStationTag)
                    .HasConstraintName("GasStation_Tag");

                entity.HasOne(d => d.ProductsTagNavigation)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(d => d.ProductsTag)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("Products_Tag");

                entity.HasOne(d => d.TagEmployeeNavigation)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(d => d.TagEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Tag_Employee");

                entity.HasOne(d => d.TagReplacementReasonNavigation)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(d => d.TagReplacementReason)
                    .HasConstraintName("Tag_ReplacementReason");

                entity.HasOne(d => d.TagTagTypeNavigation)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(d => d.TagTagType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Tag_TagType");

                entity.HasOne(d => d.TagTankIdentifierNavigation)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(d => d.TagTankIdentifier)
                    .HasConstraintName("Tag_TankIdentifier");

                entity.HasOne(d => d.TagTicketNavigation)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(d => d.TagTicket)
                    .HasConstraintName("Tag_Ticket");

                entity.HasOne(d => d.TagTreatmentTypeNavigation)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(d => d.TagTreatmentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Tag_TreatmentType");

                entity.HasOne(d => d.TagVehicleNavigation)
                    .WithMany(p => p.Tags)
                    .HasForeignKey(d => d.TagVehicle)
                    .HasConstraintName("Tag_Vehicle");
            });

            modelBuilder.Entity<TagsCopy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActivationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ESid)
                    .HasColumnName("eSID")
                    .HasMaxLength(255);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.FolioTheService).HasMaxLength(255);

                entity.Property(e => e.GasStationTag).HasColumnName("GasStation_Tag");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ProductsTag).HasColumnName("Products_Tag");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SerialMeter).HasMaxLength(255);

                entity.Property(e => e.ServiceDataTime).HasColumnType("datetime");

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("SID")
                    .HasMaxLength(255);

                entity.Property(e => e.TagEmployee).HasColumnName("Tag_Employee");

                entity.Property(e => e.TagReplacementReason).HasColumnName("Tag_ReplacementReason");

                entity.Property(e => e.TagTagType).HasColumnName("Tag_TagType");

                entity.Property(e => e.TagTankIdentifier).HasColumnName("Tag_TankIdentifier");

                entity.Property(e => e.TagTicket).HasColumnName("Tag_Ticket");

                entity.Property(e => e.TagTreatmentType).HasColumnName("Tag_TreatmentType");

                entity.Property(e => e.TagVehicle).HasColumnName("Tag_Vehicle");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(16);

                entity.Property(e => e.WithNth).HasColumnName("WithNTH");
            });

            modelBuilder.Entity<TankIdentifiers>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TankVehiclesSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TankVehiclesTankIdentifier).HasColumnName("TankVehicles_TankIdentifier");

                entity.Property(e => e.VehicleTankVehicles).HasColumnName("Vehicle_TankVehicles");

                entity.HasOne(d => d.TankVehiclesTankIdentifierNavigation)
                    .WithMany(p => p.TankVehiclesSet)
                    .HasForeignKey(d => d.TankVehiclesTankIdentifier)
                    .HasConstraintName("TankVehicles_TankIdentifier");

                entity.HasOne(d => d.VehicleTankVehiclesNavigation)
                    .WithMany(p => p.TankVehiclesSet)
                    .HasForeignKey(d => d.VehicleTankVehicles)
                    .HasConstraintName("Vehicle_TankVehicles");
            });

            modelBuilder.Entity<TaskPrioritySet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NamePriority)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TaskStatusSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StatusDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TaxDataSet>(entity =>
            {
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Colony)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("CP")
                    .HasMaxLength(8)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.InsideNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(180)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OutsideNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TaxationSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TechnicalEmployeeSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DaysOfWeek).HasMaxLength(255);

                entity.Property(e => e.EndOutOffice).HasColumnType("datetime");

                entity.Property(e => e.HexColor).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StartOutOffice).HasColumnType("datetime");

                entity.Property(e => e.TechnicalEmployeeCity).HasColumnName("TechnicalEmployee_City");

                entity.Property(e => e.TechnicalEmployeeExpertise).HasColumnName("TechnicalEmployee_Expertise");

                entity.HasOne(d => d.TechnicalEmployeeCityNavigation)
                    .WithMany(p => p.TechnicalEmployeeSet)
                    .HasForeignKey(d => d.TechnicalEmployeeCity)
                    .HasConstraintName("TechnicalEmployee_City");

                entity.HasOne(d => d.TechnicalEmployeeExpertiseNavigation)
                    .WithMany(p => p.TechnicalEmployeeSet)
                    .HasForeignKey(d => d.TechnicalEmployeeExpertise)
                    .HasConstraintName("TechnicalEmployee_Expertise");
            });

            modelBuilder.Entity<TempDispatch>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AllocateCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.AllocateVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.BaseBalance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillingDispatch).HasColumnName("BIlling_Dispatch");

                entity.Property(e => e.CgCommand).HasMaxLength(15);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ContingencyDispatch).HasColumnName("Contingency_Dispatch");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DatetimeCanceled).HasColumnType("datetime");

                entity.Property(e => e.DatetimeEnd).HasColumnType("datetime");

                entity.Property(e => e.DatetimeFeed).HasColumnType("datetime");

                entity.Property(e => e.DatetimeInvoicing).HasColumnType("datetime");

                entity.Property(e => e.DatetimeStamp).HasColumnType("datetime");

                entity.Property(e => e.DatetimeStart).HasColumnType("datetime");

                entity.Property(e => e.DeltaValue).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.DispatchBilling).HasColumnName("Dispatch_BIlling");

                entity.Property(e => e.DispatchFuelType2).HasColumnName("Dispatch_FuelType2");

                entity.Property(e => e.DispatchGasStation).HasColumnName("Dispatch_GasStation");

                entity.Property(e => e.DispatchVehicle).HasColumnName("Dispatch_Vehicle");

                entity.Property(e => e.DriverName).HasMaxLength(50);

                entity.Property(e => e.EngineHours).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Ieps)
                    .HasColumnName("IEPS")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameCenterCost).HasMaxLength(255);

                entity.Property(e => e.NumTransactionExternal).HasMaxLength(255);

                entity.Property(e => e.Odometer).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.OdometerModified).HasColumnType("datetime");

                entity.Property(e => e.OldNameCedi)
                    .HasColumnName("OldNameCEDI")
                    .HasMaxLength(255);

                entity.Property(e => e.PriceUnit).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.ProductCodeDispatch).HasColumnName("ProductCode_Dispatch");

                entity.Property(e => e.RealCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RealVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.RecordOk).HasColumnName("RecordOK");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Tar).HasColumnName("TAR");

                entity.Property(e => e.TransactionInternalId)
                    .HasColumnName("TransactionInternalID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TestContingencyCode>(entity =>
            {
                entity.ToTable("Test_ContingencyCode");

                entity.Property(e => e.ContingencyCode)
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.DispatchId).HasColumnName("DispatchID");
            });

            modelBuilder.Entity<TestingProductsSet>(entity =>
            {
                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TestDate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TestDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TestingProductsEmployee).HasColumnName("TestingProducts_Employee");

                entity.Property(e => e.TestingProductsEmployee1).HasColumnName("TestingProducts_Employee1");

                entity.HasOne(d => d.TestingProductsEmployeeNavigation)
                    .WithMany(p => p.TestingProductsSetTestingProductsEmployeeNavigation)
                    .HasForeignKey(d => d.TestingProductsEmployee)
                    .HasConstraintName("TestingProducts_Employee");

                entity.HasOne(d => d.TestingProductsEmployee1Navigation)
                    .WithMany(p => p.TestingProductsSetTestingProductsEmployee1Navigation)
                    .HasForeignKey(d => d.TestingProductsEmployee1)
                    .HasConstraintName("TestingProducts_Employee1");
            });

            modelBuilder.Entity<TicketCloseRolSet>(entity =>
            {
                entity.Property(e => e.AspnetRolesItemRoleId).HasColumnName("aspnet_RolesItem_RoleId");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TicketCloseRolTypeOfTicket).HasColumnName("TicketCloseRol_TypeOfTicket");

                entity.HasOne(d => d.TicketCloseRolTypeOfTicketNavigation)
                    .WithMany(p => p.TicketCloseRolSet)
                    .HasForeignKey(d => d.TicketCloseRolTypeOfTicket)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TicketCloseRol_TypeOfTicket");
            });

            modelBuilder.Entity<TicketDetailMovementsSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TicketDetailMovementsAppointmentService).HasColumnName("TicketDetailMovements_AppointmentService");

                entity.Property(e => e.TicketDetailMovementsOrderOfService).HasColumnName("TicketDetailMovements_OrderOfService");

                entity.Property(e => e.TicketDetailMovementsTicket).HasColumnName("TicketDetailMovements_Ticket");

                entity.HasOne(d => d.TicketDetailMovementsAppointmentServiceNavigation)
                    .WithMany(p => p.TicketDetailMovementsSet)
                    .HasForeignKey(d => d.TicketDetailMovementsAppointmentService)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TicketDetailMovements_AppointmentService");

                entity.HasOne(d => d.TicketDetailMovementsOrderOfServiceNavigation)
                    .WithMany(p => p.TicketDetailMovementsSet)
                    .HasForeignKey(d => d.TicketDetailMovementsOrderOfService)
                    .HasConstraintName("TicketDetailMovements_OrderOfService");

                entity.HasOne(d => d.TicketDetailMovementsTicketNavigation)
                    .WithMany(p => p.TicketDetailMovementsSet)
                    .HasForeignKey(d => d.TicketDetailMovementsTicket)
                    .HasConstraintName("TicketDetailMovements_Ticket");
            });

            modelBuilder.Entity<TicketEventsSet>(entity =>
            {
                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateReporte).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TicketEventsDepartment).HasColumnName("TicketEvents_Department");

                entity.Property(e => e.TicketEventsDiagnosticTicketSetItem).HasColumnName("TicketEvents_DiagnosticTicketSetItem");

                entity.Property(e => e.TicketEventsEmployee).HasColumnName("TicketEvents_Employee");

                entity.Property(e => e.TicketEventsGasStation).HasColumnName("TicketEvents_GasStation");

                entity.Property(e => e.TicketEventsTaskPriority).HasColumnName("TicketEvents_TaskPriority");

                entity.Property(e => e.TicketEventsVehicle).HasColumnName("TicketEvents_Vehicle");

                entity.Property(e => e.TicketTicketEvents).HasColumnName("Ticket_TicketEvents");

                entity.HasOne(d => d.TicketEventsDepartmentNavigation)
                    .WithMany(p => p.TicketEventsSet)
                    .HasForeignKey(d => d.TicketEventsDepartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TicketEvents_Department");

                entity.HasOne(d => d.TicketEventsDiagnosticTicketSetItemNavigation)
                    .WithMany(p => p.TicketEventsSet)
                    .HasForeignKey(d => d.TicketEventsDiagnosticTicketSetItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TicketEvents_DiagnosticTicketSetItem");

                entity.HasOne(d => d.TicketEventsEmployeeNavigation)
                    .WithMany(p => p.TicketEventsSet)
                    .HasForeignKey(d => d.TicketEventsEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TicketEvents_Employee");

                entity.HasOne(d => d.TicketEventsGasStationNavigation)
                    .WithMany(p => p.TicketEventsSet)
                    .HasForeignKey(d => d.TicketEventsGasStation)
                    .HasConstraintName("TicketEvents_GasStation");

                entity.HasOne(d => d.TicketEventsTaskPriorityNavigation)
                    .WithMany(p => p.TicketEventsSet)
                    .HasForeignKey(d => d.TicketEventsTaskPriority)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TicketEvents_TaskPriority");

                entity.HasOne(d => d.TicketEventsVehicleNavigation)
                    .WithMany(p => p.TicketEventsSet)
                    .HasForeignKey(d => d.TicketEventsVehicle)
                    .HasConstraintName("TicketEvents_Vehicle");

                entity.HasOne(d => d.TicketTicketEventsNavigation)
                    .WithMany(p => p.TicketEventsSet)
                    .HasForeignKey(d => d.TicketTicketEvents)
                    .HasConstraintName("Ticket_TicketEvents");
            });

            modelBuilder.Entity<TicketSet>(entity =>
            {
                entity.Property(e => e.AppointmentServiceTicket).HasColumnName("AppointmentService_Ticket");

                entity.Property(e => e.BatteryTicket).HasColumnName("Battery_Ticket");

                entity.Property(e => e.ComentariosCierre).HasMaxLength(255);

                entity.Property(e => e.Contacto).HasMaxLength(255);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateFinish).HasColumnType("datetime");

                entity.Property(e => e.DateReport)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.OrderOfServiceTicket1).HasColumnName("OrderOfService_Ticket1");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StatusTicketTicket).HasColumnName("StatusTicket_Ticket");

                entity.Property(e => e.TicketClosingReasonTicket).HasColumnName("Ticket_ClosingReasonTicket");

                entity.Property(e => e.TicketDepartment).HasColumnName("Ticket_Department");

                entity.Property(e => e.TicketDiagnosticTicketSetItem).HasColumnName("Ticket_DiagnosticTicketSetItem");

                entity.Property(e => e.TicketEmployee).HasColumnName("Ticket_Employee");

                entity.Property(e => e.TicketEmployee11).HasColumnName("Ticket_Employee11");

                entity.Property(e => e.TicketEmployee3).HasColumnName("Ticket_Employee3");

                entity.Property(e => e.TicketGasStation).HasColumnName("Ticket_GasStation");

                entity.Property(e => e.TicketMalfunctionReport).HasColumnName("Ticket_MalfunctionReport");

                entity.Property(e => e.TicketTaskPriority).HasColumnName("Ticket_TaskPriority");

                entity.Property(e => e.TicketVehicle).HasColumnName("Ticket_Vehicle");

                entity.Property(e => e.TypeOfTicketTicket).HasColumnName("TypeOfTicket_Ticket");

                entity.HasOne(d => d.AppointmentServiceTicketNavigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.AppointmentServiceTicket)
                    .HasConstraintName("AppointmentService_Ticket");

                entity.HasOne(d => d.BatteryTicketNavigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.BatteryTicket)
                    .HasConstraintName("Battery_Ticket");

                entity.HasOne(d => d.OrderOfServiceTicket1Navigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.OrderOfServiceTicket1)
                    .HasConstraintName("OrderOfService_Ticket");

                entity.HasOne(d => d.StatusTicketTicketNavigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.StatusTicketTicket)
                    .HasConstraintName("StatusTicket_Ticket");

                entity.HasOne(d => d.TicketClosingReasonTicketNavigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.TicketClosingReasonTicket)
                    .HasConstraintName("Ticket_ClosingReasonTicket");

                entity.HasOne(d => d.TicketDepartmentNavigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.TicketDepartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Ticket_Department");

                entity.HasOne(d => d.TicketDiagnosticTicketSetItemNavigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.TicketDiagnosticTicketSetItem)
                    .HasConstraintName("Ticket_DiagnosticTicketSetItem");

                entity.HasOne(d => d.TicketEmployeeNavigation)
                    .WithMany(p => p.TicketSetTicketEmployeeNavigation)
                    .HasForeignKey(d => d.TicketEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Ticket_Employee");

                entity.HasOne(d => d.TicketEmployee11Navigation)
                    .WithMany(p => p.TicketSetTicketEmployee11Navigation)
                    .HasForeignKey(d => d.TicketEmployee11)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("Ticket_Employee1");

                entity.HasOne(d => d.TicketEmployee3Navigation)
                    .WithMany(p => p.TicketSetTicketEmployee3Navigation)
                    .HasForeignKey(d => d.TicketEmployee3)
                    .HasConstraintName("Ticket_Employee3");

                entity.HasOne(d => d.TicketGasStationNavigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.TicketGasStation)
                    .HasConstraintName("Ticket_GasStation");

                entity.HasOne(d => d.TicketMalfunctionReportNavigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.TicketMalfunctionReport)
                    .HasConstraintName("Ticket_MalfunctionReport");

                entity.HasOne(d => d.TicketTaskPriorityNavigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.TicketTaskPriority)
                    .HasConstraintName("Ticket_TaskPriority");

                entity.HasOne(d => d.TicketVehicleNavigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.TicketVehicle)
                    .HasConstraintName("Ticket_Vehicle");

                entity.HasOne(d => d.TypeOfTicketTicketNavigation)
                    .WithMany(p => p.TicketSet)
                    .HasForeignKey(d => d.TypeOfTicketTicket)
                    .HasConstraintName("TypeOfTicket_Ticket");
            });

            modelBuilder.Entity<TimbreFiscalSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.FechaTimbrado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NoCertificadoSat)
                    .IsRequired()
                    .HasColumnName("NoCertificadoSAT")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SelloCfd)
                    .IsRequired()
                    .HasColumnName("SelloCFD")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SelloSat)
                    .IsRequired()
                    .HasColumnName("SelloSAT")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("UUID")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TimeZoneCset>(entity =>
            {
                entity.ToTable("TimeZoneCSet");

                entity.Property(e => e.CountryTimeZone).HasColumnName("Country_TimeZone");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IdTimeZone)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CountryTimeZoneNavigation)
                    .WithMany(p => p.TimeZoneCset)
                    .HasForeignKey(d => d.CountryTimeZone)
                    .HasConstraintName("Country_TimeZoneC");
            });

            modelBuilder.Entity<TipoDeComprobanteSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TipoDeFactorSet>(entity =>
            {
                entity.Property(e => e.CTipoFactor)
                    .IsRequired()
                    .HasColumnName("c_TipoFactor")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TipoDeMonedaSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TipoGpsSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TypeGps).HasMaxLength(255);
            });

            modelBuilder.Entity<TmpVehiclesCg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TMP_VehiclesCG");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Eco)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Grupo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Plate)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.UpdateBo).HasColumnName("UpdateBO");
            });

            modelBuilder.Entity<TrasladosEdcset>(entity =>
            {
                entity.ToTable("TrasladosEDCSet");

                entity.Property(e => e.BaseVer33).HasColumnType("decimal(24, 6)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Importe).HasColumnType("decimal(26, 4)");

                entity.Property(e => e.Impuesto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImpuestoTraladadoEdcTraslados).HasColumnName("ImpuestoTraladadoEDC_Traslados");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TasaOcuota)
                    .HasColumnName("TasaOCuota")
                    .HasColumnType("decimal(24, 6)");

                entity.Property(e => e.TipoFactorVer33).HasMaxLength(10);

                entity.HasOne(d => d.ImpuestoTraladadoEdcTrasladosNavigation)
                    .WithMany(p => p.TrasladosEdcset)
                    .HasForeignKey(d => d.ImpuestoTraladadoEdcTraslados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ImpuestoTrasladadoEDC_TrasladosEDC");
            });

            modelBuilder.Entity<TrasladosEdeset>(entity =>
            {
                entity.ToTable("TrasladosEDESet");

                entity.Property(e => e.BaseVer33).HasColumnType("decimal(26, 6)");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Importe).HasColumnType("decimal(26, 6)");

                entity.Property(e => e.Impuesto)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ImpuetosTrasladadosEdeTrasladosEde).HasColumnName("ImpuetosTrasladadosEDE_TrasladosEDE");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TasaOcuota)
                    .HasColumnName("TasaOCuota")
                    .HasColumnType("decimal(26, 6)");

                entity.Property(e => e.TipoFactorVer33)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ImpuetosTrasladadosEdeTrasladosEdeNavigation)
                    .WithMany(p => p.TrasladosEdeset)
                    .HasForeignKey(d => d.ImpuetosTrasladadosEdeTrasladosEde)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ImpuetosTrasladadosEDE_TrasladosEDE");
            });

            modelBuilder.Entity<TreatmentTypes>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TypeAccountSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TypeCallSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.ReportNoc).HasColumnName("ReportNOC");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TypeConceptBalanceSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TypeContigencySet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TypeExpensesSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TypeIdentifierSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TypeOfServiceByAreaSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EstimatedTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TypeOfServiceByAreaDepartment).HasColumnName("TypeOfServiceByArea_Department");

                entity.HasOne(d => d.TypeOfServiceByAreaDepartmentNavigation)
                    .WithMany(p => p.TypeOfServiceByAreaSet)
                    .HasForeignKey(d => d.TypeOfServiceByAreaDepartment)
                    .HasConstraintName("TypeOfServiceByArea_Department");
            });

            modelBuilder.Entity<TypeOfServiceSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameService)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<TypeOfTicketSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descripción).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TypeOfTicketDepartment).HasColumnName("TypeOfTicket_Department");

                entity.HasOne(d => d.TypeOfTicketDepartmentNavigation)
                    .WithMany(p => p.TypeOfTicketSet)
                    .HasForeignKey(d => d.TypeOfTicketDepartment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TypeOfTicket_Department");
            });

            modelBuilder.Entity<UnattendedUnitCatalogSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<UserWebSet>(entity =>
            {
                entity.Property(e => e.AltaAccesoQv)
                    .HasColumnName("AltaAccesoQV")
                    .HasColumnType("datetime");

                entity.Property(e => e.CodigoVerificacion).HasMaxLength(12);

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EnvioCodigoVerificacion).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsEditQv).HasColumnName("IsEditQV");

                entity.Property(e => e.IsGps).HasColumnName("IsGPS");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(70)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserWebControlCompany).HasColumnName("UserWeb_ControlCompany");

                entity.HasOne(d => d.UserWebControlCompanyNavigation)
                    .WithMany(p => p.UserWebSet)
                    .HasForeignKey(d => d.UserWebControlCompany)
                    .HasConstraintName("UserWeb_ControlCompany");
            });

            modelBuilder.Entity<UsersInClientGroupSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UsersInClientGroupClientGroup).HasColumnName("UsersInClientGroup_ClientGroup");

                entity.Property(e => e.UsersInClientGroupGasStationGroup).HasColumnName("UsersInClientGroup_GasStationGroup");

                entity.Property(e => e.UsersInClientGroupUserWeb).HasColumnName("UsersInClientGroup_UserWeb");

                entity.HasOne(d => d.UsersInClientGroupClientGroupNavigation)
                    .WithMany(p => p.UsersInClientGroupSet)
                    .HasForeignKey(d => d.UsersInClientGroupClientGroup)
                    .HasConstraintName("UsersInClientGroup_ClientGroup");

                entity.HasOne(d => d.UsersInClientGroupGasStationGroupNavigation)
                    .WithMany(p => p.UsersInClientGroupSet)
                    .HasForeignKey(d => d.UsersInClientGroupGasStationGroup)
                    .HasConstraintName("UsersInClientGroup_GasStationGroup");

                entity.HasOne(d => d.UsersInClientGroupUserWebNavigation)
                    .WithMany(p => p.UsersInClientGroupSet)
                    .HasForeignKey(d => d.UsersInClientGroupUserWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UsersInClientGroup_UserWeb");
            });

            modelBuilder.Entity<UsersInProfileSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UsersInProfileClient).HasColumnName("UsersInProfile_Client");

                entity.Property(e => e.UsersInProfileGasStation).HasColumnName("UsersInProfile_GasStation");

                entity.Property(e => e.UsersInProfileProfile).HasColumnName("UsersInProfile_Profile");

                entity.Property(e => e.UsersInProfileUserWeb).HasColumnName("UsersInProfile_UserWeb");

                entity.HasOne(d => d.UsersInProfileClientNavigation)
                    .WithMany(p => p.UsersInProfileSet)
                    .HasForeignKey(d => d.UsersInProfileClient)
                    .HasConstraintName("UsersInProfile_Client");

                entity.HasOne(d => d.UsersInProfileGasStationNavigation)
                    .WithMany(p => p.UsersInProfileSet)
                    .HasForeignKey(d => d.UsersInProfileGasStation)
                    .HasConstraintName("UsersInProfile_GasStation");

                entity.HasOne(d => d.UsersInProfileProfileNavigation)
                    .WithMany(p => p.UsersInProfileSet)
                    .HasForeignKey(d => d.UsersInProfileProfile)
                    .HasConstraintName("UsersInProfile_Profile");

                entity.HasOne(d => d.UsersInProfileUserWebNavigation)
                    .WithMany(p => p.UsersInProfileSet)
                    .HasForeignKey(d => d.UsersInProfileUserWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UsersInProfile_UserWeb");
            });

            modelBuilder.Entity<UsersInRolesWebSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UsersInRolesWebRolesWeb).HasColumnName("UsersInRolesWeb_RolesWeb");

                entity.Property(e => e.UsersInRolesWebUserWeb).HasColumnName("UsersInRolesWeb_UserWeb");

                entity.HasOne(d => d.UsersInRolesWebRolesWebNavigation)
                    .WithMany(p => p.UsersInRolesWebSet)
                    .HasForeignKey(d => d.UsersInRolesWebRolesWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UsersInRolesWeb_RolesWeb");

                entity.HasOne(d => d.UsersInRolesWebUserWebNavigation)
                    .WithMany(p => p.UsersInRolesWebSet)
                    .HasForeignKey(d => d.UsersInRolesWebUserWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UsersInRolesWeb_UserWeb");
            });

            modelBuilder.Entity<UsoDeCfdiset>(entity =>
            {
                entity.ToTable("UsoDeCFDISet");

                entity.Property(e => e.CUsoCfdi)
                    .IsRequired()
                    .HasColumnName("c_UsoCFDI")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<VehicleBrands>(entity =>
            {
                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<VehicleLastOdometers>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.LastOdometer).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.LastOdometerDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Latitude).HasColumnType("decimal(28, 20)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(28, 20)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Speed).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.UnitIdHex)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.VehicleLastOdometerVehicle).HasColumnName("VehicleLastOdometer_Vehicle");
            });

            modelBuilder.Entity<VehiclePhoneCouplingSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DatetimeUtc)
                    .HasColumnName("DatetimeUTC")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DriverName).HasMaxLength(255);

                entity.Property(e => e.EmployeeNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VehiclePhoneCouplingClient).HasColumnName("VehiclePhoneCoupling_Client");

                entity.Property(e => e.VehiclePhoneCouplingEmployeeRoles).HasColumnName("VehiclePhoneCoupling_EmployeeRoles");

                entity.Property(e => e.VehiclePhoneCouplingVehicle).HasColumnName("VehiclePhoneCoupling_Vehicle");

                entity.HasOne(d => d.VehiclePhoneCouplingClientNavigation)
                    .WithMany(p => p.VehiclePhoneCouplingSet)
                    .HasForeignKey(d => d.VehiclePhoneCouplingClient)
                    .HasConstraintName("VehiclePhoneCoupling_Client");

                entity.HasOne(d => d.VehiclePhoneCouplingEmployeeRolesNavigation)
                    .WithMany(p => p.VehiclePhoneCouplingSet)
                    .HasForeignKey(d => d.VehiclePhoneCouplingEmployeeRoles)
                    .HasConstraintName("VehiclePhoneCoupling_EmployeeRoles");

                entity.HasOne(d => d.VehiclePhoneCouplingVehicleNavigation)
                    .WithMany(p => p.VehiclePhoneCouplingSet)
                    .HasForeignKey(d => d.VehiclePhoneCouplingVehicle)
                    .HasConstraintName("VehiclePhoneCoupling_Vehicle");
            });

            modelBuilder.Entity<VehicleTypes>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<Vehicles>(entity =>
            {
                entity.Property(e => e.AppointmentServiceVehicle).HasColumnName("AppointmentService_Vehicle");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.CostCenterVehicle).HasColumnName("CostCenter_Vehicle");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EstimatedFuelCons).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.ExtraordinaryDatetime).HasColumnType("datetime");

                entity.Property(e => e.HelpComentsTicket).HasMaxLength(255);

                entity.Property(e => e.HelpNameEmployee).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NumTransactionExternal).HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PublicId).HasColumnName("PublicID");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.RulesVehicle).HasColumnName("Rules_Vehicle");

                entity.Property(e => e.SearchProperty1).HasMaxLength(80);

                entity.Property(e => e.SearchProperty2).HasMaxLength(80);

                entity.Property(e => e.SingleEventDatetimeEnd).HasColumnType("datetime");

                entity.Property(e => e.SingleEventDatetimeStart).HasColumnType("datetime");

                entity.Property(e => e.VehicleBrandModel).HasColumnName("Vehicle_BrandModel");

                entity.Property(e => e.VehicleClient).HasColumnName("Vehicle_Client");

                entity.Property(e => e.VehicleFuelType).HasColumnName("Vehicle_FuelType");

                entity.Property(e => e.VehicleStatus).HasColumnName("Vehicle_Status");

                entity.Property(e => e.VehicleVehicleBrand).HasColumnName("Vehicle_VehicleBrand");

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WithTempValuesDate).HasColumnType("datetime");

                entity.HasOne(d => d.AppointmentServiceVehicleNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.AppointmentServiceVehicle)
                    .HasConstraintName("AppointmentService_Vehicle");

                entity.HasOne(d => d.CostCenterVehicleNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.CostCenterVehicle)
                    .HasConstraintName("CostCenter_Vehicle");

                entity.HasOne(d => d.RulesVehicleNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.RulesVehicle)
                    .HasConstraintName("Rules_Vehicle");

                entity.HasOne(d => d.VehicleBrandModelNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.VehicleBrandModel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Vehicle_BrandModel");

                entity.HasOne(d => d.VehicleClientNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.VehicleClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Vehicle_Client");

                entity.HasOne(d => d.VehicleFuelTypeNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.VehicleFuelType)
                    .HasConstraintName("Vehicle_FuelType");

                entity.HasOne(d => d.VehicleStatusNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.VehicleStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Vehicle_Status");

                entity.HasOne(d => d.VehicleVehicleBrandNavigation)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.VehicleVehicleBrand)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Vehicle_VehicleBrand");
            });

            modelBuilder.Entity<ViewsCtrlsWebSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ViewsCtrlsWebControlsWeb).HasColumnName("ViewsCtrlsWeb_ControlsWeb");

                entity.Property(e => e.ViewsCtrlsWebViewsWeb).HasColumnName("ViewsCtrlsWeb_ViewsWeb");

                entity.HasOne(d => d.ViewsCtrlsWebControlsWebNavigation)
                    .WithMany(p => p.ViewsCtrlsWebSet)
                    .HasForeignKey(d => d.ViewsCtrlsWebControlsWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ViewsCtrlsWeb_ControlsWeb");

                entity.HasOne(d => d.ViewsCtrlsWebViewsWebNavigation)
                    .WithMany(p => p.ViewsCtrlsWebSet)
                    .HasForeignKey(d => d.ViewsCtrlsWebViewsWeb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ViewsCtrlsWeb_ViewsWeb");
            });

            modelBuilder.Entity<ViewsWebSet>(entity =>
            {
                entity.Property(e => e.ControllerWebViewsWeb).HasColumnName("ControllerWeb_ViewsWeb");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ControllerWebViewsWebNavigation)
                    .WithMany(p => p.ViewsWebSet)
                    .HasForeignKey(d => d.ControllerWebViewsWeb)
                    .HasConstraintName("ControllerWeb_ViewsWeb");
            });

            modelBuilder.Entity<VolumetricSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NickName).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<VwAllEmployeesFromAppointment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AllEmployeesFromAppointment");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwAspnetApplications>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfiles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRoles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePaths>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwCallRecordReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CallRecordReport");

                entity.Property(e => e.Cliente).HasMaxLength(255);

                entity.Property(e => e.Comentarios).HasMaxLength(4000);

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Económico).HasMaxLength(255);

                entity.Property(e => e.Estación).HasMaxLength(255);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.FechaFin)
                    .HasColumnName("Fecha_Fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("Fecha_Inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.Folio).HasMaxLength(255);

                entity.Property(e => e.Grupo).HasMaxLength(255);

                entity.Property(e => e.NickNameCliente)
                    .HasColumnName("NickName_Cliente")
                    .HasMaxLength(255);

                entity.Property(e => e.NickNameEstacion)
                    .HasColumnName("NickName_Estacion")
                    .HasMaxLength(255);

                entity.Property(e => e.NombrePersona)
                    .IsRequired()
                    .HasColumnName("Nombre_persona")
                    .HasMaxLength(80);

                entity.Property(e => e.Operador)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Placa).HasMaxLength(255);

                entity.Property(e => e.Problema)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.Telefono).HasMaxLength(20);
            });

            modelBuilder.Entity<VwConnectionByStation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ConnectionByStation");

                entity.Property(e => e.ActividadesEnLaEstacion)
                    .IsRequired()
                    .HasColumnName("Actividades_en_la_Estacion")
                    .HasMaxLength(150);

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(600);

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Empleado)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Estacion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FinDeConexion)
                    .HasColumnName("Fin_de_conexion")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdActividad).HasColumnName("Id_Actividad");

                entity.Property(e => e.IdEmpleado).HasColumnName("Id_Empleado");

                entity.Property(e => e.IdEstacion).HasColumnName("Id_Estacion");

                entity.Property(e => e.InicioDeConexion)
                    .HasColumnName("Inicio_de_conexion")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumeroEstacion)
                    .IsRequired()
                    .HasColumnName("Numero_Estacion")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<VwConsumoDeDespachos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ConsumoDeDespachos");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Cliente).HasMaxLength(255);

                entity.Property(e => e.Datos)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Estacion).HasMaxLength(255);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Importe).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.NameCenter)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Precio).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VwContactPersonName>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ContactPersonName");

                entity.Property(e => e.IdContactPerson).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(511);
            });

            modelBuilder.Entity<VwContingenciasArreglar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ContingenciasArreglar");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CommentsCancel).HasMaxLength(255);

                entity.Property(e => e.ContingencyClientGroup).HasColumnName("Contingency_ClientGroup");

                entity.Property(e => e.ContingencyDriver).HasColumnName("Contingency_Driver");

                entity.Property(e => e.ContingencyEmployee).HasColumnName("Contingency_Employee");

                entity.Property(e => e.ContingencyEmployee1).HasColumnName("Contingency_Employee1");

                entity.Property(e => e.ContingencyFuelType).HasColumnName("Contingency_FuelType");

                entity.Property(e => e.ContingencyGasStation).HasColumnName("Contingency_GasStation");

                entity.Property(e => e.ContingencyStatusContingency).HasColumnName("Contingency_StatusContingency");

                entity.Property(e => e.ContingencyTypeContigency).HasColumnName("Contingency_TypeContigency");

                entity.Property(e => e.ContingencyVehicle).HasColumnName("Contingency_Vehicle");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateFinishAtcnoc)
                    .HasColumnName("DateFinishATCNOC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateFinishFinanzas).HasColumnType("datetime");

                entity.Property(e => e.DateTimeContingency).HasColumnType("datetime");

                entity.Property(e => e.DatetimeStamp).HasColumnType("datetime");

                entity.Property(e => e.MessageError)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NameDispatcher)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NcontrolGas)
                    .HasColumnName("NControlGas")
                    .HasMaxLength(255);

                entity.Property(e => e.NumberPump)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NumberTransaction)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PathInvoice).HasMaxLength(255);

                entity.Property(e => e.PriceUnit).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<VwContingencyReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ContingencyReport");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ContingencyStatusContingency).HasColumnName("Contingency_StatusContingency");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeContingency).HasColumnType("datetime");

                entity.Property(e => e.MessageError)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.NickName).HasMaxLength(255);

                entity.Property(e => e.NumberPump)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NumberTransaction)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwContingencys>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Contingencys");

                entity.Property(e => e.Client)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateTimeContingency).HasColumnType("datetime");

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameCedi)
                    .IsRequired()
                    .HasColumnName("NameCEDI")
                    .HasMaxLength(255);

                entity.Property(e => e.NameGasStation).HasMaxLength(255);

                entity.Property(e => e.NumControlGas).HasMaxLength(255);

                entity.Property(e => e.NumberClientCg)
                    .HasColumnName("NumberClientCG")
                    .HasMaxLength(255);

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwDespachos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Despachos");

                entity.Property(e => e.CodCli).HasColumnName("codCli");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Eco)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EstControlGas).HasMaxLength(255);

                entity.Property(e => e.Estacion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Flota)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Grupo).HasMaxLength(255);

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Litros).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Monto).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.NumberStation)
                    .IsRequired()
                    .HasColumnName("numberStation")
                    .HasMaxLength(10);

                entity.Property(e => e.Odometro).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwDespachosC>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DespachosC");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("Cod_Cliente")
                    .HasMaxLength(255);

                entity.Property(e => e.CodEstacion).HasColumnName("Cod_Estacion");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Economico)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Estacion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Monto).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.NumDespacho).HasColumnName("Num_Despacho");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwDespachosNoFacturados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DespachosNoFacturados");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Cliente).HasMaxLength(255);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Economico).HasMaxLength(255);

                entity.Property(e => e.Estacion).HasMaxLength(255);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Hora)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Monto).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Placa).HasMaxLength(255);

                entity.Property(e => e.Producto).HasMaxLength(255);
            });

            modelBuilder.Entity<VwDispatchedWithoutMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DispatchedWithoutMessage");

                entity.Property(e => e.Client)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCode)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CodGasstation).HasColumnName("CodGASStation");

                entity.Property(e => e.DespDateTime).HasColumnType("datetime");

                entity.Property(e => e.GasStation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NickNameGasStation)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumbwerEco)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Plate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TranDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwEdcTimbrado>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EdcTimbrado");

                entity.Property(e => e.Depositos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Estatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaPeriodaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaPeriodoInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaTimbrado).HasColumnType("datetime");

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(255);

                entity.Property(e => e.SaldoFinal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaldoInicial).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<VwEstadosDeCuenta>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_EstadosDeCuenta");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Combustible).HasColumnType("money");

                entity.Property(e => e.Despachos).HasColumnType("money");

                entity.Property(e => e.Fechadesde).HasColumnType("datetime");

                entity.Property(e => e.Fechahasta).HasColumnType("datetime");

                entity.Property(e => e.Saldofinal).HasColumnType("money");

                entity.Property(e => e.Saldoinicial).HasColumnType("money");
            });

            modelBuilder.Entity<VwGetDispatchForEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetDispatchForEvent");

                entity.Property(e => e.DatetimeEnd).HasColumnType("datetime");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickName).HasMaxLength(255);

                entity.Property(e => e.OficialName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OficialNameStation)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RealCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RealVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<VwGetDispatchInner>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetDispatchInner");

                entity.Property(e => e.AllocateCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.AllocateVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.BillingDispatch).HasColumnName("BIlling_Dispatch");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CommentsDispatch)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateTimeContingency).HasColumnType("datetime");

                entity.Property(e => e.DatetimeEnd).HasColumnType("datetime");

                entity.Property(e => e.DatetimeInvoicing).HasColumnType("datetime");

                entity.Property(e => e.DatetimeStart).HasColumnType("datetime");

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaTimbrado).HasColumnType("datetime");

                entity.Property(e => e.IdContingency)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MessageError)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameStatus)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickNameGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NicknameStation).HasMaxLength(255);

                entity.Property(e => e.Odometer).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.OficialNameStation)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PublicId).HasColumnName("PublicID");

                entity.Property(e => e.RealCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RealVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StatusContigency)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TypeFuel).HasMaxLength(255);
            });

            modelBuilder.Entity<VwGetDispatchs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetDispatchs");

                entity.Property(e => e.AllocateCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.AllocateVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.BillingDispatch).HasColumnName("BIlling_Dispatch");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CediAnterior)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CommentsDispatch)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateTimeContingency).HasColumnType("datetime");

                entity.Property(e => e.DatetimeEnd).HasColumnType("datetime");

                entity.Property(e => e.DatetimeInvoicing).HasColumnType("datetime");

                entity.Property(e => e.DatetimeStart).HasColumnType("datetime");

                entity.Property(e => e.DriverName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaEdc)
                    .HasColumnName("FechaEDC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEde)
                    .HasColumnName("FechaEDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FolioEdc).HasColumnName("FolioEDC");

                entity.Property(e => e.FolioEde).HasColumnName("FolioEDE");

                entity.Property(e => e.IdContingency)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IdTimeZone)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MessageError)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameCenter)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameStatus)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickNameGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NicknameStation).HasMaxLength(255);

                entity.Property(e => e.Odometer).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.OficialNameStation)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PublicId).HasColumnName("PublicID");

                entity.Property(e => e.RealCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RealVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StatusContigency)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TypeFuel).HasMaxLength(255);
            });

            modelBuilder.Entity<VwGetDispatchsContigency>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetDispatchsContigency");

                entity.Property(e => e.AllocateCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.AllocateVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.BillingDispatch).HasColumnName("BIlling_Dispatch");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CediAnterior)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CommentsDispatch)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateTimeContingency).HasColumnType("datetime");

                entity.Property(e => e.DatetimeEnd).HasColumnType("datetime");

                entity.Property(e => e.DatetimeInvoicing).HasColumnType("datetime");

                entity.Property(e => e.DatetimeStart).HasColumnType("datetime");

                entity.Property(e => e.DriverName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaEdc)
                    .HasColumnName("FechaEDC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEde)
                    .HasColumnName("FechaEDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FolioEdc).HasColumnName("FolioEDC");

                entity.Property(e => e.FolioEde).HasColumnName("FolioEDE");

                entity.Property(e => e.IdContingency)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IdTimeZone)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MessageError)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameCenter)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameStatus)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickNameGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NicknameStation).HasMaxLength(255);

                entity.Property(e => e.Odometer).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.OficialNameStation)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PublicId).HasColumnName("PublicID");

                entity.Property(e => e.RealCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RealVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StatusContigency)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TypeFuel)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwGetDispatchsMultiSelection>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetDispatchsMultiSelection");

                entity.Property(e => e.AddressCity)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AllocateCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.AllocateVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CediAnterior)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CommentsDispatch)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateTimeDispatch).HasColumnType("datetime");

                entity.Property(e => e.DatetimeCanceled).HasColumnType("datetime");

                entity.Property(e => e.DatetimeEnd).HasColumnType("datetime");

                entity.Property(e => e.DatetimeInvoicing).HasColumnType("datetime");

                entity.Property(e => e.DatetimeStart).HasColumnType("datetime");

                entity.Property(e => e.DeltaValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DriverName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EstimatedFuelCons).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.FechaEdc)
                    .HasColumnName("FechaEDC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEde)
                    .HasColumnName("FechaEDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FolioEdc).HasColumnName("FolioEDC");

                entity.Property(e => e.FolioEde).HasColumnName("FolioEDE");

                entity.Property(e => e.IdContingency)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IdTimeZone)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Ieps)
                    .HasColumnName("IEPS")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.MessageError)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameCenter)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameCity)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameStatus)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickNameGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NicknameStation).HasMaxLength(255);

                entity.Property(e => e.OdoOld).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Odometer).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.OficialNameStation)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PriceUnit).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.PublicId).HasColumnName("PublicID");

                entity.Property(e => e.RealCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RealVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.RendimObjetivo).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(20);

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StatusContigency)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tar).HasColumnName("TAR");

                entity.Property(e => e.TypeFuel)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(255);

                entity.Property(e => e.VolumeOld).HasColumnType("decimal(8, 3)");
            });

            modelBuilder.Entity<VwGetDispatchsMultiSelectionQv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetDispatchsMultiSelectionQV");

                entity.Property(e => e.AddressCity)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AllocateCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.AllocateVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CediAnterior)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CommentsDispatch)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateTimeDispatch).HasColumnType("datetime");

                entity.Property(e => e.DatetimeCanceled).HasColumnType("datetime");

                entity.Property(e => e.DatetimeEnd).HasColumnType("datetime");

                entity.Property(e => e.DatetimeInvoicing).HasColumnType("datetime");

                entity.Property(e => e.DatetimeStart).HasColumnType("datetime");

                entity.Property(e => e.DeltaValue).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DriverName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EstimatedFuelCons).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.FechaEdc)
                    .HasColumnName("FechaEDC")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEde)
                    .HasColumnName("FechaEDE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FolioEdc).HasColumnName("FolioEDC");

                entity.Property(e => e.FolioEde).HasColumnName("FolioEDE");

                entity.Property(e => e.IdContingency)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IdTimeZone)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Ieps)
                    .HasColumnName("IEPS")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Iva).HasColumnName("IVA");

                entity.Property(e => e.MessageError)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameCenter)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameCity)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameStatus)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickNameGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NicknameStation).HasMaxLength(255);

                entity.Property(e => e.OdoOld).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Odometer).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.OdometerNoTratado).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.OficialNameStation)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PriceUnit).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.PublicId).HasColumnName("PublicID");

                entity.Property(e => e.RealCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.RealVolume).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.RendimObjetivo).HasColumnType("decimal(10, 6)");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(20);

                entity.Property(e => e.StationNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StatusContigency)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tar).HasColumnName("TAR");

                entity.Property(e => e.TypeFuel)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(255);

                entity.Property(e => e.VolumeOld).HasColumnType("decimal(8, 3)");
            });

            modelBuilder.Entity<VwGetGpsInstalled>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetGpsInstalled");

                entity.Property(e => e.Cedi)
                    .IsRequired()
                    .HasColumnName("CEDI")
                    .HasMaxLength(255);

                entity.Property(e => e.Clientes)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Eco)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Embarque).HasMaxLength(255);

                entity.Property(e => e.FechaDeEmbarque)
                    .HasColumnName("Fecha de Embarque")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaDeInstalación)
                    .HasColumnName("Fecha de instalación")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOdometro)
                    .HasColumnName("Fecha odometro")
                    .HasColumnType("datetime");

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(255);

                entity.Property(e => e.NúmCliente).HasColumnName("Núm. Cliente");

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Serial).HasMaxLength(255);
            });

            modelBuilder.Entity<VwGetSiteAccessQv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetSiteAccessQV");

                entity.Property(e => e.AccessProfileQv)
                    .IsRequired()
                    .HasColumnName("AccessProfileQV")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NickNameCedis)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickNameClientgroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.Pass).HasMaxLength(510);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<VwGetVehicles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwGetVehicles");

                entity.Property(e => e.CostCenter).HasMaxLength(255);

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NameStatus)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PublicId).HasColumnName("PublicID");

                entity.Property(e => e.RulesVehicle).HasColumnName("Rules_Vehicle");

                entity.Property(e => e.SearchProperty1)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.SearchProperty2).HasMaxLength(80);

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwGetVehiclesCg>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_getVehiclesCG");

                entity.Property(e => e.Nroeco)
                    .HasColumnName("nroeco")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NrovehCg).HasColumnName("NrovehCG");

                entity.Property(e => e.Plate)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwGpsReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_GpsReport");

                entity.Property(e => e.Caja).HasMaxLength(255);

                entity.Property(e => e.Cedi)
                    .IsRequired()
                    .HasColumnName("CEDI")
                    .HasMaxLength(255);

                entity.Property(e => e.Cliente).HasMaxLength(255);

                entity.Property(e => e.DateGpsSim).HasColumnType("datetime");

                entity.Property(e => e.DatePackage).HasColumnType("datetime");

                entity.Property(e => e.FechaInstalacion)
                    .HasColumnName("Fecha_Instalacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaOdometro)
                    .HasColumnName("Fecha_Odometro")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCedi).HasColumnName("Id_Cedi");

                entity.Property(e => e.IdClienteGrupo).HasColumnName("Id_ClienteGrupo");

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(255);

                entity.Property(e => e.NumeroEco)
                    .IsRequired()
                    .HasColumnName("Numero_Eco")
                    .HasMaxLength(255);

                entity.Property(e => e.NumeroTelefono)
                    .HasColumnName("Numero_Telefono")
                    .HasMaxLength(255);

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Sim)
                    .HasColumnName("SIM")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitIdhex)
                    .HasColumnName("UnitIDHex")
                    .HasMaxLength(255);

                entity.Property(e => e.ValorOdometer).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<VwPaymentsToStations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PaymentsToStations");

                entity.Property(e => e.Edefacturado).HasColumnName("EDEFacturado");

                entity.Property(e => e.FechaPeriodaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaPeriodoInicio).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ImporteComision).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Iva).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IvaComision).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NombreEstacion)
                    .IsRequired()
                    .HasMaxLength(180);

                entity.Property(e => e.NombreWebAccess).HasMaxLength(255);

                entity.Property(e => e.NumeroEstacion)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PorcentajeComision).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(20);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalComision).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalaPagar).HasColumnType("decimal(21, 4)");
            });

            modelBuilder.Entity<VwPerfilParametroPorCliente>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PerfilParametroPorCliente");

                entity.Property(e => e.Comentarios)
                    .HasColumnName("comentarios")
                    .HasMaxLength(255);

                entity.Property(e => e.CreadoPor)
                    .HasColumnName("creadoPor")
                    .HasMaxLength(255);

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.IdParametro).HasColumnName("id_parametro");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwPhoneCouplingReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPhoneCouplingReport");

                entity.Property(e => e.Cedis).HasMaxLength(255);

                entity.Property(e => e.CedisTimeZoneKey).HasMaxLength(255);

                entity.Property(e => e.Clasificacion).HasMaxLength(255);

                entity.Property(e => e.DateUtc).HasColumnType("datetime");

                entity.Property(e => e.Direccion).HasMaxLength(255);

                entity.Property(e => e.Eco).HasMaxLength(255);

                entity.Property(e => e.NoEmpleado).HasMaxLength(255);

                entity.Property(e => e.Placa).HasMaxLength(255);

                entity.Property(e => e.Puesto).HasMaxLength(255);

                entity.Property(e => e.Region).HasMaxLength(255);

                entity.Property(e => e.Usuario).HasMaxLength(255);
            });

            modelBuilder.Entity<VwPlanTrabajoTecnicos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PlanTrabajoTecnicos");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.FechaAproxCierre)
                    .HasColumnName("Fecha_Aprox_Cierre")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("Fecha_Inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPrioridad).HasColumnName("Id_Prioridad");

                entity.Property(e => e.IdServicio).HasColumnName("Id_Servicio");

                entity.Property(e => e.IdTecnico).HasColumnName("Id_Tecnico");

                entity.Property(e => e.NumeroCita).HasColumnName("Numero_Cita");

                entity.Property(e => e.Prioridad)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Servicio)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Tecnico)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwPossibleFailuresAuthorizing>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PossibleFailuresAuthorizing");

                entity.Property(e => e.Abr)
                    .HasColumnName("abr")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AcuTur)
                    .HasColumnName("acuTur")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Codcli).HasColumnName("codcli");

                entity.Property(e => e.Codgas).HasColumnName("codgas");

                entity.Property(e => e.Cveest)
                    .HasColumnName("cveest")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Den)
                    .HasColumnName("den")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Est)
                    .HasColumnName("est")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstVehNew).HasColumnName("estVehNew");

                entity.Property(e => e.EstVehOri).HasColumnName("estVehOri");

                entity.Property(e => e.Expr1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Expr2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FchEstacion)
                    .HasColumnName("fchEstacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FchLog)
                    .HasColumnName("fchLog")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fchserver)
                    .HasColumnName("fchserver")
                    .HasColumnType("datetime");

                entity.Property(e => e.NewOdm).HasColumnName("newOdm");

                entity.Property(e => e.Nroeco)
                    .HasColumnName("nroeco")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumDeDesp).HasColumnName("numDeDesp");

                entity.Property(e => e.Numref).HasColumnName("numref");

                entity.Property(e => e.Plc)
                    .HasColumnName("plc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .HasColumnName("tag")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UltOdm).HasColumnName("ultOdm");

                entity.Property(e => e.Ultcar)
                    .HasColumnName("ultcar")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ulttur)
                    .HasColumnName("ulttur")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPreciosEstacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PreciosEstacion");

                entity.Property(e => e.Iesp)
                    .HasColumnName("IESP")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VwPriceGas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PriceGas");

                entity.Property(e => e.Codprd).HasColumnName("codprd");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Precios)
                    .HasColumnName("precios")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VwQvallUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwQVAllUsers");

                entity.Property(e => e.Access)
                    .IsRequired()
                    .HasColumnName("ACCESS")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepósitoVehículoSa)
                    .IsRequired()
                    .HasColumnName("_Depósito_vehículo_SA")
                    .HasMaxLength(255);

                entity.Property(e => e.MarcaClienteSa)
                    .HasColumnName("_Marca_Cliente_SA")
                    .HasMaxLength(20);

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OficialName).HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(20);

                entity.Property(e => e.RegiónVehículoSa)
                    .IsRequired()
                    .HasColumnName("_Región_vehículo_SA")
                    .HasMaxLength(255);

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VwReporteEstaciones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ReporteEstaciones");

                entity.Property(e => e.Calle).HasMaxLength(250);

                entity.Property(e => e.CelularContacto).HasMaxLength(255);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Colonia).HasMaxLength(100);

                entity.Property(e => e.Colony).HasMaxLength(255);

                entity.Property(e => e.Cp)
                    .HasColumnName("CP")
                    .HasMaxLength(5);

                entity.Property(e => e.Cpaddres)
                    .IsRequired()
                    .HasColumnName("CPAddres")
                    .HasMaxLength(255);

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Latitud).HasMaxLength(255);

                entity.Property(e => e.Localidad).HasMaxLength(200);

                entity.Property(e => e.Longitud).HasMaxLength(255);

                entity.Property(e => e.Mail)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.MailContacto).HasMaxLength(255);

                entity.Property(e => e.Municipio).HasMaxLength(100);

                entity.Property(e => e.NickName).HasMaxLength(255);

                entity.Property(e => e.NickNameEstacionGrupo).HasMaxLength(255);

                entity.Property(e => e.NoExterior).HasMaxLength(10);

                entity.Property(e => e.NoInterior).HasMaxLength(10);

                entity.Property(e => e.NombreContacto).HasMaxLength(511);

                entity.Property(e => e.NombreOficial)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NumeroEstacion)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.OficialNameEstacionGrupo).HasMaxLength(255);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Phone2).HasMaxLength(255);

                entity.Property(e => e.PorcentajeComision).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RazonSocial).HasMaxLength(180);

                entity.Property(e => e.RepresentanteLegal).HasMaxLength(255);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(20);

                entity.Property(e => e.Street1)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Street2).HasMaxLength(255);

                entity.Property(e => e.Volumetrico).HasMaxLength(255);
            });

            modelBuilder.Entity<VwReporteOpFinanzas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ReporteOpFinanzas");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Codopr).HasColumnName("codopr");

                entity.Property(e => e.Cuenta)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fchvto).HasColumnName("fchvto");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mtoopecnv).HasColumnName("mtoopecnv");

                entity.Property(e => e.Mtopenori).HasColumnName("mtopenori");

                entity.Property(e => e.Nrocta).HasColumnName("nrocta");

                entity.Property(e => e.Nroope).HasColumnName("nroope");

                entity.Property(e => e.Operacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipope).HasColumnName("tipope");
            });

            modelBuilder.Entity<VwReportePagoEdc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_ReportePagoEDC");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cliente).HasMaxLength(255);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FechaCancelacion).HasColumnType("datetime");

                entity.Property(e => e.FechaPeriodaFin).HasColumnType("datetime");

                entity.Property(e => e.FechaPeriodoInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaTimbrado).HasColumnType("datetime");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("RFC")
                    .HasMaxLength(20);

                entity.Property(e => e.SaldoFinal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SaldoInicial).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<VwSubrerporte>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_subrerporte");

                entity.Property(e => e.GranTotal).HasColumnType("numeric(1, 1)");

                entity.Property(e => e.OficialName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Total).HasColumnType("numeric(1, 1)");
            });

            modelBuilder.Entity<VwUsersInClientGroupSet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UsersInClientGroupSet");

                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UsersInClientGroupClientGroup).HasColumnName("UsersInClientGroup_ClientGroup");

                entity.Property(e => e.UsersInClientGroupGasStationGroup).HasColumnName("UsersInClientGroup_GasStationGroup");

                entity.Property(e => e.UsersInClientGroupUserWeb).HasColumnName("UsersInClientGroup_UserWeb");
            });

            modelBuilder.Entity<VwVehiclesProducts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_VehiclesProducts");

                entity.Property(e => e.ActivationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Box).HasMaxLength(255);

                entity.Property(e => e.ComentariosGps).HasMaxLength(255);

                entity.Property(e => e.DateGpsSim).HasColumnType("datetime");

                entity.Property(e => e.DateInstallation).HasColumnType("datetime");

                entity.Property(e => e.EcoNumber)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EstatusVehiculo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Fw).HasMaxLength(255);

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(255);

                entity.Property(e => e.NickNameCliente)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.NicknameGroup)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OdometerDate).HasColumnType("datetime");

                entity.Property(e => e.OficialNameGroup).HasMaxLength(255);

                entity.Property(e => e.ParamVersion).HasMaxLength(255);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PublicId).HasColumnName("PublicID");

                entity.Property(e => e.RazonReemplazo).HasMaxLength(255);

                entity.Property(e => e.Serial).HasMaxLength(255);

                entity.Property(e => e.ServiceDataTime).HasColumnType("datetime");

                entity.Property(e => e.Sid)
                    .HasColumnName("SID")
                    .HasMaxLength(255);

                entity.Property(e => e.TagServiceDataTime).HasColumnType("datetime");

                entity.Property(e => e.TipoMeter).HasMaxLength(255);

                entity.Property(e => e.TipoTag).HasMaxLength(255);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(16);

                entity.Property(e => e.UnitId)
                    .HasColumnName("UnitID")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitIdhex)
                    .HasColumnName("UnitIDHex")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitType).HasMaxLength(255);

                entity.Property(e => e.ValorOdometer).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<WeeklyReportSet>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(255);

                entity.Property(e => e.DateTimeUpload)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RowVersion)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
