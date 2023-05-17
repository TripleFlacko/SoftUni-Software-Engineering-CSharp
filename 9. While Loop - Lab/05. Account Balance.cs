using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string deposit = Console.ReadLine();
            double sum = 0;

            while (deposit != "NoMoreMoney")
            {
                if (double.Parse(deposit) < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += double.Parse(deposit);
                Console.WriteLine($"Increase: {double.Parse(deposit):f2}");
                deposit = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}