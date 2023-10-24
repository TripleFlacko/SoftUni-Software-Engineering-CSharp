using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();
        for (int i = 0; i < 3; i++)
        {
            if (i == input.Length)
            {
                break;
            }
            Console.Write(input[i] + " ");
        }
    }
}