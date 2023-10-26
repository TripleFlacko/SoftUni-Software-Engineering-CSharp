using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var size = Console.ReadLine().Split();
        var n = int.Parse(size[0]);
        var m = int.Parse(size[1]);

        var set1 = new HashSet<int>();
        var set2 = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            set1.Add(int.Parse(Console.ReadLine()));
        }
        for (int i = 0; i < m; i++)
        {
            set2.Add(int.Parse(Console.ReadLine()));
        }

        var finalSet = new HashSet<int>(set1);
        finalSet.IntersectWith(set2);
        Console.WriteLine(string.Join(' ', finalSet));
    }
}