using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWasher = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int toys = 0;
            int evenBirtdays = 0;
            int moneyFromGifts = 0;
            int brothersTake = 0;

            for (int i = 1; i <= age; i += 2)
            {
                toys++;
            }

            for (int i = 2; i <= age; i += 2)
            {
                evenBirtdays++;
                moneyFromGifts += evenBirtdays * 10;
                brothersTake++;

            }

            double moneySheHas = moneyFromGifts + toys * priceToy - brothersTake;

            if (moneySheHas >= priceWasher)
            {
                Console.WriteLine($"Yes! {moneySheHas - priceWasher:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWasher - moneySheHas:f2}");
            }
        }
    }
}