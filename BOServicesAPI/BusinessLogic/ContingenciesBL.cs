using BOServicesAPI.DBContext;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.BusinessLogic
{
    public class ContingenciesBL
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;

        public ContingenciesBL(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
    }
}
