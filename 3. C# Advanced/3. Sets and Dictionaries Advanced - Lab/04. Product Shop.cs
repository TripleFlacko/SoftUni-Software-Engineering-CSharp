using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var markets = new Dictionary<string, Dictionary<string, double>>();
        string input;
        while ((input = Console.ReadLine()) != "Revision")
        {
            var data = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (markets.ContainsKey(data[0]))
            {
                markets[data[0]].Add(data[1], double.Parse(data[2]));
            }
            else
            {
                markets[data[0]] = new Dictionary<string, double>() { { data[1], double.Parse(data[2]) } };
            }
        }
        foreach (var market in markets.OrderBy(s => s.Key))
        {
            Console.WriteLine($"{market.Key}->");
            Console.WriteLine(string.Join("\n", market.Value.Select(x => $"Product: {x.Key}, Price: {x.Value}")));
        }
    }
}