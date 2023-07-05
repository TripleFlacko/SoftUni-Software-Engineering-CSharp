using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var dictionary = new Dictionary<string, List<decimal>>();

        string input;
        while ((input = Console.ReadLine()) != "buy")
        {
            var productInfo = input.Split().ToArray();
            var productName = productInfo[0];
            var productPrice = decimal.Parse(productInfo[1]);
            var productQuantity = int.Parse(productInfo[2]);

            if (!dictionary.ContainsKey(productName))
            {
                dictionary[productName] = new List<decimal>() { productPrice, productQuantity };
            }
            else
            {
                dictionary[productName][0] = productPrice;
                dictionary[productName][1] += productQuantity;
            }
        }
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value[0] * kvp.Value[1]:f2}");
        }
    }
}