using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(double.Parse).ToList();
        var dictionary = new SortedDictionary<double, int>();

        for (int i = 0; i < input.Count; i++)
        {
            if (dictionary.ContainsKey(input[i]))
            {
                dictionary[input[i]]++;
            }
            else
            {
                dictionary[input[i]] = 1;
            }
        }
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}