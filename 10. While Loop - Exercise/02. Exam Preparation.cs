using System;

namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGradeNumber = int.Parse(Console.ReadLine());
            double gradeCounter = 0;
            double gradeSum = 0;
            int badGrades = 0;
            string lastProblem = "";

            while (true)
            {
                string taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    Console.WriteLine($"Average score: {gradeSum / gradeCounter:f2}");
                    Console.WriteLine($"Number of problems: {gradeCounter}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                gradeSum += grade;

                if (grade <= 4)
                {
                    badGrades++;
                }
                if (badGrades >= badGradeNumber)
                {
                    Console.WriteLine($"You need a break, {badGrades} poor grades.");
                    break;
                }

                gradeCounter++;
                lastProblem = taskName;

            }
        }
    }
}