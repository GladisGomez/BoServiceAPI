using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities.CustomizationSticker
{
    public class CustomSid
    {
        [Required]
        public string SidPersonalizado { get; set; }

        [Required]
        public int IdUserWebSet { get; set; }
    }
}
