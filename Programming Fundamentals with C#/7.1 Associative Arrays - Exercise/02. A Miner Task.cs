using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var dictionary = new Dictionary<string, int>();

        string inputKey;
        while ((inputKey = Console.ReadLine()) != "stop")
        {
            var inputValue = int.Parse(Console.ReadLine());
            if (!dictionary.ContainsKey(inputKey))
            {
                dictionary[inputKey] = inputValue;
            }
            else
            {
                dictionary[inputKey] += inputValue;
            }
        }
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}