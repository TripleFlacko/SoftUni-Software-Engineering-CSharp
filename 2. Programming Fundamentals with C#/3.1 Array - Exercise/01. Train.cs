using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] array = new int[input];

        for (int i = 0; i < input; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"{string.Join(" ", array)}\n{array.Sum()}");
    }
}