using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        Console.WriteLine(SubtractThirdNum(SumNumbers(num1, num2), num3));
    }
    static int SumNumbers(int num1, int num2)
    {
        return num1 + num2;
    }
    static int SubtractThirdNum(int sumNumbers, int num3)
    {
        return sumNumbers - num3;
    }
}