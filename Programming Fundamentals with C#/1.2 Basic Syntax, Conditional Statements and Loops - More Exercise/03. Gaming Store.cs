using System;

namespace _03.Gaming_Store
{
    class Program
    {
        static void Main()
        {
            var currentBalance = double.Parse(Console.ReadLine());
            var price = 0d;
            var gameName = "";
            var totalSpent = 0d;

            while (true)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "OutFall 4": price = 39.99; gameName = "OutFall 4"; break;
                    case "CS: OG": price = 15.99; gameName = "CS: OG"; break;
                    case "Zplinter Zell": price = 19.99; gameName = "Zplinter Zell"; break;
                    case "Honored 2": price = 59.99; gameName = "Honored 2"; break;
                    case "RoverWatch": price = 29.99; gameName = "RoverWatch"; break;
                    case "RoverWatch Origins Edition": gameName = "RoverWatch Origins Edition"; price = 39.99; break;
                    case "Game Time": Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}"); break;
                    default: Console.WriteLine("Not Found"); break;
                }
                if (input == "Game Time")
                {
                    break;
                }
                if (currentBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    currentBalance -= price;
                    totalSpent += price;
                    Console.WriteLine($"Bought {gameName}");
                }
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!"); break;
                }
            }
        }
    }
}