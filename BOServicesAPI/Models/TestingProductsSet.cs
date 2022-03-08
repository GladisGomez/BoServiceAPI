using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class TestingProductsSet
    {
        public TestingProductsSet()
        {
            AccesoriesSet = new HashSet<AccesoriesSet>();
        }

        public int Id { get; set; }
        public string TestDescription { get; set; }
        public string TestDate { get; set; }
        public string Comments { get; set; }
        public bool TestSucces { get; set; }
        public bool CreatedFromTechnical { get; set; }
        public bool CreatedFromNoc { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }
        public int? TestingProductsEmployee { get; set; }
        public int? TestingProductsEmployee1 { get; set; }

        public virtual Employees TestingProductsEmployee1Navigation { get; set; }
        public virtual Employees TestingProductsEmployeeNavigation { get; set; }
        public virtual ICollection<AccesoriesSet> AccesoriesSet { get; set; }
    }
}
