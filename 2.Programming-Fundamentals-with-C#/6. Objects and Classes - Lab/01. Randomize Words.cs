using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> list = Console.ReadLine().Split().ToList();

        Random random = new Random();

        for (int i = 0; i < list.Count; i++)
        {
            int index = random.Next(0, list.Count - 1);
            string temp = list[i];
            list.RemoveAt(i);
            list.Insert(index, temp);
        }
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}