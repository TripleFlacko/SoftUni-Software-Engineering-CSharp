using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        var previousLetter = input[0];
        StringBuilder sb = new StringBuilder().Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (previousLetter != input[i])
            {
                sb.Append(input[i]);
            }
            previousLetter = input[i];
        }
        Console.WriteLine(sb);
    }
}