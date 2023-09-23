using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(FindMiddleChar(input));
    }
    static string FindMiddleChar(string input)
    {
        string middleChar = string.Empty;

        if (input.Length % 2 == 0)
        {

            for (int i = input.Length / 2 - 1; i <= input.Length / 2; i++)
            {
                middleChar += input[i];
            }
        }
        else
        {
            for (int i = input.Length / 2; i <= input.Length / 2; i++)
            {
                middleChar += input[i];
            }
        }
        return middleChar;
    }
}