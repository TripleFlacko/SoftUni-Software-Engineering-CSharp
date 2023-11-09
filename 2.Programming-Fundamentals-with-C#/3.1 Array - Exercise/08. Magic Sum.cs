using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int givenNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (givenNumber == input[i] + input[j])
                {
                    Console.WriteLine($"{input[i]} {input[j]}");
                    break;
                }
            }
        }
    }
}