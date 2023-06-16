using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        CheckIfTopNumber(input);

    }

    private static void CheckIfTopNumber(int input)
    {
        for (int i = 0; i <= input; i++)
        {
            int sumOfDigits = 0;

            string numToString = string.Join("", i);
            sumOfDigits = CheckIfDivisibleBy8(i, sumOfDigits, numToString);
        }
    }

    private static int CheckIfDivisibleBy8(int i, int sumOfDigits, string numToString)
    {
        for (int j = 0; j < numToString.Length; j++)
        {
            sumOfDigits += numToString[j];
        }

        if (sumOfDigits % 8 == 0)
        {
            CheckForOddDigit(i, numToString);
        }

        return sumOfDigits;
    }

    private static void CheckForOddDigit(int i, string numToString)
    {
        for (int k = 0; k < numToString.Length; k++)
        {
            if (numToString[k] % 2 != 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}