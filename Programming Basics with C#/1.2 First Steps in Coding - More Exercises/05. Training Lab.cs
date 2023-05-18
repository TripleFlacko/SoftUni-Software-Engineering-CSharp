using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double workPlaces = Math.Floor((h - 1) * 100 / 70) * Math.Floor(w * 100 / 120) - 3;
            Console.WriteLine(workPlaces);
        }
    }
}