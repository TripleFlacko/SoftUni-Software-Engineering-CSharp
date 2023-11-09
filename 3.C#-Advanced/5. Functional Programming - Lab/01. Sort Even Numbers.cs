using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

public class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x => x).ToList();
        Console.WriteLine(string.Join(", ", input));
    }
}