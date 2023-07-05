using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var letters = new Dictionary<char, int>();

        var input = Console.ReadLine().Split().ToArray();
        string inputToString = string.Join("", input);

        for (int i = 0; i < inputToString.Length; i++)
        {
            if (!letters.ContainsKey(inputToString[i]))
            {
                letters.Add(inputToString[i], 0);
            }

            letters[inputToString[i]]++;
        }

        foreach (var letter in letters)
        {
            Console.WriteLine($"{letter.Key} -> {letter.Value}");
        }
    }
}