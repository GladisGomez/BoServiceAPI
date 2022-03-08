using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ClientGroups
    {
        public ClientGroups()
        {
            BalanceTransactionsSet = new HashSet<BalanceTransactionsSet>();
            BillingSet = new HashSet<BillingSet>();
            CallRecordSet = new HashSet<CallRecordSet>();
            ClientGroupInGpsSet = new HashSet<ClientGroupInGpsSet>();
            Clients = new HashSet<Clients>();
            ConfiguracionDescuentoEdset = new HashSet<ConfiguracionDescuentoEdset>();
            ContactPersons = new HashSet<ContactPersons>();
            ContingencySet = new HashSet<ContingencySet>();
            ControlCompanies = new HashSet<ControlCompanies>();
            CostCenterSet = new HashSet<CostCenterSet>();
            CreditConfigSet = new HashSet<CreditConfigSet>();
            DatosFiscalesSet = new HashSet<DatosFiscalesSet>();
            DepositosSet = new HashSet<DepositosSet>();
            EmployeeRolesSet = new HashSet<EmployeeRolesSet>();
            FeeCommisionSet = new HashSet<FeeCommisionSet>();
            GasStations = new HashSet<GasStations>();
            ProfileInClientGroupSet = new HashSet<ProfileInClientGroupSet>();
            RelacionEdcclienteSet = new HashSet<RelacionEdcclienteSet>();
            ReportVts = new HashSet<ReportVts>();
            RoleClientGroupSet = new HashSet<RoleClientGroupSet>();
            RulesClientSet = new HashSet<RulesClientSet>();
            SaldosSet = new HashSet<SaldosSet>();
            UsersInClientGroupSet = new HashSet<UsersInClientGroupSet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public int? ParentId { get; set; }
        public string OficialName { get; set; }
        public string NickName { get; set; }
        public int PublicClientNumber { get; set; }
        public int Status { get; set; }
        public string IdTotvs { get; set; }
        public decimal CreditMaximum { get; set; }
        public decimal BalanceCalculated { get; set; }
        public bool? SendMailForContingency { get; set; }
        public bool? SendMailForReportVt { get; set; }
        public bool? ShowEco { get; set; }
        public Guid? Guidservices { get; set; }
        public int? BalanceCalculatedAlertThreshold { get; set; }
        public DateTime? BalanceCalculatedAlertThresholdLast { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int? ClientGroupAddress { get; set; }
        public int? CatMetodoPagoClientGroup { get; set; }
        public int? CuotasEdClientGroup { get; set; }
        public int? ConfiguracionEdClientGroup { get; set; }
        public int? ClientGroupEmployee { get; set; }
        public int? FormaDePagoClientGroup { get; set; }
        public int? SaldosLimitConfigClientGroup { get; set; }
        public int? ClientGroupTypeAccount { get; set; }
        public int? ControlCompanyClientGroup { get; set; }
        public int? ParentCompany { get; set; }

        public virtual CatMetodoPagoSet CatMetodoPagoClientGroupNavigation { get; set; }
        public virtual Addresses ClientGroupAddressNavigation { get; set; }
        public virtual Employees ClientGroupEmployeeNavigation { get; set; }
        public virtual TypeAccountSet ClientGroupTypeAccountNavigation { get; set; }
        public virtual ConfiguracionEdset ConfiguracionEdClientGroupNavigation { get; set; }
        public virtual ControlCompanies ControlCompanyClientGroupNavigation { get; set; }
        public virtual CuotasEdset CuotasEdClientGroupNavigation { get; set; }
        public virtual FormaDePagoSet FormaDePagoClientGroupNavigation { get; set; }
        public virtual SaldosLimitConfigSet SaldosLimitConfigClientGroupNavigation { get; set; }
        public virtual ICollection<BalanceTransactionsSet> BalanceTransactionsSet { get; set; }
        public virtual ICollection<BillingSet> BillingSet { get; set; }
        public virtual ICollection<CallRecordSet> CallRecordSet { get; set; }
        public virtual ICollection<ClientGroupInGpsSet> ClientGroupInGpsSet { get; set; }
        public virtual ICollection<Clients> Clients { get; set; }
        public virtual ICollection<ConfiguracionDescuentoEdset> ConfiguracionDescuentoEdset { get; set; }
        public virtual ICollection<ContactPersons> ContactPersons { get; set; }
        public virtual ICollection<ContingencySet> ContingencySet { get; set; }
        public virtual ICollection<ControlCompanies> ControlCompanies { get; set; }
        public virtual ICollection<CostCenterSet> CostCenterSet { get; set; }
        public virtual ICollection<CreditConfigSet> CreditConfigSet { get; set; }
        public virtual ICollection<DatosFiscalesSet> DatosFiscalesSet { get; set; }
        public virtual ICollection<DepositosSet> DepositosSet { get; set; }
        public virtual ICollection<EmployeeRolesSet> EmployeeRolesSet { get; set; }
        public virtual ICollection<FeeCommisionSet> FeeCommisionSet { get; set; }
        public virtual ICollection<GasStations> GasStations { get; set; }
        public virtual ICollection<ProfileInClientGroupSet> ProfileInClientGroupSet { get; set; }
        public virtual ICollection<RelacionEdcclienteSet> RelacionEdcclienteSet { get; set; }
        public virtual ICollection<ReportVts> ReportVts { get; set; }
        public virtual ICollection<RoleClientGroupSet> RoleClientGroupSet { get; set; }
        public virtual ICollection<RulesClientSet> RulesClientSet { get; set; }
        public virtual ICollection<SaldosSet> SaldosSet { get; set; }
        public virtual ICollection<UsersInClientGroupSet> UsersInClientGroupSet { get; set; }
    }
}
