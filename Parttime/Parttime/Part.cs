using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parttime
{
    internal class Part
    {
        public static void Emppart()
        {
            int fullTime = 1;
            int partTime = 2;
            int empHr = 0;
            int empWage = 0;
            int wagePerHr = 20;
            
            Random random = new Random();
            int attendCheck = random.Next(0, 3);
            if (attendCheck == fullTime)
            {
                empHr = 8;
                Console.WriteLine($"Full time employee");
            }
            else if (attendCheck == partTime)
            {
                empHr = 4;
                Console.WriteLine("Part time employee");
            }
            else
            {
                empHr = 0;
                Console.WriteLine("The employee is absent");
            }
            empWage = empHr * wagePerHr;
            Console.WriteLine($"The Employee wage is {empWage}");
        }
    }
}
