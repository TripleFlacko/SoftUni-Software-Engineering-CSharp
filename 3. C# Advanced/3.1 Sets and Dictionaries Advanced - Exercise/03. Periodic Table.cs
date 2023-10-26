using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var set = new SortedSet<string>();

        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine().Split();
            for (int j = 0; j < input.Length; j++)
            {
                set.Add(input[j]);
            }
        }
        Console.WriteLine(string.Join(' ', set));
    }
}