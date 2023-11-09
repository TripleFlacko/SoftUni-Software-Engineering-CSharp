using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        var arr = input.Split('>').ToArray();
        int remainder = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i][0] - '0' == 0)
            {
                continue;
            }
            else if (arr[i][0] - '0' >= arr[i].Length)
            {
                remainder = arr[i][0] - arr[i].Length - '0';
                arr[i] = "";
                continue;
            }
            else if (arr[i][0] - '0' + remainder > arr[i].Length)
            {
                remainder = arr[i][0] - '0' + remainder - arr[i].Length;
                arr[i] = "";
                continue;
            }
            arr[i] = arr[i].Substring(arr[i][0] - '0' + remainder);
            remainder = 0;
        }
        Console.WriteLine(string.Join('>', arr));
    }
}