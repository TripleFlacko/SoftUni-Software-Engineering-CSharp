using System;
using System.Text.RegularExpressions;
using System.Collections;

class Furniture
{
    public Furniture(string name, int quantity, decimal price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
    }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public decimal Total()
    {
        return Price * Quantity;
    }
}
class Program
{
    static void Main()
    {
        var list = new List<Furniture>();
        string pattern = @">>(?<name>[A-Z]+[a-z]*)<<(?<price>\d+|\d+\.\d+)!(?<quantity>\d+)";

        string input;
        while ((input = Console.ReadLine()) != "Purchase")
        {
            foreach (Match match in Regex.Matches(input, pattern))
            {
                var productName = match.Groups["name"].Value;
                var productQuantity = int.Parse(match.Groups["quantity"].Value);
                var productPrice = decimal.Parse(match.Groups["price"].Value);

                var product = new Furniture(productName, productQuantity, productPrice);
                list.Add(product);
            }
        }

        decimal total = 0m;

        Console.WriteLine("Bought furniture:");
        foreach (var furniture in list)
        {
            Console.WriteLine($"{furniture.Name}");
            total += furniture.Total();
        }
        Console.WriteLine($"Total money spend: {total:f2}");
    }
}