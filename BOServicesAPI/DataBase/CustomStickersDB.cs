using BOServicesAPI.DBContext;
using BOServicesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.DataBase
{
    public class CustomStickersDB
    {
        private readonly OxxoBoContext _context;
        public CustomStickersDB(OxxoBoContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metodo encargado de obtener una lista de Stickers Personalizados
        /// </summary>
        /// <returns></returns>
        /// <created>Erika Magneally</created>
        public List<CustomStickers> listCustomStickers()
        {
            List<CustomStickers> result = new List<CustomStickers>();

            try
            {
                return  _context.CustomStickers.ToList();
                
            }
            catch (Exception ex)
            {

            }
            return result;
        }


        /// <summary>
        /// Metodo encargado de obtener Stickers Personalizados mediante sid
        /// </summary>
        /// <returns></returns>
        /// <created>Erika Magneally</created>
        public CustomStickers getCustomStickers(string sid)
        {
            CustomStickers customStickers = new CustomStickers();
            try
            {
                customStickers=_context.CustomStickers.Where(x=>x.Sid==sid).First();          
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customStickers;
        }

        /// <summary>
        /// Metodo encargado de obtener Stickers Personalizados mediante lista de sid
        /// </summary>
        /// <returns></returns>
        /// <created>Erika Magneally</created>
        public List<string> getCustomStickersList(List<string> sid)
        {
            List<string> customStickers = new List<string>();
            try
            {
                // customStickers = _context.CustomStickers.Where(x => ).First();
                // customStickers = _context.CustomStickers.Where(x => sid.Any( y=>y==x.Sidpers)).ToList();

                 customStickers = (from c in _context.CustomStickers
                                      where sid.Contains(c.Sidpers) select c.Sidpers).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customStickers;
        }

        /// <summary>
        /// Metodo encargado de Registrar Stickers Personalizados
        /// </summary>
        /// <returns></returns>
        /// <created>Erika Magneally</created>

        public CustomStickers AddCustomStickers(CustomStickers customStickers, CustomStickersTrakings customStickersTrakings)
        {
            List<CustomStickers> result = new List<CustomStickers>();

         
                using (var transaction = _context.Database.BeginTransaction())                {
                    try
                    {
                        _context.CustomStickers.Add(customStickers);
                        _context.SaveChanges();
                         customStickersTrakings.CustomStickersTrakingCustomSticker = customStickers.Id;                        
                        _context.CustomStickersTrakings.Add(customStickersTrakings);
                        _context.SaveChanges();
                        _context.Database.CommitTransaction();
                        return customStickers;

                    } catch (Exception ex)
                    {
                        _context.Database.RollbackTransaction();
                        throw new Exception(ex.Message);
                    }
                }
                     
        }


        /// <summary>
        /// Metodo encargado de Modificar Stickers Personalizados
        /// </summary>
        /// <returns></returns>
        /// <created>Erika Magneally</created>
        public bool UpdatecustomSticker(CustomStickers customStickers,CustomStickersTrakings customStickersTrakings)
        {           
           using (var tras=_context.Database.BeginTransaction()) {
                    try
                    {
                        _context.CustomStickers.Update(customStickers);
                        _context.CustomStickersTrakings.Add(customStickersTrakings);
                        _context.SaveChanges();
                        tras.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        tras.Rollback();
                       return false;
                    }
           }          
        }

        /// <summary>
        /// Metodo encargado  de Modificar  un listados de Stickers Personalizados
        /// </summary>
        /// <returns></returns>
        /// <created>Erika Magneally</created>
        public bool UpdatecustomStickerList(List<CustomStickers> customStickers,List<CustomStickersTrakings> customStickersTrakings)
        {
            using (var tras = _context.Database.BeginTransaction())
            {
                try
                {                   
                    _context.CustomStickers.UpdateRange(customStickers);
                    _context.CustomStickersTrakings.AddRange(customStickersTrakings);                   
                    _context.SaveChanges();
                    tras.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tras.Rollback();
                    throw new Exception(ex.Message);
                }
            }
        }

        public List<CustomStickers> listCustomStickers(int estatus, int num)
        {
            List<CustomStickers> result = new List<CustomStickers>();

            try
            {
                result= _context.CustomStickers.Where(x=>x.CustomStickerCatCustomStickersStatus == estatus).OrderBy(x=>x.Id).Take(num).ToList();

            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public bool updateCustomStickers(List<CustomStickers> customStickers) {
            try
            {
                _context.CustomStickers.UpdateRange(customStickers);
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex){
                return false;
                
            }        
        }

        public bool updateCustomSticker(CustomStickers customStickers)
        {
            
            try
            {                
                _context.CustomStickers.UpdateRange(customStickers);
                _context.SaveChanges();
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
            return true;
        }

        public List<CustomStickers> getListCustomSticker(List<String> sidsPers){

            List <CustomStickers> result= new List<CustomStickers>();
            try
            {
                 result = _context.CustomStickers.Where(t =>t.Uid ==null && sidsPers.Any(x=>x==t.Sidpers)).ToList();                 
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;

        }

        public List<CustomStickers> getListCustomStickerUID(List<String> uids)
        {

            List<CustomStickers> result = new List<CustomStickers>();
            try
            {
                result = _context.CustomStickers.Where(t => uids.Any(x => x == t.Uid)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;

        }

        public TankVehiclesSet GetTank(int idVehicle)
        {
            TankVehiclesSet result = new TankVehiclesSet();            
            try
            {
               var res = _context.TankVehiclesSet.Where(x=>x.VehicleTankVehicles== idVehicle).OrderBy(y=>y.Id).ToList();     
               if (res.Count!=0)
                {
                    result = res.First();
                } 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public CustomStickers GetCustomStickersxUID(string uid)
        {
            CustomStickers result = new CustomStickers();
            try
            {
                result = _context.CustomStickers.Where(x => x.Uid == uid ).FirstOrDefault();

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }

        public Vehicles GetVehiclexID(int id)
        {
            Vehicles result = new Vehicles();
            try
            {
                result = _context.Vehicles.Where(x => x.Id==id).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }

        public string AddCustomStickerAndTags(CustomStickers customStickers, Tags tags, TankVehiclesSet tankVehiclesSet)
        {
            string result = String.Empty;
            using (var tras = _context.Database.BeginTransaction())
            {
                try
                {
                    if (tankVehiclesSet.Id==0)
                    {
                        _context.TankVehiclesSet.Add(tankVehiclesSet);
                    }

                    _context.Tags.Add(tags);
                    _context.SaveChanges();
                    customStickers.CustomStickerTag = tags.Id;                    
                    _context.CustomStickers.Update(customStickers);
                    _context.CustomStickersTrakings.Add(new CustomStickersTrakings()
                    {
                        CreatedBy = customStickers.ModifiedBy,
                        Created = customStickers.Modified,
                        CustomStickersTrakingCustomSticker = customStickers.Id,
                        CustomStickersTrakingCatCustomStickersStatus = customStickers.CustomStickerCatCustomStickersStatus,
                        CustomStickersTrakingCatCustomStickersModel = customStickers.CustomStickerCatCustomStickersModel,
                        CustomStickersTrakingTag = customStickers.CustomStickerTag,
                        CustomStickersTrakingUserWeb = customStickers.CustomStickerUserWeb,
                        Sid = customStickers.Sid,
                        Sidpers = customStickers.Sidpers,
                        Uid = customStickers.Uid
                    }); ;
                    _context.SaveChanges();
                    tras.Commit();
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                    tras.Rollback();
                  
                }
                return result;
            }
        }

        public List<Vehicles> getListVehicle(List<string> listPlates)
        {

            List<Vehicles> result = new List<Vehicles>();
            try
            {
                result = _context.Vehicles.Where(t => listPlates.Any(x => x == t.Plate)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            return result;

        }
    }

}
