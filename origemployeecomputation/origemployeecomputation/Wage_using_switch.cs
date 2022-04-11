using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace origemployeecomputation
{
    public class Wage_using_switch
    {
        public static void Emp_wage_method()
        {
            int emp_hour, emp_wage, wage_per_hour = 20;
            int part_time_hour = 4;
            int full_time_hour = 8;
            Random obj = new Random();
            int num = obj.Next(0, 3);

            switch(num)
            {
                case 1:
                    
                        emp_hour = full_time_hour;
                        break;
                    
                case 2:
                    
                        emp_hour = part_time_hour;
                        break;
                    
                default:
                    
                        emp_hour = 0;
                    break;

            }
            
            emp_wage = emp_hour * wage_per_hour;
            Console.WriteLine("Employee wage :" + emp_wage);
        }
    }
}
