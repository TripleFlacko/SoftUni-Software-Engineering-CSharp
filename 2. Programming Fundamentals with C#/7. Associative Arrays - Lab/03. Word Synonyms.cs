using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var numberLines = int.Parse(Console.ReadLine());
        var synonyms = new Dictionary<string, List<string>>();


        for (int i = 0; i < numberLines; i++)
        {
            string word = Console.ReadLine();
            string synonym = Console.ReadLine();

            if (synonyms.ContainsKey(word))
            {
                synonyms[word].Add(synonym);
            }
            else
            {
                synonyms.Add(word, new List<string>() { synonym });
            }
        }
        foreach (var kvp in synonyms)
        {
            Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
        }
    }
}