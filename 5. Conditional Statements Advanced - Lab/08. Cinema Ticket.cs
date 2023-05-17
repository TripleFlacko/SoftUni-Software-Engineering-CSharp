using System;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int price = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                    price = 12; break;
                case "Wednesday":
                case "Thursday":
                    price = 14; break;
                case "Friday":
                    price = 12; break;
                case "Saturday":
                case "Sunday":
                    price = 16; break;
            }
            Console.WriteLine(price);

        }
    }
}