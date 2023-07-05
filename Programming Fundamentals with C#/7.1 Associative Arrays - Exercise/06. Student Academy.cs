using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var dictionary = new Dictionary<string, List<double>>();

        int numberLines = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberLines; i++)
        {
            var name = Console.ReadLine();
            var grade = double.Parse(Console.ReadLine());

            if (dictionary.ContainsKey(name))
            {
                dictionary[name].Add(grade);
            }
            else
            {
                dictionary.Add(name, new List<double>() { grade });
            }
        }
        foreach (var student in dictionary)
        {
            if (student.Value.Average() >= 4.50)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }

    }
}