using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int foodKilos = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double tortoiseFoodPerDay = double.Parse(Console.ReadLine()) / 1000;

            double calculation = foodKilos - dogFoodPerDay * numberOfDays - catFoodPerDay * numberOfDays - tortoiseFoodPerDay * numberOfDays;

            if (calculation < 0)
            {
                calculation = Math.Abs(calculation);
                Console.WriteLine($"{Math.Ceiling(calculation)} more kilos of food are needed.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(calculation)} kilos of food left.");
            }
        }
    }
}