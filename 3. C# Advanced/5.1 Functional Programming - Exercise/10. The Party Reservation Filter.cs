using System;
using System.Diagnostics;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        var people = Console.ReadLine().Split().ToList();
        var filters = new Dictionary<string, Predicate<string>>();

        string command;
        while ((command = Console.ReadLine()) != "Print")
        {
            var tokens = command.Split(';').ToArray();
            var action = tokens[0];
            var filter = tokens[1];
            var value = tokens[2];
            switch (action)
            {
                case "Add filter":
                    filters.Add(filter + value, CreatePredicate(filter, value));
                    break;
                case "Remove filter":
                    filters.Remove(filter + value);
                    break;
            }
        }
        foreach (var filter in filters)
        {
            people.RemoveAll(filter.Value);
        }
        Console.WriteLine(string.Join(" ", people));
    }
    private static Predicate<string> CreatePredicate(string filter, string value)
    {
        switch (filter)
        {
            case "Starts with":
                return ch => ch.StartsWith(value);
            case "Ends with":
                return ch => ch.EndsWith(value);
            case "Length":
                return ch => ch.Length == int.Parse(value);
            case "Contains":
                return ch => ch.Contains(value);
        }
        return default;
    }
}