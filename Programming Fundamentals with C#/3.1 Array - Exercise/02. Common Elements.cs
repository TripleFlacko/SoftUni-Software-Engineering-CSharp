using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input1 = Console.ReadLine().Split();
        string[] input2 = Console.ReadLine().Split();
        string output = string.Empty;

        for (int i = 0; i < input2.Length; i++)
        {
            for (int i2 = 0; i2 < input1.Length; i2++)
            {
                if (input2[i] == input1[i2])
                {
                    output += input2[i] + " ";
                }
            }
        }
        Console.WriteLine(output);
    }
}