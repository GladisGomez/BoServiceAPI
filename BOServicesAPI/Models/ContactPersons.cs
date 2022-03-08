using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ContactPersons
    {
        public ContactPersons()
        {
            AlertAuthContingencySetAlertAuthContingencyContactPerson1Navigation = new HashSet<AlertAuthContingencySet>();
            AlertAuthContingencySetAlertAuthContingencyContactPersonNavigation = new HashSet<AlertAuthContingencySet>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Cellular1 { get; set; }
        public string Cellular2 { get; set; }
        public string CellularEmergency { get; set; }
        public bool IsAuthorizedToAllowFueling { get; set; }
        public bool IsAuthorizedToOrderWork { get; set; }
        public bool IsFinancialTrusty { get; set; }
        public bool IsOperationalTrusty { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Fax { get; set; }
        public string WorkingHoursFrom { get; set; }
        public string WorkingHoursTill { get; set; }
        public string WorkingDays { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public int? ContactPersonAddress { get; set; }
        public int? SubGroupContactPerson { get; set; }
        public int? ClientContactPerson { get; set; }
        public int? GasStationContactPerson { get; set; }

        public virtual Clients ClientContactPersonNavigation { get; set; }
        public virtual Addresses ContactPersonAddressNavigation { get; set; }
        public virtual GasStations GasStationContactPersonNavigation { get; set; }
        public virtual ClientGroups SubGroupContactPersonNavigation { get; set; }
        public virtual ICollection<AlertAuthContingencySet> AlertAuthContingencySetAlertAuthContingencyContactPerson1Navigation { get; set; }
        public virtual ICollection<AlertAuthContingencySet> AlertAuthContingencySetAlertAuthContingencyContactPersonNavigation { get; set; }
    }
}
