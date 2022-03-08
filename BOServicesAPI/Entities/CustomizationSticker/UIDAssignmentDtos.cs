using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    public class UIDAssignmentDtos
    {
        [Required]
        public string UID { get; set; }
        [Required]
        public string SIDPers { get; set; }

        public  string PO { get; set; }

        public string CatalogNumber { get; set; }

        public long Barcode { get; set; }
        [Required]
        public string Lot { get; set; }
    }
}
