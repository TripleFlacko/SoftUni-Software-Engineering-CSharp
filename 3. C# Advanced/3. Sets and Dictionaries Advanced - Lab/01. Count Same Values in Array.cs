using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var dictionary = new Dictionary<double, int>();
        var input = Console.ReadLine().Split().Select(double.Parse).ToArray();

        for (int i = 0; i < input.Length; i++)
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
            Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
        }
    }
}