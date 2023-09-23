using System;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        int[] tribonacciSequence = GenerateTribonacci(num);

        Console.WriteLine(string.Join(" ", tribonacciSequence));
    }

    static int[] GenerateTribonacci(int num)
    {
        int[] tribonacciSequence = new int[num];
        if (num >= 1)
            tribonacciSequence[0] = 1;
        if (num >= 2)
            tribonacciSequence[1] = 1;
        if (num >= 3)
            tribonacciSequence[2] = 2;

        for (int i = 3; i < num; i++)
        {
            tribonacciSequence[i] = tribonacciSequence[i - 1] + tribonacciSequence[i - 2] + tribonacciSequence[i - 3];
        }

        return tribonacciSequence;
    }
}