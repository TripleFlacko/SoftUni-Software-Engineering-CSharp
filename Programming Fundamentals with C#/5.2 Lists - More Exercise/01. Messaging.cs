using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().ToList();
        var numbersSum = new int[numbers.Count];
        var text = Console.ReadLine();
        Console.WriteLine(DecodeMessage(numbers, numbersSum, text));
    }

    static string DecodeMessage(List<string> numbers, int[] numbersSum, string text)
    {
        var decodedText = string.Empty;

        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                numbersSum[i] += Convert.ToInt32(numbers[i][j]) - '0';
            }
        }
        for (int i = 0; i < numbersSum.Length; i++)
        {
            for (int j = 0; numbersSum[i] > text.Length; j++)
            {
                if (numbersSum[i] > text.Length)
                {
                    numbersSum[i] -= text.Length;
                }
            }
        }
        for (int i = 0; i < numbersSum.Length; i++)
        {
            int index = numbersSum[i];
            decodedText += text[index];
            text = text.Remove(index, 1);
        }
        return decodedText;
    }
}