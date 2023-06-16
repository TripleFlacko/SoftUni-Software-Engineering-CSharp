using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        PrintTriangle(input);
    }

    static void PrintTriangle(int input)
    {
        for (int i = 1; i <= input; i++)
        {
            PrintLine(i);
        }
        for (int i = input - 1; i >= 1; i--)
        {
            PrintLine(i);
        }
    }

    static void PrintLine(int end)
    {
        for (int i2 = 1; i2 <= end; i2++)
        {
            Console.Write(i2 + " ");
        }
        Console.WriteLine();
    }
}