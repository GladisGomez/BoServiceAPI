using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class SamcommandsSet
    {
        public SamcommandsSet()
        {
            SamrolComandoSet = new HashSet<SamrolComandoSet>();
        }

        public int Id { get; set; }
        public int IdCommand { get; set; }
        public string NameCommand { get; set; }
        public int? NumberOfParameters { get; set; }
        public bool FlagDb { get; set; }
        public string ExampleCommand { get; set; }
        public string DescriptionCommand { get; set; }
        public string NickName { get; set; }
        public int TypeControl { get; set; }
        public string Condition { get; set; }
        public string TableDb { get; set; }
        public string Columns { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<SamrolComandoSet> SamrolComandoSet { get; set; }
    }
}
