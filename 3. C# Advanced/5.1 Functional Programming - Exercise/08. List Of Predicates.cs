using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var rangeEnding = int.Parse(Console.ReadLine());
        var numbers = Enumerable.Range(1, rangeEnding);
        var dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<Predicate<int>> predicates = new List<Predicate<int>>();
        var validNums = new List<int>();
        foreach (var div in dividers)
        {
            Predicate<int> predicate = number => number % div == 0;
            predicates.Add(predicate);
        }
        foreach (var num in numbers)
        {
            var isValid = true;
            foreach (var predicate in predicates)
            {
                if (!predicate(num))
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                validNums.Add(num);
            }
        }
        Console.WriteLine(string.Join(" ", validNums));
    }
}