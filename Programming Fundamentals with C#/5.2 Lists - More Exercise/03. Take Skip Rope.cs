using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();
        StringBuilder sb = new StringBuilder(inputString);

        var digits = ExtractDigits(sb);

        var skipList = new List<int>();
        var takeList = new List<int>();
        for (int i = 0; i < digits.Count; i++)
        {
            if (i % 2 == 0)
            {
                takeList.Add(digits[i]);
            }
            else
            {
                skipList.Add(digits[i]);
            }
        }

        var finalList = DecryptText(takeList, skipList, sb);
        Console.WriteLine($"{string.Join("", finalList)}");

    }

    static List<string> DecryptText(List<int> takeList, List<int> skipList, StringBuilder sb)
    {
        var finalList = new List<string>();
        int skipSymbolsCount = 0;

        for (int i = 0; i < takeList.Count; i++)
        {
            if (skipSymbolsCount + takeList[i] >= sb.Length)
            {
                takeList[i] = sb.Length - skipSymbolsCount;
            }
            finalList.Add(sb.ToString().Substring(skipSymbolsCount, takeList[i]));
            skipSymbolsCount += skipList[i] + takeList[i];
        }
        return finalList;
    }

    static List<int> ExtractDigits(StringBuilder sb)
    {
        var digits = new List<int>();
        for (int i = 0; i < sb.Length; i++)
        {
            if (Char.IsDigit(sb[i]))
            {
                digits.Add(sb[i] - '0');
                sb.Remove(i, 1);
                i--;
            }
        }
        return digits;
    }
}