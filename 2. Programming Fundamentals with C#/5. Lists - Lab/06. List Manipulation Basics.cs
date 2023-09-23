using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (true)
        {
            string[] command = Console.ReadLine().Split().ToArray();

            if (command[0] == "end")
            {
                break;
            }

            switch (command[0])
            {
                case "Add":
                    list.Add(int.Parse(command[1]));
                    break;

                case "Remove":
                    list.Remove(int.Parse(command[1]));
                    break;

                case "RemoveAt":
                    if (int.Parse(command[1]) > list.Count - 1)
                    {
                        break;
                    }

                    list.RemoveAt(int.Parse(command[1]));
                    break;

                case "Insert":
                    if (int.Parse(command[2]) > list.Count - 1)
                    {
                        break;
                    }
                    list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    break;
            }
        }
        Console.WriteLine(string.Join(' ', list));
    }
}