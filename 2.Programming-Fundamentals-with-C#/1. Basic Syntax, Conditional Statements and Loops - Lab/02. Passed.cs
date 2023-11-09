using System;

namespace _02.Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            if (input >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}