﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeewage
{
    internal class Empwage
    {
        public static void Emp()
        {
            int fullTime = 1;
            int partTime = 2;
            int empHr = 0;
            int empWage = 0;
            int wagePerHR = 20;
            int totalWorkingdays = 20;
            int totalWorkingHR = 100;
            int totalEmpHr = 0;
            int totalDay = 0;
            do
            {
                
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
                totalEmpHr = totalEmpHr + empHr;
                empWage = empHr * wagePerHR;
                Console.WriteLine($"Employee wage is {empWage}");
                totalDay++;
            } while (totalEmpHr <= totalWorkingHR && totalDay < totalWorkingdays);
            Console.WriteLine($"The total working days per month is {totalWorkingdays} and total working hours is {totalEmpHr}");
            empWage = totalEmpHr * wagePerHR;
            Console.WriteLine($"Employee wage is {empWage}");
        }
    }
}
