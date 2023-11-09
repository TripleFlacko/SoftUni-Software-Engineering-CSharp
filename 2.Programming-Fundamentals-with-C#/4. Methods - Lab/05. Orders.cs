using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        Console.WriteLine($"{Calculations(product, quantity):f2}");
    }
    static double? Calculations(string product, int quantity)
    {
        switch (product)
        {
            case "coffee": return quantity * 1.50;
            case "water": return quantity * 1.00;
            case "coke": return quantity * 1.40;
            case "snacks": return quantity * 2.00;
            default: return null;
        }
    }
}