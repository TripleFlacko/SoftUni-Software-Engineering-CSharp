using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double columns = double.Parse(Console.ReadLine());

            double totalCost = 0.0;

            switch (projectionType)
            {
                case "Premiere":
                    totalCost = rows * columns * 12.00; break;
                case "Normal":
                    totalCost = rows * columns * 7.50; break;
                case "Discount":
                    totalCost = rows * columns * 5.00; break;
            }
            Console.WriteLine($"{totalCost:f2} leva");
        }
    }
}