using BOServicesAPI.BusinessLogic;
using BOServicesAPI.BusinessLogic.CustomizationSticker;
using BOServicesAPI.DBContext;
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
   // [Authorize]
    public class SecuritySticker : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly OxxoBoContext _context;
        private EncryptionAES256 _encryptionAES256;
        public SecuritySticker(IConfiguration configuration, OxxoBoContext context)
        {

            _encryptionAES256 = new EncryptionAES256(configuration["GlobalParameters:KeyAES256"], configuration["GlobalParameters:KeyAES256GOSMO"]);
           // _customization = new Customization(_context, _configuration);
        }

        // POST: api/SecuritySticker    
        //<created>Erika Magneally</created>
        /// <summary>Sensitive data encryption sticker
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("EncryptionGosmo")]
        public IActionResult EncryptionGosmo([FromBody] string text)
        {
            string result = String.Empty;
            try
            {
                 if (!String.IsNullOrEmpty(text)) {
                    result=_encryptionAES256.Encryption(text, 2);
                 }                           
            }
            catch (Exception ex)
            {
                return BadRequest("Error en EncryptionGosmo, message: ´" + ex.Message.ToString() + "´ ");
            }
            return Json(result);
        }

        // POST: api/SecuritySticker    
        //<created>Erika Magneally</created>
        /// <summary>Sensitive data decryption sticker
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("DecryptionGosmo")]
        public IActionResult DecryptionGosmo([FromBody] string text)
        {
            string result = String.Empty;
            try
            {
                if (!String.IsNullOrEmpty(text))
                {
                    result = _encryptionAES256.Decryption(text, 2);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Error en Decryption, message: ´" + ex.Message.ToString() + "´ ");
            }
            return Json(result);
        }


        // POST: api/SecuritySticker    
        //<created>Erika Magneally</created>
        /// <summary>Sid exclusive encryption
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("EncryptionSid")]
        public IActionResult EncryptionSid([FromBody] string text)
        {
            string result = String.Empty;
            try
            {
                if (!String.IsNullOrEmpty(text))
                {
                    result = _encryptionAES256.Encryption(text, 1);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Error en EncryptionSid, message: ´" + ex.Message.ToString() + "´ ");
            }
            return Json(result);
        }

        // POST: api/SecuritySticker    
        //<created>Erika Magneally</created>
        /// <summary>Sid exclusive dencryption
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>            
        [Produces("application/json")]
        [HttpPost("DecryptionSid")]
        public IActionResult DecryptionSid([FromBody] string text)
        {
            string result = String.Empty;
            try
            {
                if (!String.IsNullOrEmpty(text))
                {
                    result = _encryptionAES256.Decryption(text, 1);
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Error en DecryptionSid, message: ´" + ex.Message.ToString() + "´ ");
            }
            return Json(result);
        }
    }
}
