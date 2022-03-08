using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BOServicesAPI.Models
{
    public partial class ContractFacSet
    {
        public ContractFacSet()
        {
            HistoryContractFacSet = new HashSet<HistoryContractFacSet>();
        }

        public int Id { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }
        public bool Active { get; set; }
        public int TotalFolio { get; set; }
        public int FolioAlert { get; set; }
        public int FolioDays { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ICollection<HistoryContractFacSet> HistoryContractFacSet { get; set; }
    }
}
