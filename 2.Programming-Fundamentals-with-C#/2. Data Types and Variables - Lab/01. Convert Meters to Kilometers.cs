using System;

namespace _1.Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main()
        {
            var input = double.Parse(Console.ReadLine()) / 1000;
            Console.WriteLine($"{input:f2}");
        }
    }
}