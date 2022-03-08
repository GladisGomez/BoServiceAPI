using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class Client
    {
        public Client()
        {
            CallRecordSets = new HashSet<CallRecordSet>();
            ChangeRequestPlateSets = new HashSet<ChangeRequestPlateSet>();
            ContactPeople = new HashSet<ContactPerson>();
            ContingencyWithoutVehicleSets = new HashSet<ContingencyWithoutVehicleSet>();
            DetalleEdcsets = new HashSet<DetalleEdcset>();
            HistoryVehiclesSets = new HashSet<HistoryVehiclesSet>();
            ProfileInClientSets = new HashSet<ProfileInClientSet>();
            ReportForClients = new HashSet<ReportForClient>();
            RoleClientSets = new HashSet<RoleClientSet>();
            UsersInProfileSets = new HashSet<UsersInProfileSet>();
            VehiclePhoneCouplingSets = new HashSet<VehiclePhoneCouplingSet>();
            Vehicles = new HashSet<Vehicle>();
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

        public virtual Address ClientAddressNavigation { get; set; }
        public virtual ClientGroup ClientGroupClientNavigation { get; set; }
        public virtual TimeZoneCset TimeZoneCClientNavigation { get; set; }
        public virtual ICollection<CallRecordSet> CallRecordSets { get; set; }
        public virtual ICollection<ChangeRequestPlateSet> ChangeRequestPlateSets { get; set; }
        public virtual ICollection<ContactPerson> ContactPeople { get; set; }
        public virtual ICollection<ContingencyWithoutVehicleSet> ContingencyWithoutVehicleSets { get; set; }
        public virtual ICollection<DetalleEdcset> DetalleEdcsets { get; set; }
        public virtual ICollection<HistoryVehiclesSet> HistoryVehiclesSets { get; set; }
        public virtual ICollection<ProfileInClientSet> ProfileInClientSets { get; set; }
        public virtual ICollection<ReportForClient> ReportForClients { get; set; }
        public virtual ICollection<RoleClientSet> RoleClientSets { get; set; }
        public virtual ICollection<UsersInProfileSet> UsersInProfileSets { get; set; }
        public virtual ICollection<VehiclePhoneCouplingSet> VehiclePhoneCouplingSets { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
