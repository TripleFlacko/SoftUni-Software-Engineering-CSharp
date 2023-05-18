using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tax = double.Parse(Console.ReadLine());

            double sneakers = tax * 0.6;
            double suit = sneakers * 0.8;
            double ball = suit * 0.25;
            double accessories = ball * 0.2;

            double total = tax + sneakers + suit + ball + accessories;
            Console.WriteLine(total);
        }
    }
}