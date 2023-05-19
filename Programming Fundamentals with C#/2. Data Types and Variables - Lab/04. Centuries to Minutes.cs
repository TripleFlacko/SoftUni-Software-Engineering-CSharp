using System;

namespace _4.Centuries_to_Minutes

{
    class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine()), years = centuries * 100, days = (int)(years * 365.2422), hours = days * 24, minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}