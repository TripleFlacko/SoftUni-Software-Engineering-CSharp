using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var set = new HashSet<string>();
        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine();
            set.Add(input);
        }
        Console.WriteLine(string.Join("\n", set));
    }
}