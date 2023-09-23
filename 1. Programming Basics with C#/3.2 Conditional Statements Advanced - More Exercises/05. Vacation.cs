using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string type = "";
            double price = 0;
            string place = "";

            switch (season)
            {
                case "Summer": place += "Alaska"; break;
                case "Winter": place += "Morocco"; break;
            }

            if (budget <= 1000)
            {
                type += "Camp";

                switch (season)
                {
                    case "Summer": price = budget * 0.65; break;
                    case "Winter": price = budget * 0.45; break;
                }
            }
            else if (budget <= 3000)
            {
                type += "Hut";

                switch (season)
                {
                    case "Summer": price = budget * 0.80; break;
                    case "Winter": price = budget * 0.60; break;
                }
            }
            else if (budget > 3000)
            {
                type += "Hotel";

                switch (season)
                {
                    case "Summer": price = budget * 0.90; break;
                    case "Winter": price = budget * 0.90; break;
                }
            }
            Console.WriteLine($"{place} - {type} - {price:f2}");
        }
    }
}