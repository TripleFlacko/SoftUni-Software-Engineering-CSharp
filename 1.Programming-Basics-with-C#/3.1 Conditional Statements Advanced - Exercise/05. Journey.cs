using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string country = "";
            string location = "";
            double cost = budget;

            if (0 < budget && budget <= 100)
            {
                country = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        cost *= 0.3;
                        location = "Camp";
                        break;
                    case "winter":
                        location = "Hotel";
                        cost *= 0.7;
                        break;
                }
            }
            else if (budget <= 1000)
            {
                country = "Balkans";
                switch (season)
                {
                    case "summer":
                        cost *= 0.4;
                        location = "Camp";
                        break;
                    case "winter":
                        location = "Hotel";
                        cost *= 0.8;
                        break;
                }
            }
            else if (budget > 1000)
            {
                country = "Europe";
                location = "Hotel";
                cost *= 0.9;
            }
            Console.WriteLine($"Somewhere in {country}");
            Console.WriteLine($"{location} - {cost:f2}");
        }
    }
}