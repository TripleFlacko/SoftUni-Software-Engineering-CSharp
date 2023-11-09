using System;

class Program
{
    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());
        int courses = (int)Math.Ceiling(people / (double)capacity);
        Console.WriteLine(courses);
    }
}