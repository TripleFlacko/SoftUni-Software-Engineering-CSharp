using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOffNumber = int.Parse(Console.ReadLine());
            int dayOffPlay = dayOffNumber * 127;
            int workDayNumber = 365 - dayOffNumber;
            int workDayPlay = workDayNumber * 63;
            int timeLeft = 30000 - workDayPlay - dayOffPlay;

            if (0 > timeLeft)
            {
                timeLeft = Math.Abs(timeLeft);
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor((double)timeLeft / 60)} hours and {timeLeft % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor((double)timeLeft / 60)} hours and {timeLeft % 60} minutes less for play");
            }


        }
    }
}