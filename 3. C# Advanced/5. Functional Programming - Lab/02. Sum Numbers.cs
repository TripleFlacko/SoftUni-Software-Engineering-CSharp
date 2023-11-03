using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        Console.WriteLine(input.Length + "\n" + input.Sum());
    }
}