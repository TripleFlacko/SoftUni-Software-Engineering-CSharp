using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        int changesToList = 0;
        string command;

        while ((command = Console.ReadLine()) != "end")
        {
            List<string> commandList = command.Split().ToList();


            switch (commandList[0])
            {
                case "Add":
                    int numberToAdd = int.Parse(commandList[1]);
                    list.Add(numberToAdd);
                    changesToList++;
                    break;

                case "Remove":
                    int numberToRemove = int.Parse(commandList[1]);
                    list.Remove(numberToRemove);
                    changesToList++;
                    break;

                case "RemoveAt":
                    int index = int.Parse(commandList[1]);
                    if (index > list.Count - 1 || index < 0)
                    {
                        break;
                    }

                    list.RemoveAt(index);
                    changesToList++;
                    break;

                case "Insert":

                    int insertIndex = int.Parse(commandList[2]);
                    int numberToInsert = int.Parse(commandList[1]);

                    if (insertIndex > list.Count - 1 || insertIndex < 0)
                    {
                        break;
                    }

                    list.Insert(insertIndex, numberToInsert);
                    changesToList++;
                    break;

                case "Contains":
                    Contains(list, commandList);
                    break;

                case "PrintEven":
                    PrintEven(list);
                    Console.WriteLine();
                    break;

                case "PrintOdd":
                    PrintOdd(list);
                    Console.WriteLine();
                    break;

                case "GetSum":
                    Console.WriteLine($"{list.Sum()}");
                    break;

                case "Filter":
                    Filter(list, commandList);
                    Console.WriteLine();
                    break;
            }
        }
        if (changesToList > 0)
        {
            Console.WriteLine(string.Join(' ', list));
        }
    }

    private static void Contains(List<int> list, List<string> commandList)
    {
        if (list.Contains(int.Parse(commandList[1])))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }

    private static void PrintEven(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] % 2 == 0)
            {
                Console.Write($"{list[i]} ");
            }
        }
    }

    private static void PrintOdd(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] % 2 != 0)
            {
                Console.Write($"{list[i]} ");
            }
        }
    }

    private static void Filter(List<int> list, List<string> commandList)
    {
        switch (commandList[1])
        {
            case "<":
                SmallerThanGivenNumber(list, commandList);
                break;

            case ">":
                BiggerThanGivenNumber(list, commandList);
                break;

            case "<=":
                SmallerOrEqualToGivenNumber(list, commandList);
                break;

            case ">=":
                BiggerOrEqualToGivenNumber(list, commandList);
                break;
        }
    }

    private static void SmallerThanGivenNumber(List<int> list, List<string> commandList)
    {
        foreach (int num in list)
        {
            if (num < int.Parse(commandList[2]))
            {
                Console.Write($"{num} ");
            }
        }
    }

    private static void BiggerThanGivenNumber(List<int> list, List<string> commandList)
    {
        foreach (int num in list)
        {
            if (num > int.Parse(commandList[2]))
            {
                Console.Write($"{num} ");
            }
        }
    }

    private static void SmallerOrEqualToGivenNumber(List<int> list, List<string> commandList)
    {
        foreach (int num in list)
        {
            if (num <= int.Parse(commandList[2]))
            {
                Console.Write($"{num} ");
            }
        }
    }

    private static void BiggerOrEqualToGivenNumber(List<int> list, List<string> commandList)
    {
        foreach (int num in list)
        {
            if (num >= int.Parse(commandList[2]))
            {
                Console.Write($"{num} ");
            }
        }
    }
}