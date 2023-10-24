using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var database = new Dictionary<string, Dictionary<string, List<string>>>();
        var lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine().Split();
            var continent = input[0];
            var country = input[1];
            var city = input[2];

            if (database.ContainsKey(continent))
            {
                if (database[continent].ContainsKey(country))
                {
                    database[continent][country].Add(city);
                }
                else
                {
                    database[continent][country] = new List<string>() { city };
                }
            }
            else
            {
                database[continent] = new Dictionary<string, List<string>>()
                {
                    { country, new List<string>(){ city } }
                };
            }
        }
        foreach (var continent in database)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (var country in continent.Value)
            {
                Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
            }
        }
    }
}