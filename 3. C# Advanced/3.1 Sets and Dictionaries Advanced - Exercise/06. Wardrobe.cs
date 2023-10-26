using System;
using System.Numerics;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var wardrobe = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < lines; i++)
        {
            var input = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
            var color = input[0];

            if (wardrobe.ContainsKey(color))
            {
                for (int j = 1; j < input.Length; j++)
                {
                    if (wardrobe[color].ContainsKey(input[j]))
                    {
                        wardrobe[color][input[j]]++;
                    }
                    else
                    {
                        wardrobe[color][input[j]] = 1;
                    }
                }
            }
            else
            {
                wardrobe[color] = new Dictionary<string, int>();
                for (int j = 1; j < input.Length; j++)
                {
                    if (wardrobe[color].Count != 0 && wardrobe[color].ContainsKey(input[j]))
                    {
                        wardrobe[color][input[j]]++;
                    }
                    else
                    {
                        wardrobe[color][input[j]] = 1;
                    }
                }
            }
        }

        var itemToSearch = Console.ReadLine().Split();

        foreach (var items in wardrobe)
        {
            Console.WriteLine($"{items.Key} clothes:");
            foreach (var product in items.Value)
            {
                if (!(items.Key == itemToSearch[0] && product.Key == itemToSearch[1]))
                {
                    Console.WriteLine($"* {product.Key} - {product.Value}");
                }
                else
                {
                    Console.WriteLine($"* {product.Key} - {product.Value} (found!)");
                }
            }
        }
    }
}