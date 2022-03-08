using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class Clients
    {
        public Clients()
        {
            CallRecordSet = new HashSet<CallRecordSet>();
            ChangeRequestPlateSet = new HashSet<ChangeRequestPlateSet>();
            ContactPersons = new HashSet<ContactPersons>();
            ContingencyWithoutVehicleSet = new HashSet<ContingencyWithoutVehicleSet>();
            DetalleEdcset = new HashSet<DetalleEdcset>();
            HistoryVehiclesSet = new HashSet<HistoryVehiclesSet>();
            ProfileInClientSet = new HashSet<ProfileInClientSet>();
            ReportForClients = new HashSet<ReportForClients>();
            RoleClientSet = new HashSet<RoleClientSet>();
            UsersInProfileSet = new HashSet<UsersInProfileSet>();
            VehiclePhoneCouplingSet = new HashSet<VehiclePhoneCouplingSet>();
            Vehicles = new HashSet<Vehicles>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string NickName { get; set; }
        public string NumberClientCg { get; set; }
        public int Status { get; set; }
        public bool IsSubGroup { get; set; }
        public string Comments { get; set; }
        public string IdTotvs { get; set; }
        public string IdSucursalTotvs { get; set; }
        public bool? SendMailForContingency { get; set; }
        public bool? SendMailForReportVt { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int? ClientAddress { get; set; }
        public int ClientGroupClient { get; set; }
        public int TimeZoneCClient { get; set; }

        public virtual Addresses ClientAddressNavigation { get; set; }
        public virtual ClientGroups ClientGroupClientNavigation { get; set; }
        public virtual TimeZoneCset TimeZoneCClientNavigation { get; set; }
        public virtual ICollection<CallRecordSet> CallRecordSet { get; set; }
        public virtual ICollection<ChangeRequestPlateSet> ChangeRequestPlateSet { get; set; }
        public virtual ICollection<ContactPersons> ContactPersons { get; set; }
        public virtual ICollection<ContingencyWithoutVehicleSet> ContingencyWithoutVehicleSet { get; set; }
        public virtual ICollection<DetalleEdcset> DetalleEdcset { get; set; }
        public virtual ICollection<HistoryVehiclesSet> HistoryVehiclesSet { get; set; }
        public virtual ICollection<ProfileInClientSet> ProfileInClientSet { get; set; }
        public virtual ICollection<ReportForClients> ReportForClients { get; set; }
        public virtual ICollection<RoleClientSet> RoleClientSet { get; set; }
        public virtual ICollection<UsersInProfileSet> UsersInProfileSet { get; set; }
        public virtual ICollection<VehiclePhoneCouplingSet> VehiclePhoneCouplingSet { get; set; }
        public virtual ICollection<Vehicles> Vehicles { get; set; }
    }
}
