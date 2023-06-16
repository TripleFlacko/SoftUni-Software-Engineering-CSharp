using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numArray = new int[3];

        for (int i = 0; i < numArray.Length; i++)
        {
            numArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(numArray.Min());
    }
}