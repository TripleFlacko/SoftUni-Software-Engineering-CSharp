using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var dictionary = new SortedDictionary<char, int>();
        var text = Console.ReadLine();
        for (int i = 0; i < text.Length; i++)
        {
            if (dictionary.ContainsKey(text[i]))
            {
                dictionary[text[i]]++;
            }
            else
            {
                dictionary[text[i]] = 1;
            }
        }
        foreach (var character in dictionary)
        {
            Console.WriteLine($"{character.Key}: {character.Value} time/s");
        }
    }
}