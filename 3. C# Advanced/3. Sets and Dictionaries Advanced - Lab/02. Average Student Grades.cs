using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var dictionary = new Dictionary<string, List<decimal>>();
        var lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine().Split();

            if (dictionary.ContainsKey(input[0]))
            {
                dictionary[input[0]].Add(decimal.Parse(input[1]));
            }
            else
            {
                dictionary[input[0]] = new List<decimal>() { decimal.Parse(input[1]) };
            }
        }
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value.Select(x => x.ToString("F2")))} (avg: {kvp.Value.Average():f2})");
        }
    }
}