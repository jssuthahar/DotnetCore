using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class Helper
    {
        public int count;
        public Helper()
        {
            count = 0;
        }
        public int Increment()
        {
            count = count + 1;
            return count;
        }

        public int Add(int a,int b)
        {
            return a + b;
        }
         // variable
        //Constructor
        //Methods
        //Properties
    }
}
