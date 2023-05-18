using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            double episodeDuration = double.Parse(Console.ReadLine());
            double breakDuration = double.Parse(Console.ReadLine());

            double lunch = breakDuration / 8;
            double chillTime = breakDuration / 4;

            double timeLeft = breakDuration - lunch - chillTime;

            if (timeLeft >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeft - episodeDuration)} minutes free time.");
            }

            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(Math.Abs(timeLeft - episodeDuration))} more minutes.");
            }
        }
    }
}