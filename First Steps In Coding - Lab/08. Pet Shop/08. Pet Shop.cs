using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double forDogs = 2.50 * double.Parse(Console.ReadLine());
            double forCats = 4 * double.Parse(Console.ReadLine());

            double total = forCats + forDogs;

            Console.WriteLine($"{total} lv.");
        }
    }
}