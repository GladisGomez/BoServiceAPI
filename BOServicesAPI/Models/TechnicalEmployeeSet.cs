using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TechnicalEmployeeSet
    {
        public TechnicalEmployeeSet()
        {
            Employees = new HashSet<Employees>();
        }

        public int Id { get; set; }
        public string HexColor { get; set; }
        public bool ResponsibleAppointment { get; set; }
        public DateTime? StartOutOffice { get; set; }
        public DateTime? EndOutOffice { get; set; }
        public string DaysOfWeek { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? TechnicalEmployeeCity { get; set; }
        public int? TechnicalEmployeeExpertise { get; set; }

        public virtual CitySet TechnicalEmployeeCityNavigation { get; set; }
        public virtual ExpertiseSet TechnicalEmployeeExpertiseNavigation { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
