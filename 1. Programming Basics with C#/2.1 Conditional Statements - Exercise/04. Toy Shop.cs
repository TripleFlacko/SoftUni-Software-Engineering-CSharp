using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripCost = double.Parse(Console.ReadLine());

            int puzzles = int.Parse(Console.ReadLine());
            int barbies = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double toysTotal = puzzles + barbies + bears + minions + trucks;
            double moneyTotal = (puzzles * 2.60) + (barbies * 3) + (bears * 4.10) + (minions * 8.20) + (trucks * 2);

            if (toysTotal >= 50)
            {
                moneyTotal = moneyTotal * 0.75;
            }

            moneyTotal = moneyTotal * 0.9;

            if (moneyTotal >= tripCost)
            {
                Console.WriteLine($"Yes! {moneyTotal - tripCost:F2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! {tripCost - moneyTotal:F2} lv needed.");
            }

        }
    }
}