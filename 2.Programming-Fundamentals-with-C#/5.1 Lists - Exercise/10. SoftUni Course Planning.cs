using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<string> list = Console.ReadLine().Split(", ").ToList();

        string command;
        while ((command = Console.ReadLine()) != "course start")
        {
            List<string> commandList = command.Split(':').ToList();

            var lessonTitle = commandList[1];

            switch (commandList[0])
            {
                case "Add":
                    Add(list, lessonTitle);
                    break;

                case "Insert":
                    Insert(list, commandList, lessonTitle);
                    break;

                case "Remove":
                    Remove(list, lessonTitle);
                    break;

                case "Swap":
                    Swap(list, commandList, lessonTitle);
                    break;

                case "Exercise":
                    Exercise(list, lessonTitle);
                    break;
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{list[i]}");
        }
    }

    private static void Exercise(List<string> list, string lessonTitle)
    {
        if (list.Contains(lessonTitle) && !list.Contains($"{lessonTitle}-Exercise"))
        {
            int index = list.IndexOf(lessonTitle);

            if (index + 1 >= list.Count)
            {
                list.Add($"{lessonTitle}-Exercise");
            }
            else
            {
                list.Insert(index + 1, $"{lessonTitle}-Exercise");
            }
        }
        else if (!list.Contains(lessonTitle))
        {
            list.Add(lessonTitle);
            list.Add($"{lessonTitle}-Exercise");
        }
    }

    private static void Swap(List<string> list, List<string> commandList, string lessonTitle)
    {
        string secondLessonTitle = commandList[2];
        if (list.Contains(lessonTitle) && list.Contains(secondLessonTitle))
        {
            int firstIndex = list.IndexOf(lessonTitle);
            int secondIndex = list.IndexOf(secondLessonTitle);

            list.RemoveAt(firstIndex);
            list.Insert(firstIndex, secondLessonTitle);

            list.RemoveAt(secondIndex);
            list.Insert(secondIndex, lessonTitle);

            if (list.Contains($"{lessonTitle}-Exercise"))
            {
                list.Remove($"{lessonTitle}-Exercise");

                if (secondIndex + 1 >= list.Count)
                {
                    list.Add($"{lessonTitle}-Exercise");
                }
                else
                {
                    list.Insert(secondIndex + 1, $"{lessonTitle}-Exercise");
                }
            }
            else if (list.Contains($"{secondLessonTitle}-Exercise"))
            {
                list.Remove($"{secondLessonTitle}-Exercise");

                if (firstIndex + 1 >= list.Count)
                {
                    list.Add($"{secondLessonTitle}-Exercise");
                }
                else
                {
                    list.Insert(firstIndex + 1, $"{secondLessonTitle}-Exercise");
                }
            }
        }
    }

    private static void Remove(List<string> list, string lessonTitle)
    {
        if (list.Contains(lessonTitle))
        {
            list.Remove(lessonTitle);

            if (list.Contains($"{lessonTitle}-Exercise"))
            {
                list.Remove($"{lessonTitle}-Exercise");
            }
        }
    }

    private static void Insert(List<string> list, List<string> commandList, string lessonTitle)
    {
        if (!list.Contains(lessonTitle))
        {
            int index = int.Parse(commandList[2]);
            list.Insert(index, lessonTitle);
        }
    }

    private static void Add(List<string> list, string lessonTitle)
    {
        if (!list.Contains(lessonTitle))
        {
            list.Add(lessonTitle);
        }
    }
}