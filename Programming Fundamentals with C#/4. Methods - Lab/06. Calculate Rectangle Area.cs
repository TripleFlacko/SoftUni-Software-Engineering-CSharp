using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine(CalculateArea(num1, num2));
    }
    static int CalculateArea(int num1, int num2)
    {
        return num1 * num2;
    }
}