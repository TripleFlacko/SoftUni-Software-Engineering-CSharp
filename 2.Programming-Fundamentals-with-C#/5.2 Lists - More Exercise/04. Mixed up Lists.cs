using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var first = Console.ReadLine().Split().Select(int.Parse).ToList();
        var second = Console.ReadLine().Split().Select(int.Parse).ToList();
        var finalList = new List<int>();
        finalList.AddRange(first);
        finalList.AddRange(second);

        List<int> constraints = ExctractConstraints(first, second);

        finalList = finalList.Where(x => x > constraints[0] && x < constraints[1]).ToList();
        finalList.Sort();
        Console.WriteLine(string.Join(" ", finalList));
    }

    static List<int> ExctractConstraints(List<int> first, List<int> second)
    {
        var limiter = first.Count < second.Count ? first.Count : second.Count;

        for (int i = 0; i < limiter; i++)
        {
            first.RemoveAt(0);
        }
        for (int i = limiter; i > 0; i--)
        {
            second.RemoveAt(second.Count - 1);
        }

        var constraints = first.Count > second.Count ? first : second;
        constraints.Sort();
        return constraints;
    }
}