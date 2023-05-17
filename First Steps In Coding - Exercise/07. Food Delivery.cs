using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chicken = double.Parse(Console.ReadLine()) * 10.35;
            double fish = double.Parse(Console.ReadLine()) * 12.40;
            double vegan = double.Parse(Console.ReadLine()) * 8.15;

            double total = chicken + fish + vegan;
            double dessert = total * 0.2;
            double orderTotal = total + dessert + 2.50;
            Console.WriteLine(orderTotal);
        }
    }
}