using System;

namespace _07.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayType = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age >= 0 && age <= 18)
            {
                switch (dayType)
                {
                    case "Weekday": price = 12; break;
                    case "Weekend": price = 15; break;
                    case "Holiday": price = 5; break;
                }
            }
            else if (18 < age && age <= 64)
            {
                switch (dayType)
                {
                    case "Weekday": price = 18; break;
                    case "Weekend": price = 20; break;
                    case "Holiday": price = 12; break;
                }
            }
            else if (64 < age && age <= 122)
            {
                switch (dayType)
                {
                    case "Weekday": price = 12; break;
                    case "Weekend": price = 15; break;
                    case "Holiday": price = 10; break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
            if (0 <= age && age <= 122)
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}
