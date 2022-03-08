
using BOServicesAPI.Entities;
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

    public class TokensController : Controller
    {
        private readonly IConfiguration _configuration;
        public string securityKeyJWT = string.Empty;
        public string issuerJWT = string.Empty;
        public string audienceJWT = string.Empty;
        public int expiresJWTInMinutes = 0;

        public string userLogin = string.Empty;
        public string passLogin = string.Empty;

        public TokensController(IConfiguration configuration)
        {
            _configuration = configuration;
            securityKeyJWT = _configuration["GlobalParameters:securityKeyJWT"];
            issuerJWT = _configuration["GlobalParameters:issuerJWT"];
            audienceJWT = _configuration["GlobalParameters:audienceJWT"];
            expiresJWTInMinutes = Convert.ToInt32(_configuration["GlobalParameters:expiresJWTInMinutes"]);

            //Solo para pruebas usuario y contrraseña en Configs
            userLogin = _configuration["GlobalParameters:userLogin"];
            passLogin = _configuration["GlobalParameters:passLogin"];
        }

        // POST: api/Tokens    
        //<created>Daniel Munguia</created>
        /// <summary>Use this resource to get an ApiKey
        /// </summary>  
        /// <response code="200">Data generated correctly.</response>        
        /// <response code="400">BadRequest.</response>         
        [Produces("application/json")]
        [HttpPost]
        public IActionResult Token([FromBody] UserDTOS auxUser)
        {
            TokenJson tokenJson = new TokenJson();
            try
            {
                if (!string.IsNullOrEmpty(auxUser.User) && !string.IsNullOrEmpty(auxUser.Pass))
                {
                    if (Login(auxUser.User, auxUser.Pass))
                    {
                        // se declaran los reclamos del JWT
                        var claimsData = new[] { new Claim(ClaimTypes.Name, auxUser.User) };
                        //Se declara la key que se usara para generar el token esta debe ser la misma que se declara en la clase StartUp
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKeyJWT));
                        var signInCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                        var token = new JwtSecurityToken(
                           issuer: issuerJWT,
                           audience: audienceJWT,
                           expires: DateTime.Now.AddMinutes(expiresJWTInMinutes),  // para la expiracion del token puede definisrse en horas, minutos,segundos etc.
                           claims: claimsData,
                           signingCredentials: signInCred

                           );
                        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
                        tokenJson.Token = tokenString;

                        return Json(tokenJson);
                    }
                    //Error error = new Error();
                    //error.Code = "01";
                    //error.Message = "Las credenciales son erroneas. Compruebe que el usuario y la contraseña sean correctas. Usuario recibido: " + auxUser.User + " Contraseña recibida: " + auxUser.Pass;
                    return BadRequest("The credentials are wrong.");

                }
            }
            catch (Exception ex)
            {

            }

            return BadRequest("wrong request");
        }

        /// <summary>
        /// Metodo encargado de validar las credenciales ingresadas para generar el Token
        /// </summary>
        /// <param name="User"></param>
        /// <param name="Pwd"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        private bool Login(string User, string Pwd)
        {
            bool Correcto = false;
            try
            {
                //Solo para pruebas se valida con usuario y contraseña del config, se debe cambiar por datos de la base
                if (userLogin.Equals(User) && passLogin.Equals(Pwd))
                {
                    Correcto = true;
                }

            }
            catch (Exception ex)
            {

            }

            return Correcto;
        }
    }
}
