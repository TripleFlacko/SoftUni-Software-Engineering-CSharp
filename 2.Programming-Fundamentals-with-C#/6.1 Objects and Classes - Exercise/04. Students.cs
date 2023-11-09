using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string firstName = input[0];
            string lastName = input[1];
            double grade = double.Parse(input[2]);
            Student student = new Student(firstName, lastName, grade);
            students.Add(student);
        }

        List<Student> sortedByGradesDescending = students.OrderByDescending(s => s.Grade).ToList();

        foreach (Student student in sortedByGradesDescending)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
        }
    }
}
class Student
{
    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
}