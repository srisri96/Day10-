﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage5
{
    public class empwag
    {
        public static void Wage()
        {
            int fullTime = 1;
            int partTime = 2;
            int empHr = 0;
            int empWage = 0;
            int wagePerHR = 20;
            int totalWorkingdays = 20;
            int totalWage = 0;
            for (int i = 0; i < totalWorkingdays; i++)
            {
                //new operator creates an object from the class by allocating memory for the new object and returning a reference to thet memory
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
                empWage = empHr * wagePerHR;
                Console.WriteLine($"Employee wage is {empWage}");
                totalWage = totalWage + empWage;
            }
            Console.WriteLine($"Total wage for 20 working days is  {totalWage}");
        }
    }
}
