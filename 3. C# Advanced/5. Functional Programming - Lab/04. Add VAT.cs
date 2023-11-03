using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => x * 1.2).Select(x => x.ToString("F2")).ToArray();
        Console.WriteLine(string.Join("\n", input));
    }
}