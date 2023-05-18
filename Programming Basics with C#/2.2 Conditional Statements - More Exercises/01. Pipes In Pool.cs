using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double poolFullness = (h * p1 + h * p2) / v;
            double p1Percentage = p1 * h / (h * p1 + h * p2);
            double p2Percentage = p2 * h / (h * p1 + h * p2);

            if (h * p1 + h * p2 <= v)
            {
                Console.WriteLine($"The pool is {poolFullness:p2} full. Pipe 1: {p1Percentage:p2}. Pipe 2: {p2Percentage:p2}.");
            }
            else
            {
                Console.WriteLine($"For {h} hours the pool overflows with {h * p1 + h * p2 - v:f2} liters.");
            }
        }
    }
}