using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace origemployeecomputation
{
    public class Parttime
    {
        public static void empparttimemethod()
        {
            int empHour, empWage, wagePerHour = 20;
            int partTimeHour = 4;
            int fullTimeHour = 8;
            Random obj = new Random();
            int num = obj.Next(0, 3);

            if (num == 1)
            {
                empHour = fullTimeHour;
            }
            else if (num == 2)
            {
                empHour = partTimeHour;
            }
            else
            {
                empHour = 0;
            }
            empWage = empHour * wagePerHour;
            Console.WriteLine("Employee wage :" + empWage);
        }
    }
}
