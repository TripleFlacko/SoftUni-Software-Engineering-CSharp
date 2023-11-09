using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;

            double capacity = (length * width * height) / 1000;

            double litres = capacity * (1 - percentage);
            Console.WriteLine(litres);
        }
    }
}