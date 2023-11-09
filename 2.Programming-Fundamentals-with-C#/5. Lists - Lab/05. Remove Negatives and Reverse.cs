using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        list.RemoveAll(x => x < 0);
        list.Reverse();

        if (list.Count < 1)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(' ', list));
        }
    }
}