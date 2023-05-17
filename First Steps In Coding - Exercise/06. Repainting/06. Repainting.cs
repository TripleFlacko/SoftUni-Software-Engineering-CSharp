using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylon = (double.Parse(Console.ReadLine()) + 2) * 1.50;
            double paint = (double.Parse(Console.ReadLine()) * 1.1) * 14.5;
            double thinner = double.Parse(Console.ReadLine()) * 5;
            double hours = double.Parse(Console.ReadLine());
            double totalForMaterials = nylon + paint + thinner + 0.4;
            double totalForWorkers = (totalForMaterials * 0.3) * hours;
            double total = (totalForWorkers + totalForMaterials);
            Console.WriteLine(total);
        }
    }
}