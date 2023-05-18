using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0.0;

            switch (flowers)
            {
                case "Roses":

                    price = quantity * 5;
                    if (quantity > 80)
                    {
                        price *= 0.9;
                    }
                    break;

                case "Dahlias":

                    price = quantity * 3.80;
                    if (quantity > 90)
                    {
                        price *= 0.85;
                    }
                    break;

                case "Tulips":

                    price = quantity * 2.80;
                    if (quantity > 80)
                    {
                        price *= 0.85;
                    }
                    break;

                case "Narcissus":

                    price = quantity * 3.00;
                    if (quantity < 120)
                    {
                        price *= 1.15;
                    }
                    break;

                case "Gladiolus":

                    price = quantity * 2.50;
                    if (quantity < 80)
                    {
                        price *= 1.20;
                    }
                    break;
            }

            if (budget < price)
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {budget - price:f2} leva left.");
            }
        }
    }
}