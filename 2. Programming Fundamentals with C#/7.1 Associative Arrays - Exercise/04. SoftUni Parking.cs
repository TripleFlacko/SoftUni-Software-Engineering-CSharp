using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var registry = new Dictionary<string, string>();

        int numberLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberLines; i++)
        {
            var commands = Console.ReadLine().Split().ToArray();
            var name = commands[1];

            switch (commands[0])
            {
                case "register":

                    if (registry.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {commands[2]}");
                        break;
                    }

                    registry[name] = commands[2];
                    Console.WriteLine($"{name} registered {registry[name]} successfully");
                    break;

                case "unregister":

                    if (!registry.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        break;
                    }

                    registry.Remove(name);
                    Console.WriteLine($"{name} unregistered successfully");
                    break;
            }
        }
        foreach (var kvp in registry)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }
    }
}