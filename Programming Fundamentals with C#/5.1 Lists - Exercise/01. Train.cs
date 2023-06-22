using System;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
        int maxCapacity = int.Parse(Console.ReadLine());

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            List<string> commandList = command.Split().ToList();

            if (commandList[0] == "Add")
            {
                wagons.Add(int.Parse(commandList[1]));
            }
            else
            {
                for (int i = 0; i < wagons.Count; i++)
                {
                    if (maxCapacity >= (wagons[i] + int.Parse(commandList[0])))
                    {
                        wagons[i] += int.Parse(commandList[0]);
                        break;
                    }
                }
            }
        }
        Console.WriteLine(string.Join(' ', wagons));
    }
}
