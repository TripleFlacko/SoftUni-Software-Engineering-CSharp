using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int f1 = 1; f1 <= 10; f1++)
            {
                for (int s2 = 1; s2 <= 10; s2++)
                {
                    Console.WriteLine($"{f1} * {s2} = {f1 * s2}");
                }
            }
        }
    }
}