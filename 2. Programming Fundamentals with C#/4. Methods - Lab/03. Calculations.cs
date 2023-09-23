using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string action = Console.ReadLine();
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(Calculation(action, num1, num2));
    }

    static int? Calculation(string action, int num1, int num2)
    {
        switch (action)
        {
            case "add": return num1 + num2;
            case "multiply": return num1 * num2;
            case "subtract": return num1 - num2;
            case "divide": return num1 / num2;
            default: return null;
        }
    }
}