using JSShopAPI.DataAccess;
using Microsoft.Data.SqlClient;
using JSShopAPI.Model;
namespace JSShopAPI.BusinessLogic
{
    public class UserLogic
    {
        private readonly SQLHelper _dataBaseHelper;
        public UserLogic(SQLHelper sql) {
            _dataBaseHelper = sql;
        }
        public int Register(Student student)
        {
            string sqlQuery = $"INSERT INTO Register VALUES(@name,@email,@password,@role)";
            SqlParameter[] parameters =
                {
                new SqlParameter("@name", student.FullName),
                new SqlParameter("@email", student.Email),
                new SqlParameter("@password", student.Password),
                new SqlParameter("@role", student.role)
                };

            return _dataBaseHelper.SqlExcuteNonQuery(sqlQuery, parameters);
        }
        public object LoginCheck(Student student)
        {
            string sqlQuery = "SELECT count(*) FROM Register WHERE EMAIL =@email AND PASSWORD=@password AND ROLE=@role";
            SqlParameter[] parameters =
                {
                new SqlParameter("@email", student.Email),
                new SqlParameter("@password", student.Password),
                  new SqlParameter("@role", student.role)
                };
            return _dataBaseHelper.SqlExcuteScaller(sqlQuery, parameters);
        }
        public Student GetStudnet(string email, string password)
        {
            Student student = new Student();
            string query = "SELECT * FROM Register WHERE EMAIL =@email AND PASSWORD=@password";
            SqlParameter[] parameters =
               {
                new SqlParameter("@email", email),
                new SqlParameter("@password",password),

                };
            SqlDataReader reader = _dataBaseHelper.SqlDataRead(query, parameters);
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    student.Email = reader.GetString(2);
                    student.FullName = reader.GetString(1);
                    student.Password = reader.GetString(3);
                    int id = (int)reader.GetDecimal(0);
                    student.id = id;


                }
            }
            return student;
        }
    }
}
