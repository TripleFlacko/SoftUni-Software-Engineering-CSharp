using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int earnedPoints = 0;
            int wins = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string stage = Console.ReadLine();

                switch (stage)
                {
                    case "W": earnedPoints += 2000; wins++; break;
                    case "F": earnedPoints += 1200; break;
                    case "SF": earnedPoints += 720; break;
                }
            }

            double averagePoints = earnedPoints / tournaments;
            double percentageWins = (double)wins / tournaments;

            Console.WriteLine($"Final points: {startingPoints + earnedPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentageWins:p2}");

        }
    }
}