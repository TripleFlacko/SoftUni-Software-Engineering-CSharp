using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double electricity = 0;
            int water = 0;
            int internet = 0;
            double other = 0;

            for (int i = 0; i < months; i++)
            {
                double bill = double.Parse(Console.ReadLine());

                electricity += bill;
                water += 20;
                internet += 15;
                other += (bill + 20 + 15) * 1.2;
            }

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {(electricity + water + internet + other) / months:f2} lv");
        }
    }
}