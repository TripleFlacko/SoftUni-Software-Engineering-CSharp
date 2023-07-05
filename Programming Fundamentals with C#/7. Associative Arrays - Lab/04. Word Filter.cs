using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().ToList();
        var wordsEvenLength = input.Where(x => x.Length % 2 == 0).ToList();
        Console.WriteLine(string.Join('\n', wordsEvenLength));
    }
}