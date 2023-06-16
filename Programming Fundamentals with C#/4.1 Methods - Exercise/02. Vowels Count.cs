using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(CountVowels(input));
    }
    static int CountVowels(string input)
    {
        string vowelCheck = "aeiou";
        int vowelsCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (vowelCheck.Contains(input[i].ToString().ToLower()))
            {
                vowelsCount++;
            }
        }
        return vowelsCount;
    }
}