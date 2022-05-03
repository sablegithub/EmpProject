using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpProject
{

    internal class EmpDailyWage
    {
        int WAGE_PER_HOUR = 20;
        int FULL_DAY_HOUR = 8;
        int PART_TIME_HOUR = 4;
        bool IsPresent;
        bool IsFullTime;
        

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
