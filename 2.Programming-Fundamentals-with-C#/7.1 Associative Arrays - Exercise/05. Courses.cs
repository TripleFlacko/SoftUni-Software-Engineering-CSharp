using System;
using System.Xml.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var dictionary = new Dictionary<string, List<string>>();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            var input = command.Split(':', StringSplitOptions.TrimEntries).ToArray();
            var courseName = input[0];
            var studentName = input[1];

            if (dictionary.ContainsKey(courseName))
            {
                dictionary[courseName].Add(studentName);
            }
            else
            {
                dictionary.Add(courseName, new List<string>() { studentName });
            }
        }
        foreach (var course in dictionary)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");

            foreach (var student in dictionary[course.Key])
            {
                Console.WriteLine($"-- {student}");
            }
        }
    }
}