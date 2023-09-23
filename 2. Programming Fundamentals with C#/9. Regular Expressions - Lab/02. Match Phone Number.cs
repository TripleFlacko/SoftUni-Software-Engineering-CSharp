using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pattern = @" *\+359(?<delimiter>[ -])2\k<delimiter>\d{3}\k<delimiter>\d{4}\b";

        string input = Console.ReadLine();

        var validNumbers = Regex.Matches(input, pattern)
            .Select(x => x.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(", ", validNumbers));
    }
}