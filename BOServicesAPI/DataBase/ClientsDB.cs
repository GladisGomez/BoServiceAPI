using BOServicesAPI.DBContext;
using BOServicesAPI.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.DataBase
{
    public class ClientsDB
    {
        private readonly OxxoBoContext _context;
        private readonly IConfiguration _configuration;
        private AuthDB _authDB;
        private int SecurityAdministrator = 0;


        public ClientsDB(OxxoBoContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            _authDB = new AuthDB(_context);
            SecurityAdministrator = Convert.ToInt32(_configuration["GlobalParameters:SecurityAdministrator"]);

        }

        /// <summary>
        /// Determina si el usuario logueado es Security Administrator
        /// </summary>
        /// <returns>True or False</returns>
        public bool IsSecurityAdministrator(string userwebname)
        {
            bool flag = false;
            try
            {
                var list = (from d in _context.UsersInClientGroupSet
                            where d.UsersInClientGroupClientGroupNavigation.Id == SecurityAdministrator && d.UsersInClientGroupUserWebNavigation.Id == _authDB.GetUserId(userwebname)
                            select d).ToList();
                flag = list.Count() >= 1 ? true : false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return flag;
        }


        /// <summary>
        /// Obtiene la lista de los modelos clientes asignados al usuario
        /// </summary>
        /// <param name="userWebName"></param>
        /// <returns>Lista de clientes</returns>
        public List<AuxClients> GetListClientsInUserWeb(string userWebName)
        {
            List<AuxClients> list = new List<AuxClients>();
            try
            {


                var profile = (from p in _context.UsersInProfileSet
                               where p.UsersInProfileUserWebNavigation.UserName == userWebName && p.UsersInProfileProfileNavigation.IsActive == true
                               select p.UsersInProfileProfileNavigation.Id).FirstOrDefault();

         

                if (profile == 0)
                {
                    list = (from cl in _context.ClientGroups
                            join clg in _context.UsersInClientGroupSet on cl.Id equals clg.UsersInClientGroupClientGroupNavigation.Id
                            join us in _context.UserWebSet on clg.UsersInClientGroupUserWebNavigation.Id equals us.Id
                            where us.UserName == userWebName && cl.Status == 1
                            select new AuxClients
                            {
                                Id = cl.Id,
                                OficialName = cl.OficialName,
                                NickName = cl.NickName,
                                Active = Convert.ToBoolean(cl.Status)
                            }).OrderBy(m => m.Id).ToList();
                }
                else
                {
                    list = (from c in _context.ProfileInClientGroupSet
                            where c.ProfileInClientGroupProfileNavigation.Id == profile 
                            select new AuxClients
                            {
                                Id = c.ProfileInClientGroupClientGroupNavigation.Id,
                                OficialName = c.ProfileInClientGroupClientGroupNavigation.OficialName,
                                NickName = c.ProfileInClientGroupClientGroupNavigation.NickName,
                                Active = Convert.ToBoolean(c.ProfileInClientGroupClientGroupNavigation.Status)
                            }).OrderBy(m => m.Id).ToList();

                    if (list.Count() == 0)
                    {
                        list = (from cl in _context.ClientGroups                               
                                where cl.Status == 1
                                select new AuxClients
                                {
                                    Id = cl.Id,
                                    OficialName = cl.OficialName,
                                    NickName = cl.NickName,
                                    Active = Convert.ToBoolean(cl.Status)
                                }).OrderBy(m => m.Id).ToList();
                    }
                    else
                    {
                        list = (from c in _context.ProfileInClientGroupSet
                                where c.ProfileInClientGroupProfileNavigation.Id == profile && c.ProfileInClientGroupClientGroupNavigation.Status == 1
                                select new AuxClients
                                {
                                    Id = c.ProfileInClientGroupClientGroupNavigation.Id,
                                    OficialName = c.ProfileInClientGroupClientGroupNavigation.OficialName,
                                    NickName = c.ProfileInClientGroupClientGroupNavigation.NickName,
                                    Active = Convert.ToBoolean(c.ProfileInClientGroupClientGroupNavigation.Status)
                                }).OrderBy(m => m.Id).ToList();
                    }

                }

              
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
       


        /// <summary>
        /// Metodo encargado de obtener un listado de Grupos de un userWeb
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="ClientG"></param>
        /// <returns>Lista de grupos</returns>
        /// <created>Daniel Munguia</created>
        public List<AuxClients> GetListClientInUserWebByClientGroupAndUserName(string userName, int ClientG)
        {
            List<AuxClients> list = new List<AuxClients>();
            List<AuxClients> aux = new List<AuxClients>();

            try
            {


                var profile = (from p in _context.UsersInProfileSet
                               where p.UsersInProfileUserWebNavigation.UserName == userName && p.UsersInProfileProfileNavigation.IsActive == true
                               select p.UsersInProfileProfileNavigation.Id).FirstOrDefault();

                if (profile == 0)
                {
                    list = (from c in _context.Clients
                            join cl in _context.ClientGroups on c.ClientGroupClientNavigation.Id equals cl.Id
                            join clg in _context.UsersInClientGroupSet on cl.Id equals clg.UsersInClientGroupClientGroupNavigation.Id
                            join us in _context.UserWebSet on clg.UsersInClientGroupUserWebNavigation.Id equals us.Id
                            where us.UserName == userName && c.Status == 1 && c.ClientGroupClientNavigation.Id == ClientG
                            select new AuxClients
                            {
                                Id = c.Id,
                                NickName = c.NickName,
                                Active = Convert.ToBoolean(c.Status)
                            }).OrderBy(m => m.Id).ToList();
                }
                else
                {
                    list = (from c in _context.ProfileInClientSet
                            where c.ProfileClientGroupProfileInClientNavigation.Id == profile
                            select new AuxClients
                            {
                                Id = c.ProfileInClientClientNavigation.Id,
                                NickName = c.ProfileInClientClientNavigation.NickName,
                                Active = Convert.ToBoolean(c.ProfileInClientClientNavigation.Status)
                            }).OrderBy(m => m.Id).ToList();

                    if (list.Count() == 0)
                    {
                        list = (from c in _context.Clients                                
                                where  c.Status == 1 && c.ClientGroupClientNavigation.Id == ClientG
                                select new AuxClients
                                {
                                    Id = c.Id,
                                    NickName = c.NickName,
                                    Active = Convert.ToBoolean(c.Status)
                                }).OrderBy(m => m.Id).ToList();
                    }
                    else
                    {
                        list = (from c in _context.ProfileInClientSet
                                where c.ProfileClientGroupProfileInClientNavigation.Id == profile && c.ProfileInClientClientNavigation.Status == 1
                                select new AuxClients
                                {
                                    Id = c.ProfileInClientClientNavigation.Id,
                                    NickName = c.ProfileInClientClientNavigation.NickName,
                                    Active = Convert.ToBoolean(c.ProfileInClientClientNavigation.Status)
                                }).OrderBy(m => m.Id).ToList();
                    }

                }
              
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        /// <summary>
        /// Metodo encargado de obtener un listado de Grupos de un userWeb
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="ClientG"></param>
        /// <returns>Lista de grupos</returns>
        /// <created>Daniel Munguia</created>
        public List<AuxClients> GetListCedisByClientGroup(int ClientG)
        {
            List<AuxClients> list = new List<AuxClients>();

            try
            {


                if (ClientG > 0)
                {
                    list = (from c in _context.Clients
                            where c.Status == 1 && c.ClientGroupClientNavigation.Id == ClientG
                            select new AuxClients
                            {
                                Id = c.Id,
                                NickName = c.NickName,
                                Active = Convert.ToBoolean(c.Status)
                            }).OrderBy(m => m.Id).ToList();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }
    }
}
