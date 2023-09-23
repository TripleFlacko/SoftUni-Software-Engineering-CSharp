using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();
        string output = string.Join(" ", input.Reverse());
        Console.WriteLine(output);
    }
}