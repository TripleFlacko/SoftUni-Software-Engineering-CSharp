using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            List<string> commandList = command.Split().ToList();

            switch (commandList[0])
            {
                case "Add":

                    int numberAdd = int.Parse(commandList[1]);
                    list.Add(numberAdd);
                    break;

                case "Insert":

                    int numberToInsert = int.Parse(commandList[1]);
                    int index = int.Parse(commandList[2]);

                    if (index < 0 || index >= list.Count)
                    {
                        Console.WriteLine("Invalid index");
                        break;
                    }

                    list.Insert(index, numberToInsert);
                    break;

                case "Remove":

                    int removeIndex = int.Parse(commandList[1]);

                    if (removeIndex < 0 || removeIndex >= list.Count)
                    {
                        Console.WriteLine("Invalid index");
                        break;
                    }

                    list.RemoveAt(removeIndex);
                    break;

                case "Shift":

                    int count = int.Parse(commandList[2]) % list.Count;
                    Shift(list, commandList, count);
                    break;
            }
        }
        Console.WriteLine(string.Join(' ', list));
    }

    private static void Shift(List<int> list, List<string> commandList, int count)
    {
        switch (commandList[1])
        {
            case "left":

                ShiftLeft(list, commandList, count);
                break;

            case "right":

                ShiftRight(list, commandList, count);
                break;
        }
    }

    private static void ShiftRight(List<int> list, List<string> commandList, int count)
    {
        for (int i = list.Count - 1; i > list.Count - 1 - count; i--)
        {
            int temp = list[list.Count - 1];
            list.Insert(0, temp);
            list.RemoveAt(list.Count - 1);
        }
    }

    private static void ShiftLeft(List<int> list, List<string> commandList, int count)
    {
        for (int i = 0; i < count; i++)
        {
            int temp = list[0];
            list.Add(temp);
            list.RemoveAt(0);
        }
    }
}