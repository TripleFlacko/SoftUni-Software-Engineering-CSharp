using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        if (input.Length != 1)
        {
            while (true)
            {
                int[] condensed = new int[input.Length - 1];

                for (int i = 0; i < input.Length - 1; i++)
                {
                    condensed[i] = input[i] + input[i + 1];
                }

                input = condensed;

                if (input.Length == 1) break;
            }
        }
        Console.WriteLine(input[0]);
    }
}