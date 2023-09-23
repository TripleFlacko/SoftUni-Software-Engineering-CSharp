using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine()) % 2;

            if (num == 0)
            {
                Console.WriteLine("even");
            }

            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}