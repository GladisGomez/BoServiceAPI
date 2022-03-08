using BOServicesAPI.BusinessLogic;
using BOServicesAPI.DataBase;
using BOServicesAPI.DBContext;
using BOServicesAPI.Entities;
using BOServicesAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    //[Authorize]
    public class VehiclesController : Controller
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;
        private VehiclesBL _bl;
        private VehiclesDB _db;

        public VehiclesController(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _bl = new VehiclesBL(_context, _configuration);
            _db = new VehiclesDB(_context);
        }


        // POST: api/Vehicles    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a id vehicle for plate
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("GetIdVehicleByPlate")]
        public IActionResult GetIdVehicleByPlate(string plate)
        {
            try
            {
                return Json(_db.GetIdVehicleByPlate(plate));
            }
            catch (Exception ex)
            {
                return BadRequest("Error en GetIdVehicleByPlate, message: ´" + ex.Message.ToString() + "´ ");
            }

        }

        // POST: api/Vehicles    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a id vehicle for eco
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("GetIdVehicleByEco")]
        public IActionResult GetIdVehicleByEco(string eco)
        {
            try
            {
                return Json(_db.GetIdVehicleByEco(eco));
            }
            catch (Exception ex)
            {
                return BadRequest("Error en GetIdVehicleByEco, message: ´" + ex.Message.ToString() + "´ ");
            }

        }


        // POST: api/Vehicles    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list vehicles
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("GetListVehiclesByUserNameWeb")]
        public IEnumerable<AuxVehicles> GetListVehiclesByUserNameWe(string userName)
        {
            try
            {
                return _db.listVehicles(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // POST: api/Vehicles    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list vehicles
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("GetListVehiclesByCedi")]
        public IEnumerable<AuxVehicles> GetListVehiclesByCedi(int cedi)
        {
            try
            {
                return _db.listVehiclesByCedi(cedi);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // POST: api/Vehicles    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get a list stickers assigned a Vehicle
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("GetListStickersByVehicle")]
        public IEnumerable<AuxVehicles> GetListStickersByVehicle(int idVehicle)
        {
            try
            {
                return _db.listStickersByIdVehicle(idVehicle);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // POST: api/Vehicles    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to insert or Update a Vehicle
        /// </summary>  
        /// <response code="200">Data correctly</response>        
        /// <response code="400">BadRequest.</response>      
        /// <response code="401">Unauthorized.</response>         

        [Produces("application/json")]
        [HttpPost("InsertUpdateVehicleData")]
        public IActionResult InsertUpdateVehicleData([FromBody] VehicleData data)
        {
            try
            {
                return Json(_db.insertUpdateVehicleData(data)); 
            }
            catch (Exception ex)
            {
                return BadRequest("Error en InsertUpdateVehicleData, message: ´" + ex.Message.ToString() + "´ ");
            }

        }



    }
}
