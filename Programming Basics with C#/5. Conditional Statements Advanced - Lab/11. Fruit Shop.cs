using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double priceTotal = 0;

            if (fruit != "banana" && fruit != "apple" && fruit != "orange" && fruit != "grapefruit" && fruit != "kiwi" && fruit != "pineapple" && fruit != "grapes")
            {
                Console.WriteLine("error");
            }

            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        priceTotal = quantity * 2.50;
                        break;
                    case "apple":
                        priceTotal = quantity * 1.20;
                        break;
                    case "orange":
                        priceTotal = quantity * 0.85;
                        break;
                    case "grapefruit":
                        priceTotal = quantity * 1.45;
                        break;
                    case "kiwi":
                        priceTotal = quantity * 2.70;
                        break;
                    case "pineapple":
                        priceTotal = quantity * 5.50;
                        break;
                    case "grapes":
                        priceTotal = quantity * 3.85;
                        break;
                }
                Console.WriteLine($"{priceTotal:f2}");
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        priceTotal = quantity * 2.70;
                        break;
                    case "apple":
                        priceTotal = quantity * 1.25;
                        break;
                    case "orange":
                        priceTotal = quantity * 0.90;
                        break;
                    case "grapefruit":
                        priceTotal = quantity * 1.60;
                        break;
                    case "kiwi":
                        priceTotal = quantity * 3.00;
                        break;
                    case "pineapple":
                        priceTotal = quantity * 5.60;
                        break;
                    case "grapes":
                        priceTotal = quantity * 4.20;
                        break;
                }
                Console.WriteLine($"{priceTotal:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}