using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workersNumber = int.Parse(Console.ReadLine());

            double liters = x * 0.4 * y / 2.5;

            if (liters >= z)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(liters)} liters.");
                Console.WriteLine($"{Math.Ceiling(liters - z)} liters left -> {Math.Ceiling((liters - z) / workersNumber)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - liters)} liters wine needed.");
            }
        }
    }
}