using System;

namespace Odd___Even_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double oddSum = 0;
            double evenSum = 0;



            for (double i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number % 2 != 0)
                {

                    oddSum += number;           // нечетно

                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }

                }
                else
                {
                    evenSum += number;         //четно

                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }

                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            Console.WriteLine($"OddMin={oddMin:f2},");
            Console.WriteLine($"OddMax={oddMax:f2},");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            Console.WriteLine($"EvenMin={evenMin:f2},");
            Console.WriteLine($"EvenMax={evenMax:f2},");
        }
    }
}