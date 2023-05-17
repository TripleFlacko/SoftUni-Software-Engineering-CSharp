using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numberCount; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                sum += num1;
            }
            Console.WriteLine(sum);
        }
    }
}