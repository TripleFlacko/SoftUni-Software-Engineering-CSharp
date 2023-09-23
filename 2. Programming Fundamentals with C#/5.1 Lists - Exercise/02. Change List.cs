using System;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            List<string> commandList = command.Split().ToList();

            switch (commandList[0])
            {
                case "Delete":
                    list.RemoveAll(x => x == int.Parse(commandList[1]));
                    break;
                case "Insert":
                    list.Insert(int.Parse(commandList[2]), int.Parse(commandList[1]));
                    break;
            }
        }
        Console.WriteLine(string.Join(' ', list));
    }
}