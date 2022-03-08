using BOServicesAPI.BusinessLogic;
using BOServicesAPI.BusinessLogic.CustomizationSticker;
using BOServicesAPI.BusinessLogic.CustomizationStiker;
using BOServicesAPI.DBContext;
using BOServicesAPI.Entities;
using BOServicesAPI.Entities.CustomizationSticker;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BOServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CustomizationStikerController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly OxxoBoContext _context;
        private Customization _customization;
       


        public CustomizationStikerController(IConfiguration configuration, OxxoBoContext context)
        {
            _configuration = configuration;
            _context = context;
            _customization = new Customization(_context, _configuration);
        }


        // POST: api/CustomizationStiker    
        //<created>Erika Magneally</created>
        /// <summary>Sid initial load for sid generated and backed up
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("InitialChargeStiker")]
        public IActionResult InitialChargeStiker([FromBody] Assignment assignment)
        {
            try
            {
                var result = _customization.InitialChargeCustomSticker(assignment);
                return Json(result);
                //return Json("");
            }
            catch (Exception ex)
            {
                return BadRequest("Error en InitialChargeStiker, message: ´" + ex.Message.ToString() + "");
            }
        }


        // POST: api/CustomizationStiker    
        //<created>Erika Magneally</created>
        /// <summary>Use this resource to get an SID list
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("SidsGeneration")]
        public IActionResult SidsGeneration([FromBody] GenerationCustomStikerDtos generationCustomStikerDtos)
        {
            List<string> lisSid = new List<string>();

            try
            {                            
                return Json(_customization.GenerationCustomStiker(generationCustomStikerDtos));
            }
            catch (Exception ex)
            {
                return BadRequest("Error en SidsGeneration, message: ´" + ex.Message.ToString() + "´ ");
            }

        }


        // POST: api/CustomizationStiker    
        //<created>Erika Magneally</created>
        /// <summary>Send To Supplier CustomSticker
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("SendToSupplierCustomSticker")]
        public IActionResult SendToSupplierCustomSticker([FromBody] SendToSupplierDtos sendToSupplierDtos)
        {            
            try
            {
                var result = _customization.SendToSupplierCustomSticker(sendToSupplierDtos);
                return Json(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Error en SendToSupplierCustomSticker, message: ´" + ex.Message.ToString() + "");
            }
           
        }


        // POST: api/CustomizationStiker    
        //<created>Erika Magneally</created>
        /// <summary>mapping uid to sid
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("UIDAssignment")]
        public IActionResult UIDAssignment([FromBody] Assignment uIDAssignment)
        {
            List<string> lisSid = new List<string>();
            try
            {
                var result=_customization.UIDAssignmentCustomSticker(uIDAssignment);
                return Json(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Error en SendToSupplier, message: ´" + ex.Message.ToString() + "");
            }
            //return BadRequest("Error en SendToSupplier, message: ´" );
        }


        // POST: api/CustomizationStiker    
        //<created>Erika Magneally</created>
        /// <summary>mapping  vehicle to uid
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("vehicleAssignment")]
        public IActionResult vehicleAssignment([FromBody] VehicleAssignmentDtos vehicleAssignmentDtos)
        {
            List<string> lisSid = new List<string>();
            try
            {
                var result = _customization.vehicleAssignmentCustomSticker(vehicleAssignmentDtos);
                return Json(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Error en vehicleAssignment, message: ´" + ex.Message.ToString() + "");
            }

        }
        // POST: api/CustomizationStiker    
        //<created>Erika Magneally</created>
        /// <summary>mapping  vehicle to uid massive
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("MassivevehicleAssignment")]
        public IActionResult MassiveehicleAssignment([FromBody] Assignment assignment)
        {
            
            try
            {
                 var result = _customization.MassiveVehicleAssignmentCustomSticker(assignment);
                return Json(result);
                //return Json("");
            }
            catch (Exception ex)
            {
                return BadRequest("Error en MassiveehicleAssignment, message: ´" + ex.Message.ToString() + "");
            }           
        }


        // POST: api/CustomizationStiker    
        //<created>Erika Magneally</created>
        /// <summary>uid validation
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("ValidationUID")]
        public IActionResult ValidationUID([FromBody] UidDtos uidDtos)
        {
            List<string> lisSid = new List<string>();
            try
            {
                var result = _customization.vehicleAssignmentCustomSticker(uidDtos);
                return Json(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Error en SendToSupplier, message: ´" + ex.Message.ToString() + "");
            }
        }


    }
}
