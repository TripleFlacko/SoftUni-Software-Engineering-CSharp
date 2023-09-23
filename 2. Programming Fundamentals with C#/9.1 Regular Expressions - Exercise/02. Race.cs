using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string participants = Console.ReadLine();
        var participantsNames = participants.Split(", ").ToArray();

        string input;

        string matchLetters = @"[A-Za-z]";
        string matchDigits = @"\d";

        var results = new Dictionary<string, int>();

        while ((input = Console.ReadLine()) != "end of race")
        {
            MatchCollection letters = Regex.Matches(input, matchLetters);
            MatchCollection digits = Regex.Matches(input, matchDigits);

            string name = string.Join("", letters);
            if (participantsNames.Contains(name) && !results.ContainsKey(name))
            {
                var totalKM = digits
                    .Cast<Match>()
                    .Select(m => int.TryParse(m.Value, out int num) ? num : 0)
                    .Sum(); ;

                results.Add(name, totalKM);
            }
            else if (participantsNames.Contains(name) && results.ContainsKey(name))
            {
                results[name] += digits
                    .Cast<Match>()
                    .Select(m => int.TryParse(m.Value, out int num) ? num : 0)
                    .Sum(); ;
            }
        }

        results = results.OrderByDescending(r => r.Value).ToDictionary(x => x.Key, x => x.Value);

        Console.WriteLine($"1st place: {results.ElementAt(0).Key}\n" +
            $"2nd place: {results.ElementAt(1).Key}\n" +
            $"3rd place: {results.ElementAt(2).Key}");
    }
}
