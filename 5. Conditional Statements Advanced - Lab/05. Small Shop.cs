using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double sum = 0;

            switch (town)
            {
                case "Sofia":

                    switch (productName)
                    {
                        case "coffee": sum = quantity * 0.50; break;
                        case "water": sum = quantity * 0.80; ; break;
                        case "beer": sum = quantity * 1.20; break;
                        case "sweets": sum = quantity * 1.45; break;
                        case "peanuts": sum = quantity * 1.60; break;

                    }
                    break;

                case "Plovdiv":

                    switch (productName)
                    {
                        case "coffee": sum = quantity * 0.40; break;
                        case "water": sum = quantity * 0.70; ; break;
                        case "beer": sum = quantity * 1.15; break;
                        case "sweets": sum = quantity * 1.30; break;
                        case "peanuts": sum = quantity * 1.50; break;

                    }
                    break;

                case "Varna":

                    switch (productName)
                    {
                        case "coffee": sum = quantity * 0.45; break;
                        case "water": sum = quantity * 0.70; ; break;
                        case "beer": sum = quantity * 1.10; break;
                        case "sweets": sum = quantity * 1.35; break;
                        case "peanuts": sum = quantity * 1.55; break;

                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine(sum);
        }
    }
}