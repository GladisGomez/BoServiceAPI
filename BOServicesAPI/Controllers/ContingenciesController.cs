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
    public class ContingenciesController : Controller
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;
        private ContingenciesBL _bl;
        private ContingenciesDB _db;

       public ContingenciesController(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _bl = new ContingenciesBL(_context, _configuration);
            _db = new ContingenciesDB(_context);
        }

        // GET: api/Contingencies   
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of Contingencies By Type
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpGet("GetContingenciesByType")]
        public IEnumerable<AuxContingencies> GetContingenciesByType(int TypeContingency)
        {
            try
            {
                return _db.GetContingenciesByType(TypeContingency);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // GET: api/Contingencies   
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of Contingencies By Client
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpGet("GetContingenciesByClientAndTypeContingency")]
        public IEnumerable<AuxContingencies> GetContingenciesByClientAndTypeContingency(int IdClient, int TypeContingency)
        {
            try
            {
                return _db.GetContingenciesByClientAndTypeContingency(IdClient,TypeContingency);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // GET: api/Contingencies   
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list of Contingencies By Station
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpGet("GetContingenciesByStationAndTypeContingency")]
        public IEnumerable<AuxContingencies> GetContingenciesByStationAndTypeContingency(int IdStation,int TypeContingency)
        {
            try
            {
                return _db.GetContingenciesByStationAndTypeContingency(IdStation, TypeContingency);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // POST: api/Contingencies    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to insert a Contingency
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("InsertContingencyData")]
        public IActionResult InsertContingencyData([FromBody] AuxContingencies data)
        {
            try
            {
                return Json(_db.InsertContingencyData(data));
            }
            catch (Exception ex)
            {
                return BadRequest("Error en InsertContingencyData, message: ´" + ex.Message.ToString() + "´ ");
            }

        }

    }
}
