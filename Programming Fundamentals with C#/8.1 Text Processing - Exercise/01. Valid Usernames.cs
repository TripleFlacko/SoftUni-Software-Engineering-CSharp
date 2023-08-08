using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split(", ").ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length < 3 || input[i].Length > 16)
            {
                continue;
            }

            bool isValid = input[i].All(character => char.IsLetterOrDigit(character) || character == '-' || character == '_');

            if (isValid)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}