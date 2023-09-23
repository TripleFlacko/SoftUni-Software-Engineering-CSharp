using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] firstArray = new int[input + 1];
        int[] secondArray = new int[input + 1];

        firstArray[1] = 1;
        Console.WriteLine(firstArray[1]);

        for (int row = 1; row < input; row++)
        {
            for (int i = 1; i <= input; i++)
            {
                secondArray[i] = firstArray[i];
            }

            for (int i = 1; i <= row + 1; i++)
            {
                firstArray[i] = secondArray[i - 1] + secondArray[i];
                Console.Write(firstArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}