using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProject
{

    internal class EmpDailyWage
    {
        int Full_Time = 1;
        int WAGE_PER_HOUR = 20;
        int FULL_DAY_HOUR = 8;
        int PART_TIME_HOUR = 4;
        bool IsPresent;
        bool IsFullTime;

        Random r =new Random();

        public void emppresentornot()
        {
            int num = r.Next(0, 2);

            if (num == 1)
            {
                IsPresent = true;
                Console.WriteLine("Employee is present");
            }
            else
            {
                IsPresent = false;
                Console.WriteLine("Employee is absent");
            }
        }




        public void CalcEmpDailyWage()
        {
            int empDailyWage = 0;
            if (IsPresent && IsFullTime) // true && true = true
            {
                empDailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                //Console.WriteLine("Employee Daily Wage is " + empDailyWage);
            }
            else if (IsPresent && !IsFullTime)// true && !false = true (where !false = true)
            {
                empDailyWage = WAGE_PER_HOUR * PART_TIME_HOUR;
            }
            Console.WriteLine("Employee Daily Wage is {0}", empDailyWage);
        }
    }
}
