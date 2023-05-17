using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceApartment = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio += 50;
                    priceApartment += 65;
                    break;
                case "June":
                case "September":
                    priceStudio += 75.20;
                    priceApartment += 68.70;
                    break;
                case "July":
                case "August":
                    priceStudio += 76;
                    priceApartment += 77;
                    break;
            }

            if (nights > 7 && nights <= 14 && (month == "May" || month == "October"))
            {
                priceStudio *= 0.95;
            }
            else if (nights > 14 && (month == "May" || month == "October"))
            {
                priceStudio *= 0.70;
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                priceStudio *= 0.80;
            }
            if (nights > 14)
            {
                priceApartment *= 0.90;
            }
            Console.WriteLine($"Apartment: {priceApartment * nights:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio * nights:f2} lv.");
        }
    }
}