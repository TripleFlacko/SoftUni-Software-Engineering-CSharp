using System;

class Program
{
    static void Main(string[] args)
    {
        var maxLength = int.Parse(Console.ReadLine());
        var names = Console.ReadLine().Split().ToList();

        Predicate<string> validLength = name =>
        {
            if (name.Length <= maxLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        };
        var validList = new List<string>();
        foreach (var name in names)
        {
            if (validLength(name))
            {
                validList.Add(name);
            }
        }
        Console.WriteLine(string.Join(Environment.NewLine, validList));
    }
}