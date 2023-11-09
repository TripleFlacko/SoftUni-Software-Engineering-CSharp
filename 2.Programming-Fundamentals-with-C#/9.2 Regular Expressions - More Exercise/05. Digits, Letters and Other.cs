using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        var digits = "";
        var letters = "";
        var symbols = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                digits += input[i];
            }
            else if (char.IsLetter(input[i]))
            {
                letters += input[i];
            }
            else
            {
                symbols += input[i];
            }
        }
        Console.WriteLine($"{digits}\n{letters}\n{symbols}");
    }
}