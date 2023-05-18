using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int killometers = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            if (killometers < 20)
            {
                switch (timeOfTheDay)
                {
                    case "day": Console.WriteLine($"{0.70 + 0.79 * killometers:f2}"); break;
                    default: Console.WriteLine($"{0.70 + 0.90 * killometers:f2}"); break;
                }
            }
            else if (killometers < 100)
            {
                Console.WriteLine($"{0.09 * killometers:f2}");
            }
            else
            {
                Console.WriteLine($"{0.06 * killometers:f2}");
            }
        }
    }
}