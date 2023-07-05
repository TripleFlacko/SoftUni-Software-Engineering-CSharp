using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            AddStudentInfoToList(students, input);
        }

        PrintFilteredStudents(students);
    }

    private static void PrintFilteredStudents(List<Student> students)
    {
        string cityToFilter = Console.ReadLine();

        List<Student> filteredStudents = students
            .Where(s => s.HomeTown == cityToFilter)
            .ToList();

        foreach (Student student in filteredStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
        }
    }

    private static void AddStudentInfoToList(List<Student> students, string input)
    {
        List<string> list = input.Split().ToList();

        string firstName = list[0];
        string lastName = list[1];
        int age = int.Parse(list[2]);
        string homeTown = list[3];

        Student findStudent = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

        CheckIfStudentExistsAndAdd(students, firstName, lastName, age, homeTown, findStudent);
    }

    private static void CheckIfStudentExistsAndAdd(List<Student> students, string firstName, string lastName, int age, string homeTown, Student findStudent)
    {
        if (findStudent == null)
        {
            Student student = new Student(firstName, lastName, age, homeTown);
            students.Add(student);
        }
        else
        {
            findStudent.FirstName = firstName;
            findStudent.LastName = lastName;
            findStudent.Age = age;
            findStudent.HomeTown = homeTown;
        }
    }
}
class Student
{
    public Student(string firstName, string lastName, int age, string homeTown)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}