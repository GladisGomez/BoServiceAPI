using BOServicesAPI.DBContext;
using BOServicesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.DataBase
{
    public class CustomStickersTrakingDB
    {
        private readonly OxxoBoContext _context;

        public CustomStickersTrakingDB (OxxoBoContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metodo encargado de obtener una lista de seguimiento de Stickers Personalizados
        /// </summary>
        /// <returns></returns>
        /// <created>Erika Magneally</created>
        public List<CustomStickersTrakings> listCustomStickers()
        {
            List<CustomStickersTrakings> result = new List<CustomStickersTrakings>();

            try
            {
               return _context.CustomStickersTrakings.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Metodo encargado de obtener una lista de seguimiento de Stickers Personalizados por SidPersonalizado
        /// </summary>
        /// <returns></returns>
        /// <created>Erika Magneally</created>
        public List<CustomStickersTrakings> listCustomStickers(string SidPers)
        {
            List<CustomStickersTrakings> result = new List<CustomStickersTrakings>();

            try
            {
                return _context.CustomStickersTrakings.Where(x=>x.Sidpers==SidPers).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Metodo encargado de registrar un nuevo seguimiento de Stickers Personalizados
        /// </summary>
        /// <returns></returns>
        /// <created>Erika Magneally</created>

        public bool AddcustomStickers(CustomStickersTrakings  customStickersTraking)
        {       

            try
            {
                _context.CustomStickersTrakings.Add(customStickersTraking);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool AddRangecustomStickers(List<CustomStickersTrakings> customStickersTrakings)
        {

            try
            {
                _context.CustomStickersTrakings.AddRange(customStickersTrakings);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


    }
}
