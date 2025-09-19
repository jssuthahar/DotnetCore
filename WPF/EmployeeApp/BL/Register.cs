using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApp.Model;
using EmployeeApp.DataAccess;
namespace EmployeeApp.BL
{
    public class Register
    {
        public int RegisterCourse(Student student)
        {
            string sql= "INSERT INTO StudCourse VALUES(@sname,@email,@phone,@dob,@cid,@address)";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@sname", student.Sname);
            parameters.Add("@email", student.Email);
            parameters.Add("@phone", student.Phone.ToString());
            parameters.Add("@dob", student.Dob);
            parameters.Add("@cid", student.Cid.ToString());
            parameters.Add("@address", student.Address);
            SQLHelper sQLHelper = new SQLHelper();
            return sQLHelper.ExcuteQuery(sql, parameters);

        }
    }
}
