using System;
using System.Diagnostics;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double littersLeft = double.Parse(Console.ReadLine());
            string fuel = "";

            switch (fuelType)
            {
                case "Diesel": fuel += "Diesel"; break;
                case "Gasoline": fuel += "Gasoline"; break;
                case "Gas": fuel += "Gas"; break;
            }

            if (fuelType != "Diesel" && fuelType != "Gasoline" && fuelType != "Gas")
            {
                Console.WriteLine("Invalid fuel!");
            }
            else if (littersLeft >= 25)
            {
                Console.WriteLine($"You have enough {fuel.ToLower()}.");
            }
            else
            {
                Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
            }
        }
    }
}