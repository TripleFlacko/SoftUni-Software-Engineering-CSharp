using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var word = Console.ReadLine();
        var input = Console.ReadLine();

        while (input.Contains(word))
        {
            input = input.Remove(input.IndexOf(word), word.Length);
        }
        Console.WriteLine(input);
    }
}