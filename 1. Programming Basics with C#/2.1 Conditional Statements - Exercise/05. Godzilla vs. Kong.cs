using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int peopleNumber = int.Parse(Console.ReadLine());
            double priceForOneCostume = double.Parse(Console.ReadLine());

            double totalMoneyForCostumes = peopleNumber * priceForOneCostume;
            double totalDecoration = budget * 0.1;

            if (peopleNumber > 150)
            {
                totalMoneyForCostumes *= 0.9;
            }

            double total = totalMoneyForCostumes + totalDecoration;

            if (budget < total)
            {
                double moneyNeeded = Math.Abs(budget - total);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} leva more.");
            }

            else if (budget >= total)
            {
                double moneyLeft = budget - total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}