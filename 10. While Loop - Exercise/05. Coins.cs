using System;

namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int counter = 0;

            while (change % 2 != change)
            {
                change -= 2;
                counter++;
            }

            while (change % 1 != change)
            {
                change -= 1.00m;
                counter++;
            }

            while (change % 0.50m != change)
            {
                change -= 0.50m;
                counter++;
            }

            while (change % 0.20m != change)
            {
                change -= 0.20m;
                counter++;
            }

            while (change % 0.10m != change)
            {
                change -= 0.10m;
                counter++;
            }
            while (change % 0.05m != change)
            {
                change -= 0.05m;
                counter++;
            }
            while (change % 0.02m != change)
            {
                change -= 0.02m;
                counter++;
            }

            while (change % 0.01m != change)
            {
                change -= 0.01m;
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}