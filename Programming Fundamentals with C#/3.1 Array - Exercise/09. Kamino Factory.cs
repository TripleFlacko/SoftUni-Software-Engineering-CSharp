using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine()),

            tempDigit = -1,
            sequenceLength = 1,
            sequenceStartIndex = -1,
            sumOfInput = 0,
            inputOrderNumber = 0,

            bestLength = 0,
            bestIndex = int.MaxValue,
            bestSum = 0,
            bestSampleOrderNumber = 0;

        string bestDNASample = "",
            input;

        while ((input = Console.ReadLine()) != "Clone them!")
        {
            int[] dnaArray = input
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            sumOfInput = dnaArray.Sum();

            inputOrderNumber++;

            for (int i = 0; i < length; i++)
            {
                if (dnaArray[i] == tempDigit || (length == 1 && dnaArray[i] > bestLength))
                {
                    sequenceLength++;

                    if (sequenceStartIndex == -1)
                    {
                        sequenceStartIndex = i - 1;
                    }
                    if ((sequenceLength >= bestLength && sequenceStartIndex < bestIndex) || (sequenceStartIndex <= bestIndex && sumOfInput > bestSum))
                    {
                        bestLength = sequenceLength;
                        bestIndex = sequenceStartIndex;
                        bestSum = sumOfInput;
                        bestDNASample = string.Join(" ", input.Split('!', StringSplitOptions.RemoveEmptyEntries));
                        bestSampleOrderNumber = inputOrderNumber;
                    }
                }
                else
                {
                    sequenceLength = 1;
                    sequenceStartIndex = -1;
                }
                tempDigit = dnaArray[i];
            }
            tempDigit = -1;
        }
        Console.WriteLine($"Best DNA sample {bestSampleOrderNumber} with sum: {bestSum}.\n{bestDNASample}");
    }
}