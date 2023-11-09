using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMultipleOfEvenAndOdds(input));
    }
    static int GetMultipleOfEvenAndOdds(int input)
    {
        string tempString = Math.Abs(input).ToString();

        int[] odds = new int[tempString.Length];
        int[] evens = new int[tempString.Length];

        for (int i = 0; i < tempString.Length; i++)
        {
            if (tempString[i] % 2 == 0) evens[i] = tempString[i] - '0';
            else odds[i] = tempString[i] - '0';
        }
        return GetSumOfEvenDigits(evens, tempString) * GetSumOfOddDigits(odds, tempString);
    }
    static int GetSumOfEvenDigits(int[] evens, string tempstring)
    {
        int sumEvens = 0;

        for (int i = 0; i < tempstring.Length; i++)
        {
            sumEvens += evens[i];
        }
        return sumEvens;
    }
    static int GetSumOfOddDigits(int[] odds, string tempstring)
    {
        int sumOdds = 0;

        for (int i = 0; i < tempstring.Length; i++)
        {
            sumOdds += odds[i];
        }
        return sumOdds;
    }
}