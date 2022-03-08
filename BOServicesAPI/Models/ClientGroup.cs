using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class ClientGroup
    {
        public ClientGroup()
        {
            BalanceTransactionsSets = new HashSet<BalanceTransactionsSet>();
            BillingSets = new HashSet<BillingSet>();
            CallRecordSets = new HashSet<CallRecordSet>();
            ClientGroupInGpsSets = new HashSet<ClientGroupInGpsSet>();
            Clients = new HashSet<Client>();
            ConfiguracionDescuentoEdsets = new HashSet<ConfiguracionDescuentoEdset>();
            ContactPeople = new HashSet<ContactPerson>();
            ContingencySets = new HashSet<ContingencySet>();
            CostCenterSets = new HashSet<CostCenterSet>();
            CreditConfigSets = new HashSet<CreditConfigSet>();
            DatosFiscalesSets = new HashSet<DatosFiscalesSet>();
            DepositosSets = new HashSet<DepositosSet>();
            EmployeeRolesSets = new HashSet<EmployeeRolesSet>();
            FeeCommisionSets = new HashSet<FeeCommisionSet>();
            GasStations = new HashSet<GasStation>();
            ProfileInClientGroupSets = new HashSet<ProfileInClientGroupSet>();
            RelacionEdcclienteSets = new HashSet<RelacionEdcclienteSet>();
            ReportVts = new HashSet<ReportVt>();
            RoleClientGroupSets = new HashSet<RoleClientGroupSet>();
            RulesClientSets = new HashSet<RulesClientSet>();
            SaldosSets = new HashSet<SaldosSet>();
            UsersInClientGroupSets = new HashSet<UsersInClientGroupSet>();
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

        public virtual CatMetodoPagoSet CatMetodoPagoClientGroupNavigation { get; set; }
        public virtual Address ClientGroupAddressNavigation { get; set; }
        public virtual Employee ClientGroupEmployeeNavigation { get; set; }
        public virtual TypeAccountSet ClientGroupTypeAccountNavigation { get; set; }
        public virtual ConfiguracionEdset ConfiguracionEdClientGroupNavigation { get; set; }
        public virtual CuotasEdset CuotasEdClientGroupNavigation { get; set; }
        public virtual FormaDePagoSet FormaDePagoClientGroupNavigation { get; set; }
        public virtual SaldosLimitConfigSet SaldosLimitConfigClientGroupNavigation { get; set; }
        public virtual ICollection<BalanceTransactionsSet> BalanceTransactionsSets { get; set; }
        public virtual ICollection<BillingSet> BillingSets { get; set; }
        public virtual ICollection<CallRecordSet> CallRecordSets { get; set; }
        public virtual ICollection<ClientGroupInGpsSet> ClientGroupInGpsSets { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<ConfiguracionDescuentoEdset> ConfiguracionDescuentoEdsets { get; set; }
        public virtual ICollection<ContactPerson> ContactPeople { get; set; }
        public virtual ICollection<ContingencySet> ContingencySets { get; set; }
        public virtual ICollection<CostCenterSet> CostCenterSets { get; set; }
        public virtual ICollection<CreditConfigSet> CreditConfigSets { get; set; }
        public virtual ICollection<DatosFiscalesSet> DatosFiscalesSets { get; set; }
        public virtual ICollection<DepositosSet> DepositosSets { get; set; }
        public virtual ICollection<EmployeeRolesSet> EmployeeRolesSets { get; set; }
        public virtual ICollection<FeeCommisionSet> FeeCommisionSets { get; set; }
        public virtual ICollection<GasStation> GasStations { get; set; }
        public virtual ICollection<ProfileInClientGroupSet> ProfileInClientGroupSets { get; set; }
        public virtual ICollection<RelacionEdcclienteSet> RelacionEdcclienteSets { get; set; }
        public virtual ICollection<ReportVt> ReportVts { get; set; }
        public virtual ICollection<RoleClientGroupSet> RoleClientGroupSets { get; set; }
        public virtual ICollection<RulesClientSet> RulesClientSets { get; set; }
        public virtual ICollection<SaldosSet> SaldosSets { get; set; }
        public virtual ICollection<UsersInClientGroupSet> UsersInClientGroupSets { get; set; }
    }
}
