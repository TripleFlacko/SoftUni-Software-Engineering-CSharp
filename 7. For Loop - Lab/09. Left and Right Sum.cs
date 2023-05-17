using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum2 = 0;

            for (int i = 1; i <= times; i++)
            {
                int firstColumn = int.Parse(Console.ReadLine());
                sum += firstColumn;
            }
            for (int i = 1; i <= times; i++)
            {
                int secondColumn = int.Parse(Console.ReadLine());
                sum2 += secondColumn;
            }
            if (sum == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum - sum2)}");
            }
        }
    }
}