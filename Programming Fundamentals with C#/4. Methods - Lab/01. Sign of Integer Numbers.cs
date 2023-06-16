using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine($"The number {input} is {NumIsPositive(input)}.");
    }

    static string NumIsPositive(int input)
    {
        if (input < 0) return "negative";
        else if (input > 0) return "positive";
        else return "zero";
    }
}