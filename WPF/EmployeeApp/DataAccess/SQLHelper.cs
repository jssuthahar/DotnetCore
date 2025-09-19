using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace EmployeeApp.DataAccess
{
    public  class SQLHelper
    {

        /// <summary>
        /// //Insert , Update, Delete
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int ExcuteQuery(string query, Dictionary<string, string> parameters)
        {
            int result=-1;
            try
            {
               
                using (SqlConnection sqlConn = new SqlConnection(InMemory.Connection))
                {
                    sqlConn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        result = cmd.ExecuteNonQuery();
                    }
                    sqlConn.Close();
                }
            }
            catch(SqlException ex)
            {
                throw new Exception("SQL Error: " + ex.Message);
            }
            return result;
        }
    }
}
