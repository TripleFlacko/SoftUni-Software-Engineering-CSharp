using System;

namespace _07.Vending_Machine
{
    class Program
    {
        static void Main()
        {
            double sum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Start")
                {
                    break;
                }

                double coins = double.Parse(input);

                switch (coins)
                {
                    case 2: sum += 2; break;
                    case 1: sum += 1; break;
                    case 0.5: sum += 0.5; break;
                    case 0.2: sum += 0.2; break;
                    case 0.1: sum += 0.1; break;
                    default: Console.WriteLine($"Cannot accept {coins}"); break;
                }

            }

            double productPrice = 0;

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "End")
                {
                    break;
                }

                switch (product)
                {
                    case "Nuts": productPrice = 2.00; break;
                    case "Water": productPrice = 0.7; break;
                    case "Crisps": productPrice = 1.5; break;
                    case "Soda": productPrice = 0.8; break;
                    case "Coke": productPrice = 1.0; break;
                    default: Console.WriteLine("Invalid product"); productPrice = 0; break;
                }
                if (sum >= productPrice && productPrice != 0)
                {
                    sum -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else if (sum < productPrice)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}