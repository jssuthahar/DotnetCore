using System.Data;
using Microsoft.Data.SqlClient;
namespace JSShopAPI.DataAccess
{
    public class SQLHelper
    {

        public readonly string ConnectionString;
        public SQLHelper()
        {
            ConnectionString = "Server=tcp:jsquare.database.windows.net,1433;Initial Catalog=jscollege;Persist Security Info=False;User ID=jsquare;Password=Welcome@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        }
        public SqlConnection GetConnection()
        {

            return new SqlConnection(ConnectionString);
        }
        public int SqlExcuteNonQuery(string sqlQuery, SqlParameter[] parameters)
        {
            int output = 0;
            using (SqlConnection sqlConnection = GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    sqlCommand.Parameters.AddRange(parameters);
                    output = sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
            }
            return output;
        }
        public object SqlExcuteScaller(string sqlQuery, SqlParameter[] parameters = null)
        {
            object output;
            using (SqlConnection sqlConnection = GetConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
                {
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.AddRange(parameters);
                    }
                    output = sqlCommand.ExecuteScalar();
                }
                sqlConnection.Close();
            }
            return output;
        }
        public SqlDataReader SqlDataRead(string sqlQuery, SqlParameter[] parameters = null)
        {
            SqlDataReader output;
            SqlConnection sqlConnection = GetConnection();
            sqlConnection.Open();
            using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
            {
                if (parameters != null)
                {
                    sqlCommand.Parameters.AddRange(parameters);
                }
                output = sqlCommand.ExecuteReader();
            }

            return output;
        }
        public DataSet SQLDataset(string sqlQuery, SqlParameter[] parameters = null)
        {
            DataSet output = new DataSet(); ;
            SqlConnection sqlConnection = GetConnection();
            sqlConnection.Open();
            using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection))
            {
                if (parameters != null)
                {
                    sqlCommand.Parameters.AddRange(parameters);
                }
                SqlDataAdapter oda = new SqlDataAdapter(sqlCommand);
                oda.Fill(output);
            }

            return output;
        }
    }
}
