using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        var output = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            output += (char)(input[i] + 3);
        }
        Console.WriteLine(output);
    }
}