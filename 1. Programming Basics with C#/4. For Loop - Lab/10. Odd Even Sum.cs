using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine($"Yes\r\nSum = {sumEven}");
            }
            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(sumOdd - sumEven)}");
            }
        }
    }
}