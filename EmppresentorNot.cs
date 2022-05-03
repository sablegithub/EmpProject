using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProject
{
    public  class EmppresentorNot
    {
        int Full_Time = 1;
        Random r = new Random();
        
        public void emppresentornot()
        {
            int num = r.Next(0, 2);

            if(num == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
       
    }
}
