using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var twoStrings = Console.ReadLine().Split().ToArray();
        int sum = 0;
        int loopLength = twoStrings[0].Length > twoStrings[1].Length ? twoStrings[0].Length : twoStrings[1].Length;

        for (int i = 0; i < loopLength; i++)
        {
            if (i < twoStrings[0].Length && i < twoStrings[1].Length)
            {
                sum += twoStrings[0][i] * twoStrings[1][i];
            }
            else if (i > twoStrings[1].Length - 1)
            {
                sum += twoStrings[0][i];
            }
            else if (i > twoStrings[0].Length - 1)
            {
                sum += twoStrings[1][i];
            }
        }
        Console.WriteLine(sum);
    }
}