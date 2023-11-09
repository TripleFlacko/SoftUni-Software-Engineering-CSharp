using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list.Count % 2 == 0 && i == Math.Floor((double)list.Count / 2))
            {
                break;
            }

            list[i] += list[^1];
            list.RemoveAt(list.Count - 1);
        }
        Console.WriteLine(string.Join(' ', list));
    }
}