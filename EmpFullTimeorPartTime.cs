using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProject
{
    internal class EmpFullTimeorPartTime
    {
        public void Full_PART_TIME()
        {
            bool FULL_TIME;
            Random r = new Random();
            int num = r.Next(0, 2);
            if (num == 1)
            {
                FULL_TIME = true;
                Console.WriteLine("Full Time Employee");
            }
            else
            {
                FULL_TIME = false;
                Console.WriteLine("Part Time Employee")
            }
          }


    }
}
