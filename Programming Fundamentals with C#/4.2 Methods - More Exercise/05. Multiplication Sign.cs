using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        if (num1 == 0 || num2 == 0 || num3 == 0)
        {
            Console.WriteLine("zero");
            return;
        }

        bool isNegative = true;
        isNegative = isNegativeNum(num1, isNegative);
        isNegative = isNegativeNum(num2, isNegative);
        isNegative = isNegativeNum(num3, isNegative);
        Console.WriteLine(isNegative ? "positive" : "negative");
    }

    static bool isNegativeNum(int num, bool isNegative)
    {
        if (num < 0)
        {
            isNegative = isNegative ? false : true;
        }
        return isNegative;
    }
}