using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var filter = Console.ReadLine().Split(", ").ToArray();
        var text = Console.ReadLine();


        for (int i = 0; i < filter.Length; i++)
        {
            while (text.Contains(filter[i]))
            {
                text = text.Replace(filter[i], new string('*', filter[i].Length));
            }
        }
        Console.WriteLine(text);
    }
}