using BOServicesAPI.DBContext;
using BOServicesAPI.Entities;
using BOServicesAPI.Entities.CustomizationSticker;
using BOServicesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.DataBase
{
    public class WorkLogDB
    {
        private readonly OxxoBoContext _context;

        public WorkLogDB(OxxoBoContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Metodo encargado de registrar en bitacora
        /// </summary>
        /// <param name="auxData"></param>
        /// <returns></returns>
        /// <created>Daniel Munguia</created>
        public Result InsertWorkLogData(WorkLog auxData)
        {
            Result result = new Result();

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    AuditWebSet data = new AuditWebSet()
                    {
                        KeySegment = auxData.KeySegment,
                        ChangeType = auxData.ChangeType,
                        ChangedBy = auxData.ChangedBy,
                        OriginalValues = auxData.OriginalValues,
                        NewValues = auxData.NewValues,
                        ReferenceType = auxData.ReferenceType,
                        DataSource = auxData.DataSource,
                        CreatedBy = auxData.ChangedBy,
                        AuditWebUserWeb = auxData.IdUserWeb,
                        Created = DateTimeOffset.Now
                    };

                    _context.AuditWebSet.Add(data);
                    _context.SaveChanges();
                    transaction.Commit();

                    result.result = 1;
                    result.message = "Success";
                    return result;
                }
                catch (Exception ex)
                {
                    result.result = 2;
                    result.message = ex.Message;
                    transaction.Rollback();
                    return result;
                }

               
            }
        }
    }
}
