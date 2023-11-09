using System;

namespace FuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litters = double.Parse(Console.ReadLine());
            string discount = Console.ReadLine();
            double price = 0;

            switch (fuelType)
            {
                case "Diesel":

                    switch (discount)
                    {
                        case "Yes": price += 2.21; break;
                        case "No": price += 2.33; break;
                    }
                    break;

                case "Gasoline":

                    switch (discount)
                    {
                        case "Yes": price += 2.04; break;
                        case "No": price += 2.22; break;
                    }
                    break;

                case "Gas":

                    switch (discount)
                    {
                        case "Yes": price += 0.85; break;
                        case "No": price += 0.93; break;
                    }
                    break;
            }
            if (20 <= litters && litters <= 25)
            {
                price *= 0.92;
            }
            else if (25 < litters)
            {
                price *= 0.9;
            }

            Console.WriteLine($"{litters * price:f2} lv.");
        }
    }
}