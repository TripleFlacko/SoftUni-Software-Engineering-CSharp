using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattern = @"\b(?<firstName>[A-Z][a-z]{1,}) (?<secondName>[A-Z][a-z]{1,})\b";

        string input = Console.ReadLine();

        foreach (Match match in Regex.Matches(input, pattern))
        {
            Console.Write(match.Value + " ");
        }
    }
}