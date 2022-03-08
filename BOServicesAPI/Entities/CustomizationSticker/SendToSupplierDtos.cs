using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    public class SendToSupplierDtos
    {
        [Required]
        public int numberSids { get; set; }

        [Required]
        public int idModel { get; set; }

        [Required]
        public int IdUserWebSet { get; set; }
    }

  
}
