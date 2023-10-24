using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var set = new HashSet<string>();

        for (int i = 0; i < lines; i++)
            set.Add(Console.ReadLine());
        foreach (var name in set)
            Console.WriteLine(name);
    }
}