using BOServicesAPI.BusinessLogic;
using BOServicesAPI.DataBase;
using BOServicesAPI.DBContext;
using BOServicesAPI.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StationsController : Controller
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;
        private StationsBL _bl;
        private StationsDB _db;

        public StationsController(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _bl = new StationsBL(_context, _configuration);
            _db = new StationsDB(_context);
        }

        // GET: api/Stations    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of Gas Stations
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpGet("GetGasStations")]
        public IEnumerable<AuxStations> GetGasStations()
        {
            try
            {
                return _db.GetGasStations();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
