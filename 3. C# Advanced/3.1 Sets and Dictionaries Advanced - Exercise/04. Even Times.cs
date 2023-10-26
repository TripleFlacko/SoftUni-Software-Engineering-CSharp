using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var dictionary = new Dictionary<int, int>();
        var lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            var input = int.Parse(Console.ReadLine());
            if (dictionary.ContainsKey(input))
            {
                dictionary[input]++;
            }
            else
            {
                dictionary[input] = 1;
            }
        }
        Console.WriteLine(dictionary.First(x => x.Value % 2 == 0).Key);
    }
}