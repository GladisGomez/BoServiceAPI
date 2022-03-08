using BOServicesAPI.DBContext;
using BOServicesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BOServicesAPI.DataBase
{
    public class AuthDB
    {
        private readonly OxxoBoContext _context;
        private string key = string.Empty;

        public AuthDB(OxxoBoContext context)
        {
            _context = context;
        }

 

        /// <summary>
        /// Obtiene el id del usuario
        /// </summary>
        /// <param name="UserName">Nombre del usuario</param>
        /// <returns>Id del usuario</returns>
        public int GetUserId(string UserName)
        {
            int id = 0;
            try
            {
                id = (from d in _context.UserWebSet
                      where d.UserName == UserName
                      select d.Id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return id;
        }


        /// <summary>
        /// Obtiene el nombre del usuario
        /// </summary>
        /// <param name="UserName">Nombre del usuario</param>
        /// / <param name="Password">Password del usuario</param>
        /// <returns>Nombre del usuario</returns>
        public string GetUserName(string UserName)
        {
            var name = (from d in _context.UserWebSet
                        where d.UserName == UserName && d.Status == true
                        select d.FirstName).FirstOrDefault();
            return name;
        }

        /// <summary>
        /// Verifica si el usuario es válido
        /// </summary>
        /// <param name="Name">Nombre del usuario</param>
        /// <param name="Password">Password del usuario</param>
        /// <param name="permisoAppSticker"></param>
        /// <returns></returns>
        public bool UserIsValid(string Name, string Password, string permisoAppSticker)
        {
            bool valid = false;
            try
            {
                var token = Encriptar(Password);
                var name = (from d in _context.UserWebSet
                            where d.UserName == Name && d.Password == token && d.Status == true
                            select d.UserName).FirstOrDefault();

                valid = name != null ? true : false;

                if (valid)
                {
                    //Se valida el permiso debe ser igual al Acceso APP Eox Stickers agregar en config este parametro
                    var permiso = (from v in _context.ViewsWebSet
                                   join c in _context.ControllerWebSet on v.ControllerWebViewsWebNavigation.Id equals c.Id
                                   join p in _context.PermissionsWebSet on v.Id equals p.PermissionsWebViewsWebNavigation.Id
                                   join ro in _context.RolesWebSet on p.PermissionsWebRolesWebNavigation.Id equals ro.Id
                                   join ur in _context.UsersInRolesWebSet on ro.Id equals ur.UsersInRolesWebRolesWebNavigation.Id
                                   join u in _context.UserWebSet on ur.UsersInRolesWebUserWebNavigation.Id equals u.Id
                                   where v.Description == permisoAppSticker && u.UserName == Name
                                   select p.Access).FirstOrDefault();

                    valid = permiso;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return valid;
        }

        /// <summary>
        /// Verifica si el usuario existe
        /// </summary>
        /// <param name="idUser">Identificador de Usuario</param>
        /// <returns></returns>
        public string UserExist(int  idUser)
        {
            string valid = String.Empty;
            try
            {                
                var name = (from d in _context.UserWebSet
                            where d.Id == idUser
                            select d.UserName).FirstOrDefault();

                valid = name;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return valid;
        }

        public string Encriptar(string texto)
        {
            byte[] keyArray;
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

            //Algoritmo MD5
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

            hashmd5.Clear();

            //Algoritmo 3DAS
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            //se empieza con la transformación de la cadena
            ICryptoTransform cTransform = tdes.CreateEncryptor();

            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);
            tdes.Clear();


            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }     


    }
}
