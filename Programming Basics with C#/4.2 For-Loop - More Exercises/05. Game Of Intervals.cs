using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMoves = int.Parse(Console.ReadLine());

            double totalScore = 0;

            double to9 = 0;
            double to19 = 0;
            double to29 = 0;
            double to39 = 0;
            double to50 = 0;
            double invalid = 0;

            for (int i = 0; i < numberOfMoves; i++)
            {
                int scorePerMove = int.Parse(Console.ReadLine());

                if (scorePerMove < 0 || scorePerMove > 50)
                {
                    totalScore /= 2;
                    invalid++;
                }
                else if (scorePerMove <= 9)
                {
                    totalScore += scorePerMove * 0.2;
                    to9++;
                }
                else if (scorePerMove <= 19)
                {
                    totalScore += scorePerMove * 0.3;
                    to19++;
                }
                else if (scorePerMove <= 29)
                {
                    totalScore += scorePerMove * 0.4;
                    to29++;
                }
                else if (scorePerMove <= 39)
                {
                    totalScore += 50;
                    to39++;
                }
                else if (scorePerMove <= 50)
                {
                    totalScore += 100;
                    to50++;
                }
            }

            Console.WriteLine($"{totalScore:f2}");
            Console.WriteLine($"From 0 to 9: {to9 / numberOfMoves:p2}");
            Console.WriteLine($"From 10 to 19: {to19 / numberOfMoves:p2}");
            Console.WriteLine($"From 20 to 29: {to29 / numberOfMoves:p2}");
            Console.WriteLine($"From 30 to 39: {to39 / numberOfMoves:p2}");
            Console.WriteLine($"From 40 to 50: {to50 / numberOfMoves:p2}");
            Console.WriteLine($"Invalid numbers: {invalid / numberOfMoves:p2}");

        }
    }
}