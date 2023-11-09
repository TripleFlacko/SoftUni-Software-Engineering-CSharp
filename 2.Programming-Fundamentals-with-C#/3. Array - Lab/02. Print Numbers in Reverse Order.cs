using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int[] numArray = new int[numbers];
        for (int i = 0; i < numArray.Length; i++)
        {
            numArray[i] = int.Parse(Console.ReadLine());
        }
        Array.Reverse(numArray);
        Console.WriteLine(String.Join(' ', numArray));
    }
}