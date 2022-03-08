using BOServicesAPI.DBContext;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.DataBase
{
    public class StoreProcedureDB
    {
        private readonly OxxoBoContext _context;

        private string _connDB = string.Empty;
        //private static NLog.Logger _log;

        public StoreProcedureDB(string conection)
        {

            _connDB = conection;
        }

        public IEnumerable<T> EjecutarStoredProcedure<T>(string storedProcedure, SqlParameter[] parameters, Func<SqlDataReader, T> body)
        {
           
            List<T> results = new List<T>();

            using (SqlConnection connection = new SqlConnection(_connDB))
            {                
                using (SqlCommand cmd = new SqlCommand(storedProcedure, connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(parameters);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        results.Add(body(reader));
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            return results;
        }
    }
}
