using System;

namespace WeatherForecastPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = double.Parse(Console.ReadLine());

            if (temp < 5 || 35 < temp)
            {
                Console.WriteLine("unknown");
            }
            else if (5 <= temp && temp <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else if (temp <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (temp <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (temp <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (temp <= 35)
            {
                Console.WriteLine("Hot");
            }
        }
    }
}