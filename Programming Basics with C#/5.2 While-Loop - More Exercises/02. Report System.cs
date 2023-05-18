using System;


namespace _02._ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            int counter = 0, counterCash = 0, counterCard = 0, paidCash = 0, paidCard = 0, totalSum = 0;

            while (true)
            {
                if (totalSum >= sum)
                {
                    Console.WriteLine($"Average CS: {paidCash / (double)counterCash:f2}\nAverage CC: {paidCard / (double)counterCard:f2}");
                    break;
                }

                string command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }

                int product = int.Parse(command);
                counter++;

                if (counter % 2 == 0)
                {
                    if (product < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                        continue;
                    }
                    totalSum += product;
                    paidCard += product;
                    counterCard++;
                    Console.WriteLine($"Product sold!");
                }

                else
                {
                    if (product > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                        continue;
                    }
                    totalSum += product;
                    paidCash += product;
                    counterCash++;
                    Console.WriteLine($"Product sold!");
                }

            }
        }
    }
}