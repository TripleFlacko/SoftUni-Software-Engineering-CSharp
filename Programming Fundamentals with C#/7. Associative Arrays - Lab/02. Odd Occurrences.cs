using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().ToList();
        var dictionary = new Dictionary<string, int>();

        for (int i = 0; i < input.Count; i++)
        {
            string value = input[i].ToLower();
            if (dictionary.ContainsKey(value))
            {
                dictionary[value]++;
            }
            else
            {
                dictionary[value] = 0;
            }
        }

        foreach (var kvp in dictionary)
        {
            if (kvp.Value % 2 == 0)
            {
                Console.Write($"{kvp.Key} ");
            }
        }
    }
}