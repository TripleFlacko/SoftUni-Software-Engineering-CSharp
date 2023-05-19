using System;

namespace _3.Exact_Sum_of_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            var rows = int.Parse(Console.ReadLine());
            var sum = 0m;
            for (int i = 0; i < rows; i++)
            {
                var input = decimal.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine($"{sum}");
        }
    }
}