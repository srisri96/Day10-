using Employeewage9;
Console.WriteLine("Welcome to employee wage computation program");
Empwage emp1 = new Empwage();
emp1.Wage("TCS", 20, 20, 100);
Empwage emp2 = new Empwage();
emp2.Wage("Zoho", 30, 20, 100);
Console.WriteLine($"Total wage for an employee of TCS is {emp1.totalWage}");
Console.WriteLine($"Total wage for an employee of Zoho is {emp2.totalWage}");