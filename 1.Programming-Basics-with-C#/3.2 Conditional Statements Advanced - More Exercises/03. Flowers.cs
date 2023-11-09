using System;
using System.Diagnostics;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());

            double money = 0;

            switch (season)
            {
                case "Spring":
                case "Summer": money += chrysanthemums * 2.00 + roses * 4.10 + tulips * 2.50; break;
                case "Autumn":
                case "Winter": money += chrysanthemums * 3.75 + roses * 4.50 + tulips * 4.15; break;
            }
            switch (holiday)
            {
                case 'Y': money *= 1.15; break;
            }
            if (7 < tulips && season == "Spring")
            {
                money *= 0.95;
            }
            if (10 <= roses && season == "Winter")
            {
                money *= 0.90;
            }
            if (chrysanthemums + roses + tulips > 20)
            {
                money *= 0.8;
            }

            Console.WriteLine($"{money + 2:f2}");
        }
    }
}