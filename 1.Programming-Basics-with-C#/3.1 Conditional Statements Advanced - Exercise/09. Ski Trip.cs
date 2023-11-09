using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string rating = Console.ReadLine();
            double price = 0;

            if (type == "room for one person")
            {
                price += 18;
            }
            else if (type == "apartment")
            {
                if (days < 10)
                {
                    price += 25 * 0.7;
                }
                else if (10 <= days && days <= 15)
                {
                    price += 25 * 0.65;
                }
                else if (15 < days)
                {
                    price += 25 * 0.5;
                }
            }
            else if (type == "president apartment")
            {
                if (days < 10)
                {
                    price += 35 * 0.9;
                }
                else if (10 <= days && days <= 15)
                {
                    price += 35 * 0.85;
                }
                else if (15 < days)
                {
                    price += 35 * 0.8;
                }
            }
            switch (rating)
            {
                case "positive": price *= 1.25; break;
                case "negative": price *= 0.9; break;
            }
            double totalCost = (days - 1) * price;
            Console.WriteLine($"{totalCost:f2}");
        }
    }
}