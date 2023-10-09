using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse);
        Stack<int> stack = new Stack<int>(input);

        string command;
        while ((command = Console.ReadLine()).ToLower() != "end")
        {
            var commands = command.Split();
            switch (commands[0].ToLower())
            {
                case "add":
                    stack.Push(int.Parse(commands[1]));
                    stack.Push(int.Parse(commands[2]));
                    break;
                case "remove":
                    int number = int.Parse(commands[1]);
                    if (number > stack.Count)
                    {
                        break;
                    }
                    for (int i = 0; i < number; i++)
                    {
                        stack.Pop();
                    }
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine($"Sum: {stack.ToArray().Sum()}");
    }
}