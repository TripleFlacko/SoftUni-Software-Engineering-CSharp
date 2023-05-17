using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double gpu = double.Parse(Console.ReadLine());
            double cpu = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());

            double total = (gpu * 250) + ((gpu * 250) * 0.35 * cpu) + ((gpu * 250) * 0.1 * ram);

            if (gpu > cpu)
            {
                total *= 0.85;
            }

            if (budget >= total)
            {
                Console.WriteLine($"You have {budget - total:f2} leva left!");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - total):f2} leva more!");
            }
        }
    }
}