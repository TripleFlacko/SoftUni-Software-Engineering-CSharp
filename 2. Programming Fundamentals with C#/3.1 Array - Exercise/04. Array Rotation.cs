using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rotations = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotations; i++)
        {
            int tempValue = array[0];
            for (int i2 = 0; i2 < array.Length - 1; i2++)
            {
                array[i2] = array[i2 + 1];
            }
            array[array.Length - 1] = tempValue;
        }
        Console.WriteLine(string.Join(" ", array));
    }
}