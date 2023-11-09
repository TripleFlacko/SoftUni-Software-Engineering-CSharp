using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < input; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            int sumWithoutMax = sum - max;

            if (sumWithoutMax == max)
            {
                Console.WriteLine($"Yes\r\nSum = {max}");
            }

            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(max - sumWithoutMax)}");
            }
        }
    }
}