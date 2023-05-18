using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double formula = a * h / 2;
            Console.WriteLine($"{formula:f2}");
        }
    }
}