using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = double.Parse(Console.ReadLine());
            double formula = celcius * 1.8 + 32;
            Console.WriteLine($"{formula:f2}");

        }
    }
}

