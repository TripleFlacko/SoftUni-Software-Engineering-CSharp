using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPagesInBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int amountOfDays = int.Parse(Console.ReadLine());
            double hoursPerDay = (amountOfPagesInBook / pagesPerHour) / amountOfDays;
            Console.WriteLine(hoursPerDay);
        }
    }
}