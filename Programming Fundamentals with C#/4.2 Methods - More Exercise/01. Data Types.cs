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
        string inputType = Console.ReadLine();
        string input = Console.ReadLine();
        Console.WriteLine(GetAnswer(inputType, input));
    }

    public static string GetAnswer(string inputType, string input)
    {
        string output = string.Empty;
        int intMath = 0;
        decimal decimalMath = 0;

        switch (inputType)
        {
            case "int":
                intMath = int.Parse(input) * 2;
                output = $"{intMath}";
                break;

            case "real":
                decimalMath = decimal.Parse(input) * 1.5m;
                output = $"{decimalMath:F2}";
                break;

            case "string":
                output = $"${input}$";
                break;
        }

        return output;
    }
}