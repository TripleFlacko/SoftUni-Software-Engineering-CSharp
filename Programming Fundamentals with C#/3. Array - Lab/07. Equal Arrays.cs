using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int diffIndex = -1;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != input2[i])
            {
                diffIndex = i;
                Console.WriteLine($"Arrays are not identical. Found difference at {diffIndex} index");
                break;
            }
        }
        if (diffIndex == -1) Console.WriteLine($"Arrays are identical. Sum: {input.Sum()}");
    }
}