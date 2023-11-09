using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        int[] encryptedWords = new int[lines];
        string vowels = "aeiouAEIOU";
        int sum = 0;

        for (int i = 0; i < lines; i++)
        {
            string input = Console.ReadLine();

            for (int j = 0; j < input.Length; j++)
            {
                bool isVowel = false;

                for (int l = 0; l < vowels.Length; l++)
                {
                    if (input[j] == vowels[l])
                    {
                        sum += input[j] * input.Length;
                        isVowel = true;
                        break;
                    }
                }

                if (!isVowel) sum += input[j] / input.Length;
            }
            encryptedWords[i] = sum;
            sum = 0;
        }

        Array.Sort(encryptedWords);
        foreach (int item in encryptedWords)
        {
            Console.WriteLine(item);
        }
    }
}