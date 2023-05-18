using System;

namespace Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "";

            while (true)
            {
                country = Console.ReadLine();
                if (country == "End")
                {
                    break;
                }

                double budget = double.Parse(Console.ReadLine());
                double moneySheHas = 0;

                while (moneySheHas < budget)
                {
                    moneySheHas += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {country}!");
                moneySheHas = 0;
            }
        }
    }
}