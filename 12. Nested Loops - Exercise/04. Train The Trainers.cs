using System;

namespace TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double gradeSum = 0;

            double gradeHolder = 0;

            int counter = 0;

            while (true)
            {
                string presentationName = Console.ReadLine();

                if (presentationName == "Finish")
                {

                    Console.WriteLine($"Student's final assessment is {gradeHolder / (double)counter:f2}.");
                    break;
                }

                for (int i = 0; i < people; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;
                    gradeHolder += grade;
                    counter++;
                }
                double avrgGrade = gradeSum / (double)people;

                Console.WriteLine($"{presentationName} - {avrgGrade:f2}.");

                gradeSum = 0;
            }
        }
    }
}