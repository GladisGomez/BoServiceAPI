using BOServicesAPI.DBContext;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.BusinessLogic
{
    public class WorkLogBL
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;

        public WorkLogBL(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
    }
}
