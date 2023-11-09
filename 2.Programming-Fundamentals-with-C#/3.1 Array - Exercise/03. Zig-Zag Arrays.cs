using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int[] arr1 = new int[input];
        int[] arr2 = new int[input];

        for (int i = 0; i < input; i++)
        {
            int[] tempArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (i % 2 == 0)
            {
                arr1[i] = tempArray[0];
                arr2[i] = tempArray[1];
            }
            else
            {
                arr1[i] = tempArray[1];
                arr2[i] = tempArray[0];
            }
        }
        Console.WriteLine($"{string.Join(" ", arr1)}\n{string.Join(" ", arr2)}");
    }
}