using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace origemployeecomputation
{
    internal class Wage
    {
        public static void empwagemethod()
        {
            int empHour, wagePerHour = 20;
            Random obj = new Random();
            int num = obj.Next(0, 2);
            if (num == 1)
            {
                empHour = 8;
            }
            else
            {
                empHour = 0;
            }

            int empWage = wagePerHour * empHour;
            Console.WriteLine("employee wage: " + empWage);

        }
    }
}
