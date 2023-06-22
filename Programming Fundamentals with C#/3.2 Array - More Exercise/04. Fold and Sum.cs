using System;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> firstRow = input.Take(input.Count / 2 / 2).ToList();
        firstRow.Reverse();

        List<int> lastQuarter = input.Skip(input.Count / 2 / 2 * 3).ToList();
        lastQuarter.Reverse();

        firstRow.AddRange(lastQuarter);

        List<int> secondRow = input.GetRange(input.Count / 2 / 2, input.Count / 2);

        List<int> result = new List<int>();

        for (int i = 0; i < firstRow.Count; i++)
        {
            result.Add(firstRow[i] + secondRow[i]);
        }

        Console.WriteLine(string.Join(' ', result));
    }
}
