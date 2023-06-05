using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int checker = int.MinValue;
        int sequence = 0;
        int longestSequence = 0;
        int longestSequenceDigit = int.MinValue;

        for (int i = 0; i < input.Length; i++)
        {

            if (input[i] == checker)
            {
                sequence++;
            }
            else
            {
                sequence = 0;
            }
            if (sequence > longestSequence)
            {
                longestSequence = sequence;
                longestSequenceDigit = input[i];
            }
            checker = input[i];
        }
        for (int i = 0; i <= longestSequence; i++)
        {
            Console.Write($"{longestSequenceDigit} ");
        }
    }
}