using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double killometersMonth = double.Parse(Console.ReadLine());
            double salary = 0;

            if (killometersMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn": salary += 0.75; break;
                    case "Summer": salary += 0.90; break;
                    case "Winter": salary += 1.05; break;
                }
            }
            else if (killometersMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn": salary += 0.95; break;
                    case "Summer": salary += 1.10; break;
                    case "Winter": salary += 1.25; break;
                }
            }
            else if (killometersMonth <= 20000)
            {
                salary += 1.45;
            }

            salary = salary * killometersMonth * 4 * 0.90;
            Console.WriteLine($"{salary:f2}");
        }
    }
}