using System;
using System.Diagnostics;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        var names = Console.ReadLine().Split().ToArray();

        Func<string[], Func<string, int, bool>, int, string> findNames = (names, isValid, num) =>
        {
            foreach (var name in names)
            {
                if (isValid(name, num))
                {
                    return name;
                }
            }
            return default;
        };

        Func<string, int, bool> isValid = (name, condition) =>
        {
            var charSum = name.Sum(ch => ch);
            return charSum >= condition;
        };

        Console.WriteLine(findNames(names, isValid, number));
    }
}