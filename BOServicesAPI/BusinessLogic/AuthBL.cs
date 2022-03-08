using BOServicesAPI.DataBase;
using BOServicesAPI.DBContext;
using BOServicesAPI.Entities;
using BOServicesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BOServicesAPI.BusinessLogic
{
    public class AuthBL
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;
        public UserWebSet UserLogged;       
        private readonly AuthDB _db;       
        private string SessionId;
        private string UrlVehicleTracker;
        private string urlVehTrI;
        private string ServerVehicleTracker;
        private string permisoAppSticker;

        public AuthBL(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            UserLogged = new UserWebSet();
            _db = new AuthDB(_context);
            SessionId = _configuration["GlobalParameters:SessionId"].ToString();
            UrlVehicleTracker = _configuration["GlobalParameters:UrlVehicleTracker"].ToString();
            urlVehTrI = _configuration["GlobalParameters:urlVehTrI"].ToString();
            permisoAppSticker = _configuration["GlobalParameters:permisoAppSticker"].ToString();


        }

        public bool ValidateCredentials(UserDTOS request)
        {

            //primer metodo valida en UserWebSet tabla de usuarios de portal web y ver si existe en la tabla nueva de control de login, si existe ver si tiene vigencia el pass y ver si no esta bloqueada la cuenta
            //Si existe el usuario en UserWebSet, pero el pass esta mal se debe notificar que las credenciales son erroneas y en la tabla de control se login aumentar a 1 el parametro intentos , si llega a 2 intentos mal el 3 se bloquea el usuarios por 15 minutos
            //Si no existe valida en usuarios tabla de usuarios de BO y ver si existe en la tabla nueva de control de login, si existe ver si tiene vigencia el pass y ver si no esta bloqueada la cuenta
            //Si existe el usuario en Usuarios, pero el pass esta mal se debe notificar que las credenciales son erroneas y en la tabla de control se login aumentar a 1 el parametro intentos , si llega a 2 intentos mal el 3 se bloquea el usuarios por 15 minutos

            //si no existe no es un usuario valido por que no existe en ninguna tabla y debe registrarse 
            bool flag = false;
            
            try
            {
                if (_db.UserIsValid(request.User,request.Pass, permisoAppSticker))
                {
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                //logger.Error(ex, "Exception UserValid");
                throw new Exception(ex.Message);
            }
            return flag;

        }

       

    


    }
}
