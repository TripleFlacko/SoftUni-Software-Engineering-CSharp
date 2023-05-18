using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int pupilsNumber = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            string sport = "";
            double price = 0;

            switch (season)
            {
                case "Winter":

                    switch (groupType)
                    {
                        case "boys": sport += "Judo"; price += 9.60; break;
                        case "girls": sport += "Gymnastics"; price += 9.60; break;
                        case "mixed": sport += "Ski"; price += 10; break;

                    }
                    break;

                case "Spring":

                    switch (groupType)
                    {
                        case "boys": sport += "Tennis"; price += 7.20; break;
                        case "girls": sport += "Athletics"; price += 7.20; break;
                        case "mixed": sport += "Cycling"; price += 9.50; break;

                    }
                    break;

                case "Summer":

                    switch (groupType)
                    {
                        case "boys": sport += "Football"; price += 15; break;
                        case "girls": sport += "Volleyball"; price += 15; break;
                        case "mixed": sport += "Swimming"; price += 20; break;

                    }
                    break;
            }

            if (pupilsNumber >= 50)
            {
                price *= 0.50;
            }
            else if (pupilsNumber >= 20)
            {
                price *= 0.85;
            }
            else if (pupilsNumber >= 10)
            {
                price *= 0.95;
            }

            Console.WriteLine($"{sport} {price * nights * pupilsNumber:f2} lv.");
        }
    }
}