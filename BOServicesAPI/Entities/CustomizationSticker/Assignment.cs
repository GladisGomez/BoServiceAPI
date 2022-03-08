using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities.CustomizationSticker
{
    public class Assignment
    {

        [Required]
        public string urlFile { get; set; }

        [Required]
        public int IdUserWebSet { get; set; }
    }
}
