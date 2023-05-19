using System;

namespace _2.Pounds_to_Dollars
{
    class Program
    {
        static void Main()
        {
            var input = decimal.Parse(Console.ReadLine()) * 1.31m;
            Console.WriteLine($"{input:f3}");
        }
    }
}