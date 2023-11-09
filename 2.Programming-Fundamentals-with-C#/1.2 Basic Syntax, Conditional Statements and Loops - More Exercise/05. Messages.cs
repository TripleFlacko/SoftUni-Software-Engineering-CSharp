using System;

namespace _05.Messages
{
    class Program
    {
        static void Main()
        {
            int numberOfLetters = int.Parse(Console.ReadLine());
            string output = string.Empty;

            for (int i = 0; i < numberOfLetters; i++)
            {
                string input = Console.ReadLine();
                int mainDigit = int.Parse(input[0].ToString());
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 0) { output += " "; continue; }
                if (8 <= mainDigit && mainDigit <= 9) offset++;

                int letterIndex = (offset + input.Length - 1) + 97;
                char letter = (char)letterIndex;
                output += letter;
            }
            Console.WriteLine(output);
        }
    }
}