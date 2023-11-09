using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < num)
            {
                int newNum = int.Parse(Console.ReadLine());
                sum += newNum;
            }
            Console.WriteLine(sum);
        }
    }
}