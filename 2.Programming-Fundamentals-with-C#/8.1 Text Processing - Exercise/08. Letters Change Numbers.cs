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
        var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
        decimal result = 0m;

        for (int i = 0; i < input.Length; i++)
        {
            decimal tempResult = 0;
            var letters = input[i].Where(letter => char.IsLetter(letter)).ToArray();
            decimal number = decimal.Parse(string.Join("", input[i].Where(letter => char.IsNumber(letter))));
            decimal alphabeticalPosition1 = char.ToLower(letters[0]) - 96;
            decimal alphabeticalPosition2 = char.ToLower(letters[1]) - 96;

            if (char.IsUpper(letters[0]))
            {
                tempResult += number / alphabeticalPosition1;
            }
            else if (char.IsLower(letters[0]))
            {
                tempResult += number * alphabeticalPosition1;
            }
            if (char.IsUpper(letters[1]))
            {
                tempResult = tempResult - alphabeticalPosition2;
            }
            else if (char.IsLower(letters[1]))
            {
                tempResult += alphabeticalPosition2;
            }

            result += tempResult;
        }

        Console.WriteLine($"{result:f2}");
    }
}