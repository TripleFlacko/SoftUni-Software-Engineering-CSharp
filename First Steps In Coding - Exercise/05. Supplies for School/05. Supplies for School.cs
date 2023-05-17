using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            double pens = double.Parse(Console.ReadLine()) * 5.80;
            double markers = double.Parse(Console.ReadLine()) * 7.20;
            double liters = double.Parse(Console.ReadLine()) * 1.20;
            double discount = double.Parse(Console.ReadLine()) / 100;
            double total = pens + markers + liters;
            double money = (pens + markers + liters) * discount;
            Console.WriteLine(total - money);
        }
    }
}