using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        List<Person> people = ReadPeople(lines);

        var condition = Console.ReadLine();
        var ageThreshold = int.Parse(Console.ReadLine());
        var format = Console.ReadLine();

        Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
        Action<Person> printer = CreatePrinter(format);
        PrintFilteredPeople(people, filter, printer);

    }

    private static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
    {
        foreach (var person in people)
        {
            if (filter(person))
            {
                printer(person);
            }
        }
    }

    private static Action<Person> CreatePrinter(string format)
    {
        if (format == "name")
        {
            return s => Console.WriteLine(s.Name);
        }
        else if (format == "age")
        {
            return s => Console.WriteLine(s.Age);
        }
        else if (format == "name age")
        {
            return s => Console.WriteLine($"{s.Name} - {s.Age}");
        }

        return null;
    }

    private static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
    {
        Func<Person, bool> filter = null;

        if (condition == "older")
        {
            filter = x => x.Age >= ageThreshold;
        }
        else if (condition == "younger")
        {
            filter = x => x.Age < ageThreshold;
        }

        return filter;
    }

    private static List<Person> ReadPeople(int lines)
    {
        var people = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine().Split(", ");
            var name = input[0];
            var age = int.Parse(input[1]);

            var person = new Person(name, age);
            people.Add(person);
        }
        return people;
    }
}

public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public string Name { get; set; }
    public int Age { get; set; }
}