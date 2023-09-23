using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();
        List<double> list2 = Console.ReadLine().Split().Select(double.Parse).ToList();
        List<double> finalList = new List<double>();

        for (int i = 0; i < list.Count + list2.Count; i++)
        {
            if (i <= list.Count - 1)
            {
                finalList.Add(list[i]);
            }
            if (i <= list2.Count - 1)
            {
                finalList.Add(list2[i]);
            }
        }
        Console.WriteLine(string.Join(' ', finalList));

    }
}