using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    public class UserDTOS
    {
        [Required]
        public string User { get; set; }

        [Required]
        public string Pass { get; set; }

    }
}
