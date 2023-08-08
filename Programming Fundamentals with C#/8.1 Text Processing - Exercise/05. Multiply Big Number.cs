using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        var num1 = Console.ReadLine();
        var num2 = int.Parse(Console.ReadLine());

        if (num2 != 0 && num1 != "0")
        {
            Console.WriteLine(MultiplyBigNumber(num1, num2));
        }
        else
        {
            Console.WriteLine(0);
        }
    }

    private static string MultiplyBigNumber(string num1, int num2)
    {
        int remainder = 0;
        StringBuilder result = new StringBuilder();

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            int digitToMultiply = num1[i] - '0';
            result.Insert(0, (digitToMultiply * num2 + remainder) % 10);
            remainder = (digitToMultiply * num2 + remainder) / 10;
        }
        if (remainder != 0)
        {
            result.Insert(0, remainder);
        }

        return string.Join("", result);
    }
}