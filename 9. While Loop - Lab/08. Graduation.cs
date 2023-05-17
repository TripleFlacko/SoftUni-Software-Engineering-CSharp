using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades = 1;
            double sumGrades = 0;
            int excluded = 0;

            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    excluded++;
                }
                if (excluded == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grades - 1} grade");
                    break;
                }

                sumGrades += grade;
                grades++;
            }
            if (excluded < 2)
            {
                sumGrades = sumGrades / 12;
                Console.WriteLine($"{name} graduated. Average grade: {sumGrades:f2}");
            }
        }
    }
}