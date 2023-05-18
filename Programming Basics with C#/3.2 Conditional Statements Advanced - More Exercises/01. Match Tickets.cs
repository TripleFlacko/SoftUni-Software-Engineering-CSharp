using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double tickets = 0;
            double transport = 0;

            switch (category)
            {
                case "VIP": tickets += 499.99; break;
                case "Normal": tickets += 249.99; break;
            }

            if (1 <= people && people <= 4)
            {
                transport = budget * 0.75;
            }
            else if (people <= 9)
            {
                transport = budget * 0.60;
            }
            else if (people <= 24)
            {
                transport = budget * 0.50;
            }
            else if (people <= 49)
            {
                transport = budget * 0.40;
            }
            else
            {
                transport = budget * 0.25;
            }

            double money = Math.Abs(budget - tickets * people - transport);

            if (budget > tickets * people + transport)
            {
                Console.WriteLine($"Yes! You have {money:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {money:f2} leva.");
            }
        }
    }
}