using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberStudents = int.Parse(Console.ReadLine());

            double to299 = 0;
            double to399 = 0;
            double to499 = 0;
            double to600 = 0;

            double averageGrade = 0;

            for (int i = 0; i < numberStudents; i++)
            {
                double studentGrades = double.Parse(Console.ReadLine());
                averageGrade += studentGrades;

                if (studentGrades <= 2.99)
                {
                    to299++;
                }
                else if (studentGrades <= 3.99)
                {
                    to399++;
                }
                else if (studentGrades <= 4.99)
                {
                    to499++;
                }
                else if (studentGrades <= 6.00)
                {
                    to600++;
                }
            }
            Console.WriteLine($"Top students: {to600 / numberStudents:p2}");
            Console.WriteLine($"Between 4.00 and 4.99: {to499 / numberStudents:p2}");
            Console.WriteLine($"Between 3.00 and 3.99: {to399 / numberStudents:p2}");
            Console.WriteLine($"Fail: {to299 / numberStudents:p2}");
            Console.WriteLine($"Average: {averageGrade / numberStudents:f2}");
        }
    }
}