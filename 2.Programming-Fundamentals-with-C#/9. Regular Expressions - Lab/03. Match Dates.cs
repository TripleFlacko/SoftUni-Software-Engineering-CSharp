using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattern = @"\b(?<day>\d{2})(?<delimiter>[.\-/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";

        string input = Console.ReadLine();

        foreach (Match date in Regex.Matches(input, pattern))
        {
            Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
        }
    }
}