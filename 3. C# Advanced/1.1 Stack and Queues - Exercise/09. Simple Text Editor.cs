using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var states = new Stack<string>();
        states.Push(string.Empty);
        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var input = Console.ReadLine().Split();
            var command = input[0];
            var value = input.Last();

            switch (command)
            {
                case "1":
                    states.Push(states.Peek() + value);
                    break;

                case "2":
                    var lettersToRemove = int.Parse(value);
                    var newState = states.Peek().Remove(states.Peek().Length - lettersToRemove);
                    states.Push(newState);
                    break;
                case "3":
                    var index = int.Parse(value);
                    var foundChar = states.Peek()[index - 1];
                    Console.WriteLine(foundChar);
                    break;
                case "4":
                    states.Pop();
                    break;
            }
        }
    }
}