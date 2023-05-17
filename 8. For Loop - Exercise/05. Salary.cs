using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int fines = 0;
            for (int i = 0; i < tabs; i++)
            {
                string tabNames = Console.ReadLine();
                switch (tabNames)
                {
                    case "Facebook": fines += 150; break;
                    case "Instagram": fines += 100; break;
                    case "Reddit": fines += 50; break;
                }
                if (salary <= fines)
                {
                    Console.WriteLine("You have lost your salary."); break;
                }
            }
            if (salary > fines)
            {
                Console.WriteLine(salary - fines);
            }
        }
    }
}