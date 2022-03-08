using BOServicesAPI.BusinessLogic.CustomizationSticker;
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

namespace BOServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class CustomStickersTrakings : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly OxxoBoContext _context;
        private Trakings _trakings;


        public CustomStickersTrakings(IConfiguration configuration, OxxoBoContext context)
        {
            _configuration = configuration;
            _context = context;
            _trakings = new Trakings(_context, _configuration);
        }

        // POST: api/CustomStickersTrakings    
        //<created>Erika Magneally</created>
        /// <summary>Sid initial load for sid generated and backed up
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("GetStickersTrakings")]
        public IActionResult GetStickersTrakings([FromBody] CustomSid customSid)
        {
            try
            {
                var result = _trakings.getTrakingDB(customSid);
                return Json(result);
                //return Json("");
            }
            catch (Exception ex)
            {
                return BadRequest("Error en InitialChargeStiker, message: ´" + ex.Message.ToString() + "");
            }
        }

    }
}
