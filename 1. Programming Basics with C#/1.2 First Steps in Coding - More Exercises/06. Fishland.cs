using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceMackerel = double.Parse(Console.ReadLine());
            double priceSprat = double.Parse(Console.ReadLine());
            double priceBonito = (priceMackerel * 0.60 + priceMackerel) * double.Parse(Console.ReadLine());
            double priceSaffron = (priceSprat * 0.80 + priceSprat) * double.Parse(Console.ReadLine());
            double priceMussels = 7.50 * double.Parse(Console.ReadLine());
            double total = priceBonito + priceSaffron + priceMussels;

            Console.WriteLine($"{total:f2}");
        }
    }
}