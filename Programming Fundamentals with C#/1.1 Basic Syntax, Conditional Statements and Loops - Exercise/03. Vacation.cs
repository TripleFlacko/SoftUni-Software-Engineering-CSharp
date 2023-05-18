using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;

            switch (groupType)
            {
                case "Students":

                    switch (dayOfTheWeek)
                    {
                        case "Friday": price = 8.45; break;
                        case "Saturday": price = 9.80; break;
                        case "Sunday": price = 10.46; break;
                    }
                    break;

                case "Business":

                    switch (dayOfTheWeek)
                    {
                        case "Friday": price = 10.90; break;
                        case "Saturday": price = 15.60; break;
                        case "Sunday": price = 16; break;
                    }
                    break;

                case "Regular":

                    switch (dayOfTheWeek)
                    {
                        case "Friday": price = 15; break;
                        case "Saturday": price = 20; break;
                        case "Sunday": price = 22.50; break;
                    }
                    break;
            }

            if (numberOfPeople >= 30 && groupType == "Students")
            {
                price *= 0.85;
            }
            else if (numberOfPeople >= 100 && groupType == "Business")
            {
                Console.WriteLine($"Total price: {(numberOfPeople - 10) * price:F2}");
            }
            else if (numberOfPeople >= 10 && numberOfPeople <= 20 && groupType == "Regular")
            {
                price *= 0.95;
            }
            if (groupType != "Business" || numberOfPeople < 100)
            {
                Console.WriteLine($"Total price: {numberOfPeople * price:F2}");
            }
        }
    }
}