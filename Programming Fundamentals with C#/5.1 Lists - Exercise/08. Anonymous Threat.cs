using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().ToList();
        string commands;

        while ((commands = Console.ReadLine()) != "3:1")
        {
            var commandList = commands.Split().ToList();

            int startIndex, endIndex, index, partitionsCount;
            startIndex = index = int.Parse(commandList[1]);
            endIndex = partitionsCount = int.Parse(commandList[2]);

            switch (commandList[0])
            {
                case "merge":
                    Merge(input, startIndex, endIndex);
                    break;

                case "divide":
                    Divide(input, index, partitionsCount);
                    break;
            }
        }
        Console.WriteLine(string.Join(' ', input));
    }

    private static void Divide(List<string> input, int index, int partitionsCount)
    {
        var stringToDivide = input[index];
        var stringLength = stringToDivide.Length;
        var partitionSize = stringLength / partitionsCount;
        var lastPartition = stringLength % partitionsCount + partitionSize;

        var result = new string[partitionsCount];

        var forCycleLength = partitionsCount;

        if (stringLength % partitionsCount != 0)
        {
            result[^1] = stringToDivide.Substring(stringLength - lastPartition);
            forCycleLength -= 1;
        }

        for (int i = 0; i < forCycleLength;)
        {
            for (int j = 0; j < forCycleLength; j++)
            {
                result[j] = stringToDivide.Substring(i, partitionSize);
                i += partitionSize;
            }
        }
        input.InsertRange(index + 1, result);
        input.RemoveAt(index);
    }

    private static void Merge(List<string> input, int startIndex, int endIndex)
    {
        if (startIndex < 0)
        {
            startIndex = 0;
        }
        if (endIndex > input.Count - 1)
        {
            endIndex = input.Count - 1;
        }
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            input[startIndex] += input[startIndex + 1];
            input.RemoveAt(startIndex + 1);
        }
    }
}