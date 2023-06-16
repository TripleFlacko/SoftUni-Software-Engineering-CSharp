using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        char operatorR = char.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(Calculations(num1, operatorR, num2));
    }
    static int? Calculations(int num1, char operatorR, int num2)
    {
        switch (operatorR)
        {
            case '+': return num1 + num2;
            case '-': return num1 - num2;
            case '*': return num1 * num2;
            case '/': return num1 / num2;
            default: return null;
        }
    }
}