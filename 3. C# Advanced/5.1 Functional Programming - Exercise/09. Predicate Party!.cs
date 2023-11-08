using System;
using System.Diagnostics;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        var people = Console.ReadLine().Split().ToList();

        string input;
        while ((input = Console.ReadLine()) != "Party!")
        {
            var tokens = input.Split().ToArray();
            var command = tokens[0];
            var condition = tokens[1];
            var value = tokens[2];

            var predicate = GetPredicate(condition, value);

            switch (command)
            {
                case "Double":

                    var namesFound = people.FindAll(predicate);

                    foreach (var person in namesFound)
                    {
                        var index = people.IndexOf(person);
                        people.Insert(index, person);
                    }
                    break;
                case "Remove":
                    people.RemoveAll(predicate);
                    break;
            }
        }
        if (people.Any())
        {
            Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
        }
        else
        {
            Console.WriteLine("Nobody is going to the party!");
        }
    }
    private static Predicate<string> GetPredicate(string input, string value)
    {
        switch (input)
        {
            case "StartsWith":
                return ch => ch.StartsWith(value);
            case "EndsWith":
                return ch => ch.EndsWith(value);
            case "Length":
                return ch => ch.Length == int.Parse(value);
        }
        return default;
    }
}