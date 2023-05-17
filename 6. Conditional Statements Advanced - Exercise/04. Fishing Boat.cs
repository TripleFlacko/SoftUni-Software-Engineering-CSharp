using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double rent = 0.0;

            switch (season)
            {
                case "Spring":
                    rent += 3000;
                    break;
                case "Summer":
                case "Autumn":
                    rent += 4200;
                    break;
                case "Winter":
                    rent += 2600;
                    break;
            }

            if (fishers <= 6)
            {
                rent *= 0.9;
            }
            else if (7 < fishers && fishers <= 11)
            {
                rent *= 0.85;
            }
            else if (12 <= fishers)
            {
                rent *= 0.75;
            }

            if (fishers % 2 == 0 && season != "Autumn")
            {
                rent *= 0.95;
            }

            if (budget < rent)
            {
                Console.WriteLine($"Not enough money! You need {rent - budget:f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {budget - rent:f2} leva left.");
            }

        }
    }
}