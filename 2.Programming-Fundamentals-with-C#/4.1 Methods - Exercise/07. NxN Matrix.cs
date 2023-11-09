using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        PrintNxNMatrix(input);
    }
    static void PrintNxNMatrix(int input)
    {
        for (int i = 0; i < input; i++)
        {
            for (int j = 0; j < input; j++)
            {
                Console.Write(input + " ");
            }
            Console.WriteLine();
        }
    }
}