using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var dictionary = new Dictionary<string, List<string>>();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var input = command.Split(" -> ").ToArray();
            var company = input[0];
            var employee = input[1];

            if (!dictionary.ContainsKey(company))
            {
                dictionary[company] = new List<string>() { employee };
            }
            else
            {
                if (!dictionary[company].Contains(employee))
                {
                    dictionary[company].Add(employee);
                }
            }
        }
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}");
            foreach (var employee in kvp.Value)
            {
                Console.WriteLine($"-- {employee}");
            }
        }

    }
}