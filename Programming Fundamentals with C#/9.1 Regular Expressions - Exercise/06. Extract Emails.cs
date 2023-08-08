using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        string regexEmail = @"(?<=\s|^)[a-zA-Z0-9]+([._-][a-zA-Z0-9]+)*@([a-z\-]+\.[a-z]+\.[a-z]+|[a-z\-]+\.[a-z]+)";
        //test
        foreach (Match match in Regex.Matches(input, regexEmail))
        {
            Console.WriteLine(match.Value);
        }
    }
}