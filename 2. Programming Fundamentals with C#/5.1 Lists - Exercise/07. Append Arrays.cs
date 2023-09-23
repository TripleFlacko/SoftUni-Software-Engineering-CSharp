using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        List<string> numbers = Console.ReadLine().Split('|', StringSplitOptions.TrimEntries).ToList();

        List<int> finalList = new List<int>();

        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            List<int> temp = numbers[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            finalList.AddRange(temp);
        }

        Console.WriteLine(string.Join(' ', finalList));
    }
}