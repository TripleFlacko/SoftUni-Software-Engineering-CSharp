using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKilloVeggie = double.Parse(Console.ReadLine());
            double priceKilloFruit = double.Parse(Console.ReadLine());
            int totalKilloVeggie = int.Parse(Console.ReadLine());
            int totalKilloFruit = int.Parse(Console.ReadLine());

            double total = (priceKilloFruit * totalKilloFruit + priceKilloVeggie * totalKilloVeggie) / 1.94;
            Console.WriteLine($"{total:f2}");
        }
    }
}